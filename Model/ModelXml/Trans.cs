using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Model.ModelXml
{
    [XmlRoot("TRANS")]
    public class Trans
    {
        [XmlElement("HPAY")]
        public List<HPay> HPAY { get; set; }

        public Trans()
        {
        }
    }
}
