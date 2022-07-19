using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace XMLProject
{
    [Serializable()]
    public class Row
    {
        [XmlElement("Value")]
        public string simpleValueCode { get; set; }
        [XmlElement("Value")]
        public string simpleValueName { get; set; }
    }
}
