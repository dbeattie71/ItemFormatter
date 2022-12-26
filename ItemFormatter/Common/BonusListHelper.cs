using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ItemFormatter.Models;

namespace ItemFormatter.Common
{
    public class BonusListHelper
    {
        public ILookup<string, string> EffectTypeLookup { get; }
        public ILookup<string, string> ResistNameLookup { get; }
        public ILookup<string, string> SkillNameLookup { get; }

        public Dictionary<string, string> _effectMappings = new Dictionary<string, string>
        {
            {"Power Pool", "power pool"},
            {"Bonus to casting speed", "casting speed"},
            {"Spell Range", "spell range"},
        };

        public BonusListHelper(string bonusListPath)
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
                .Where(
                    b => b.Type == "Statistic" ||
                         b.Type == "Resistance" ||
                         b.Type == "Skill" ||
                         b.Type == "Cap Increase" ||
                         b.Type == "TOA Bonus"
                )
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

        public string Lookup(string effect)
        {
            if (_effectMappings.ContainsKey(effect))
            {
                return _effectMappings[effect];
            }

            return EffectTypeLookup[effect].First();
        }
    }
}
