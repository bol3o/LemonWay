using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Model.ModelXml
{
    public class HPay
    {
        [XmlElement("ID")]
        public string ID { get; set; }
        [XmlElement("STATUS")]
        public string STATUS { get; set; }
        [XmlElement("EXTRA")]
        public Extra EXTRA { get; set; }
        [XmlElement("INT_MSG")]
        public string INT_MSG { get; set; }
        [XmlElement("MLABEL")]
        public string MLABEL { get; set; }
        [XmlElement("MTOKEN")]
        public string MTOKEN { get; set; }
    }
}
