using System.Collections.Generic;
using System.Xml.Serialization;

namespace ItemFormatter.Models
{
    [XmlRoot(ElementName = "CLASSRESTRICTIONS")]
    public class ClassRestrictions
    {
        [XmlElement(ElementName = "CLASS")]
        public string Class { get; set; }
    }

    [XmlRoot(ElementName = "ASSOCIATE")]
    public class Associate
    {
        [XmlAttribute(AttributeName = "IsParent")]
        public string IsParent { get; set; }
    }

    [XmlRoot(ElementName = "SLOT")]
    public class Slot
    {
        public Slot()
        {
            Remakes = "0";
            Effect = "";
            Qua = "99";
            Amount = "0";
            Done = "0";
            Type = "0";
            Type = "Unused";
        }

        [XmlAttribute(AttributeName = "NAME")]
        public string Name { get; set; }

        [XmlText]
        public string Text { get; set; }

        [XmlElement(ElementName = "Remakes")]
        public string Remakes { get; set; }

        [XmlElement(ElementName = "Effect")]
        public string Effect { get; set; }

        [XmlElement(ElementName = "Qua")]
        public string Qua { get; set; }

        [XmlElement(ElementName = "Amount")]
        public string Amount { get; set; }

        [XmlElement(ElementName = "Done")]
        public string Done { get; set; }

        [XmlElement(ElementName = "Time")]
        public string Time { get; set; }

        [XmlElement(ElementName = "Type")]
        public string Type { get; set; }

        [XmlAttribute(AttributeName = "Number")]
        public string Number { get; set; }
    }

    [XmlRoot(ElementName = "EQUIPLIST")]
    public class EquipList
    {
        [XmlElement(ElementName = "SLOT")]
        public Slot Slot { get; set; }
    }

    [XmlRoot(ElementName = "DROPITEM")]
    public class DropItem
    {
        [XmlElement(ElementName = "SLOT")]
        public List<Slot> Slot { get; set; }
    }

    [XmlRoot(ElementName = "SCItem")]
    public class ScItem
    {
        public ScItem()
        {
            ActiveState = "drop";
            Equipped = "0";
            Level = "51";
            Offhand = "no";
            Source = "drop";
            DbSource = "Genesis";
            ClassRestrictions = new ClassRestrictions {Class = "All"};
            IsUnique = "0";
            OracleIgnore = "0";
            UserValue = "0";
            Variant = "";
            Associate = new Associate {IsParent = "0"};

            DropItem = new DropItem {Slot = new List<Slot>()};
            for (var i = 0; i < 9; i++)
            {
                DropItem.Slot.Add(new Slot {Number = i.ToString()});
            }
        }

        [XmlElement(ElementName = "ActiveState")]
        public string ActiveState { get; set; }

        [XmlElement(ElementName = "Location")]
        public string Location { get; set; }

        [XmlElement(ElementName = "Realm")]
        public string Realm { get; set; }

        [XmlElement(ElementName = "ItemName")]
        public string ItemName { get; set; }

        [XmlElement(ElementName = "AFDPS")]
        public string AFDPS { get; set; }

        [XmlElement(ElementName = "Bonus")]
        public string Bonus { get; set; }

        [XmlElement(ElementName = "ItemQuality")]
        public string ItemQuality { get; set; }

        [XmlElement(ElementName = "Equipped")]
        public string Equipped { get; set; }

        [XmlElement(ElementName = "Level")]
        public string Level { get; set; }

        [XmlElement(ElementName = "OFFHAND")]
        public string Offhand { get; set; }

        [XmlElement(ElementName = "SOURCE")]
        public string Source { get; set; }

        [XmlElement(ElementName = "TYPE")]
        public string Type { get; set; }

        [XmlElement(ElementName = "DBSOURCE")]
        public string DbSource { get; set; }

        [XmlElement(ElementName = "CLASSRESTRICTIONS")]
        public ClassRestrictions ClassRestrictions { get; set; }

        [XmlElement(ElementName = "ISUNIQUE")]
        public string IsUnique { get; set; }

        [XmlElement(ElementName = "ORACLE_IGNORE")]
        public string OracleIgnore { get; set; }

        [XmlElement(ElementName = "USER_VALUE")]
        public string UserValue { get; set; }

        [XmlElement(ElementName = "VARIANT")]
        public string Variant { get; set; }

        [XmlElement(ElementName = "ASSOCIATE")]
        public Associate Associate { get; set; }

        [XmlElement(ElementName = "EQUIPLIST")]
        public EquipList EquipList { get; set; }

        [XmlElement(ElementName = "DROPITEM")]
        public DropItem DropItem { get; set; }
    }
}
