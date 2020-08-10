using System;
using System.IO;
using System.Linq;
using ItemFormatter.Models;

namespace ItemFormatter.Common
{
    public class Mapper
    {
        private readonly BonusListHelper _bonusListHelper;

        public Mapper(BonusListHelper bonusListHelper)
        {
            _bonusListHelper = bonusListHelper;
        }

        public void SaveScItem(string source, string savePath)
        {
            var valueTuple = GetScItem(source);
            var scItem = valueTuple.ScItem;
            var fileName = GetFilename(savePath, valueTuple.HouseNumber, scItem.ItemName);
            XmlHelper.SerializeToXmlFile(scItem, fileName);
        }

        private string GetFilename(string savePath, string houseNumber, string itemName)
        {
            var itemNameUnder = itemName.Replace(' ', '_');
            var itemNameWithNumber = $"{houseNumber}_{itemNameUnder}.xml";
            return Path.Combine(savePath, itemNameWithNumber);
        }

        private (string HouseNumber, ScItem ScItem) GetScItem(string source)
        {
            var lines = parseLines(source);

            var itemName = lines.First();
            var houseNumber = lines.Last();

            var scItem = new ScItem {ItemName = itemName.TrimEnd(" x 1", StringComparison.OrdinalIgnoreCase)};

            var contentLines = lines.Skip(1)
                .Take(lines.Length - 2)
                .ToList();

            var count = 0;
            foreach (var contentLine in contentLines)
            {
                var valueTuple = parseLine(contentLine);

                var type = _bonusListHelper.EffectTypeLookup[valueTuple.Effect].First();
                var mappedType = MapType(type);
                var effect = MapEffect(type, valueTuple.Effect);

                scItem.DropItem.Slot[count] = new Slot
                {
                    Number = count.ToString(),
                    Effect = effect,
                    Amount = valueTuple.Value,
                    Type = mappedType
                };

                count++;
            }

            return (houseNumber, scItem);
        }

        private string[] parseLines(string source)
        {
            return source.Split(
                new[] {"\r\n", "\r", "\n"},
                StringSplitOptions.None
            );
        }

        private (string Effect, string Value) parseLine(string line)
        {
            var split = line.Split(':', StringSplitOptions.RemoveEmptyEntries);
            return (split[0].Trim(), split[1].Trim());
        }

        private string MapType(string effect)
        {
            return effect switch
            {
                "Statistic" => "Stat",
                "Resistance" => "Resist",
                _ => "Skill"
            };
        }

        private string MapEffect(string type, string name)
        {
            if (IsResist(name))
            {
                return _bonusListHelper.ResistNameLookup[name].First();
            }

            return type == "Statistic" ? name : _bonusListHelper.SkillNameLookup[name].First();
        }

        private bool IsResist(string name)
        {
            return _bonusListHelper.ResistNameLookup.Contains(name);
        }
    }
}
