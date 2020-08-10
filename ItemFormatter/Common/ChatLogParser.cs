using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ItemFormatter.Common
{
    public class ChatLogParser
    {
        private readonly Regex _delve =
            new Regex(
                @"(?<Everything>(?<RawLogTimeStamp>\[(?<LogTimeStamp>[\d:]+)\])[ ]+(?<OuterDelveBody><Begin Info: (?<DelveName>[^>]*)>(?<DelveBody>[^<]+)<End Info>))");

        private readonly Regex _bonuses = new Regex(@".*\|\s(?<Bonus>.*:.*)");

        public string GetMostRecentItem(string chatLogpath)
        {
            var rawItem = InternalGetMostRecentItem(chatLogpath);
            var formattedItem = FormatItem(rawItem);
            return formattedItem;
        }

        private string InternalGetMostRecentItem(string chatLogPath)
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

            var sb = new StringBuilder();
            lines.ForEach(item => sb.AppendLine(item));

            return sb.ToString();
        }

        private string FormatItem(string item)
        {
            var match = _delve.Match(item);
            var delveName = match.Groups["DelveName"];
            var delveBody = match.Groups["DelveBody"];
            var bonuses = _bonuses.Matches(delveBody.Value);

            var sb = new StringBuilder();
            sb.AppendLine(delveName.Value);
            foreach (Match bonusMatch in bonuses)
            {
                sb.Append($"{Clean(bonusMatch.Groups["Bonus"].Value)}");
            }

            sb.Append("dlv");

            return sb.ToString();
        }

        private string Clean(string source)
        {
            return source
                .Replace("\r\n", "")
                .Replace("+", "")
                .Replace("%", "")
                .Replace("pts", "");
        }
    }
}
