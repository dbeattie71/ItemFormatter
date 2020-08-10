using System.Collections.Generic;
using System.Xml.Serialization;

namespace ItemFormatter.Models
{
    [XmlRoot(ElementName = "name")]
    public class Name
    {
        [XmlAttribute(AttributeName = "language")]
        public string Language { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "MythicName")]
    public class MythicName
    {
        [XmlAttribute(AttributeName = "language")]
        public string Language { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "material")]
    public class Material
    {
        [XmlAttribute(AttributeName = "base")]
        public string Base { get; set; }

        [XmlAttribute(AttributeName = "incr")]
        public string Incr { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "jewel")]
    public class Jewel
    {
        [XmlElement(ElementName = "name")]
        public List<Name> Name { get; set; }

        [XmlElement(ElementName = "material")]
        public List<Material> Material { get; set; }

        [XmlAttribute(AttributeName = "baseline")]
        public string Baseline { get; set; }

        [XmlAttribute(AttributeName = "realm")]
        public string Realm { get; set; }

        [XmlAttribute(AttributeName = "base")]
        public string Base { get; set; }

        [XmlAttribute(AttributeName = "incr")]
        public string Incr { get; set; }
    }

    [XmlRoot(ElementName = "bonus")]
    public class Bonus
    {
        [XmlElement(ElementName = "name")]
        public List<Name> Name { get; set; }

        [XmlElement(ElementName = "MythicName")]
        public List<MythicName> MythicName { get; set; }

        [XmlElement(ElementName = "KortName")]
        public string KortName { get; set; }

        [XmlElement(ElementName = "realm")]
        public string Realm { get; set; }

        [XmlElement(ElementName = "melee")]
        public string Melee { get; set; }

        [XmlElement(ElementName = "magic")]
        public string Magic { get; set; }

        [XmlElement(ElementName = "dualwield")]
        public string DualWield { get; set; }

        [XmlElement(ElementName = "archery")]
        public string Archery { get; set; }

        [XmlElement(ElementName = "slot")]
        public string Slot { get; set; }

        [XmlElement(ElementName = "craftable")]
        public string Craftable { get; set; }

        [XmlElement(ElementName = "optimizable")]
        public string Optimizable { get; set; }

        [XmlElement(ElementName = "jewel")]
        public Jewel Jewel { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
    }

    [XmlRoot(ElementName = "BonusList")]
    public class BonusList
    {
        [XmlElement(ElementName = "bonus")]
        public List<Bonus> Bonus { get; set; }
    }
}
