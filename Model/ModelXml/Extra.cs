using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Model
{
    public class Extra
    {
        [XmlElement("IS3DS")]
        public string IS3DS { get; set; }
        [XmlElement("AUTH")]
        public string AUTH { get; set; }

        public Extra()
        {
        }
    }
}
