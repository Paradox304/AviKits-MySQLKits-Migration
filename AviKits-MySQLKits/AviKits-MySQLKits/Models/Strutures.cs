using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AviKits_MySQLKits.Models
{
    [XmlRoot(ElementName = "Item")]
    public class Item
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "amount")]
        public string Amount { get; set; }
        [XmlAttribute(AttributeName = "durability")]
        public string Durability { get; set; }

        [XmlElement(ElementName = "Firemode")]
        public string Firemode { get; set; }
        [XmlElement(ElementName = "Ammo")]
        public string Ammo { get; set; }
        [XmlElement(ElementName = "Magazine")]
        public Magazine Magazine { get; set; }
        [XmlElement(ElementName = "Tactical")]
        public Tactical Tactical { get; set; }
        [XmlElement(ElementName = "Sight")]
        public Sight Sight { get; set; }
        [XmlElement(ElementName = "Grip")]
        public Grip Grip { get; set; }
        [XmlElement(ElementName = "Barrel")]
        public Barrel Barrel { get; set; }
    }

    [XmlRoot(ElementName = "Magazine")]
    public class Magazine
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "durability")]
        public string Durability { get; set; }
    }

    [XmlRoot(ElementName = "Tactical")]
    public class Tactical
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "durability")]
        public string Durability { get; set; }
    }

    [XmlRoot(ElementName = "Items")]
    public class Items
    {
        [XmlElement(ElementName = "Item")]
        public List<Item> Item { get; set; }
    }

    [XmlRoot(ElementName = "Kit")]
    public class Kit
    {
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "Cooldown")]
        public string Cooldown { get; set; }
        [XmlElement(ElementName = "ResetCooldownWhenDie")]
        public string ResetCooldownWhenDie { get; set; }
        [XmlElement(ElementName = "UseCost")]
        public string UseCost { get; set; }
        [XmlElement(ElementName = "VehicleId")]
        public string VehicleId { get; set; }
        [XmlElement(ElementName = "Xp")]
        public string Xp { get; set; }
        [XmlElement(ElementName = "Items")]
        public Items Items { get; set; }
    }

    [XmlRoot(ElementName = "Sight")]
    public class Sight
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "durability")]
        public string Durability { get; set; }
    }

    [XmlRoot(ElementName = "Grip")]
    public class Grip
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "durability")]
        public string Durability { get; set; }
    }

    [XmlRoot(ElementName = "Barrel")]
    public class Barrel
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "durability")]
        public string Durability { get; set; }
    }

    [XmlRoot(ElementName = "Kits")]
    public class Kits
    {
        [XmlElement(ElementName = "Kit")]
        public List<Kit> Kit { get; set; }
    }
}
