using System.Collections.Generic;

namespace ItemFormatter.Common
{
    public class ChatLogParser
    {
        public List<string> GetMostRecentItem(string chatLogPath)
        {
            using var reader =
                new ReverseFileReader(chatLogPath)
                {
                    LineEnding = LineEnding.CrLf
                };

            var lines = new List<string>();

            var endFound = false;
            while (!reader.StartOfFile)
            {
                var line = reader.ReadLine();

                if (line.Contains("<End Info>"))
                {
                    endFound = true;
                }

                if (endFound)
                {
                    lines.Insert(0, line);
                }

                if (endFound && line.Contains("<Begin Info:"))
                {
                    break;
                }
            }

            return lines;
        }
    }
}
