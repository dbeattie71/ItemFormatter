using System;
using System.IO;
using System.Linq;
using ItemFormatter.Models;

namespace ItemFormatter.Common
{
    public class LokiHelper
    {
        public ILookup<string, string> EffectTypeLookup { get; }
        public ILookup<string, string> ResistNameLookup { get; }
        public ILookup<string, string> SkillNameLookup { get; }

        public LokiHelper(string bonusListPath)
        {
            static Tuple<string, string, string> Create(Bonus b)
            {
                var englishName = b.Name.FirstOrDefault();
                var englishMythicName = b.MythicName.FirstOrDefault();
                var englishKortName = b.KortName;

                var name = englishMythicName != null ? englishMythicName.Text : englishName.Text;
                var kortName = englishKortName ?? englishName.Text;

                return Tuple.Create(b.Type, name, kortName);
            }

            var bonusList = XmlHelper.DeserializeFromXmlFile<BonusList>(bonusListPath);

            EffectTypeLookup = bonusList.Bonus
                .Where(b => b.Type == "Statistic" || b.Type == "Resistance" || b.Type == "Skill")
                .Select(Create)
                .ToLookup(t => t.Item2, t => t.Item1);

            ResistNameLookup = bonusList.Bonus
                .Where(b => b.Type == "Resistance")
                .ToLookup(t => t.Name.First().Text, t => t.KortName);

            SkillNameLookup = bonusList.Bonus
                .Where(b => b.Type == "Skill")
                .Select(Create)
                .ToLookup(t => t.Item2, t => t.Item3);
        }
    }

    public class Mapper
    {
        private readonly ILookup<string, string> _effectTypeLookup;
        private readonly ILookup<string, string> _resistNameLookup;
        private readonly ILookup<string, string> _skillNameLookup;

        public Mapper(string bonusListPath)
        {
            static Tuple<string, string, string> Create(Bonus b)
            {
                var englishName = b.Name.FirstOrDefault();
                var englishMythicName = b.MythicName.FirstOrDefault();
                var englishKortName = b.KortName;

                var name = englishMythicName != null ? englishMythicName.Text : englishName.Text;
                var kortName = englishKortName ?? englishName.Text;

                return Tuple.Create(b.Type, name, kortName);
            }

            var bonusList = XmlHelper.DeserializeFromXmlFile<BonusList>(bonusListPath);

            _effectTypeLookup = bonusList.Bonus
                .Where(b => b.Type == "Statistic" || b.Type == "Resistance" || b.Type == "Skill")
                .Select(Create)
                .ToLookup(t => t.Item2, t => t.Item1);

            _resistNameLookup = bonusList.Bonus
                .Where(b => b.Type == "Resistance")
                .ToLookup(t => t.Name.First().Text, t => t.KortName);

            _skillNameLookup = bonusList.Bonus
                .Where(b => b.Type == "Skill")
                .Select(Create)
                .ToLookup(t => t.Item2, t => t.Item3);
        }

        public void SaveScItem(string source, string savePath)
        {
            var valueTuple = GetScItem(source);
            var scItem = valueTuple.ScItem;
            var fileName = GetFilename(savePath, valueTuple.HouseNumber, scItem.ItemName);
            XmlHelper.SerializeToXmlFile(scItem, fileName);
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

            var scItem = new ScItem {ItemName = itemName.TrimEnd(" x 1")};

            var contentLines = lines.Skip(1)
                .Take(lines.Length - 2)
                .ToList();

            var count = 0;
            foreach (var contentLine in contentLines)
            {
                var valueTuple = parseLine(contentLine);

                var type = _effectTypeLookup[valueTuple.Effect].First();
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
                return _resistNameLookup[name].First();
            }

            return type == "Statistic" ? name : _skillNameLookup[name].First();
        }

        private bool IsResist(string name)
        {
            return _resistNameLookup.Contains(name);
        }

      
    }
}
