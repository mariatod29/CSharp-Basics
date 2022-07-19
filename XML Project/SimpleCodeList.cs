using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace XMLProject
{
    //[System.Xml.Serialization.XmlRootAttribute("CodeList", Namespace = "", IsNullable = false)]
    [Serializable, XmlRoot("SimpleCodeList")]
    public class SimpleCodeList
    {
        [XmlArray("SimpleCodeList")]
        [XmlArrayItem(typeof(Row))]
        public Row[] Rows { get; set; }
    }
}
