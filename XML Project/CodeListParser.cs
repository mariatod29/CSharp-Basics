using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

[XmlRoot("Value")]

//Here is the class:
public class CodeListParser
{
    public string simpleValueCode { get; set; }
    public string simpleValueName { get; set; }

    public CodeListParser()
    {
        this.simpleValueCode = simpleValueCode;
        this.simpleValueName = simpleValueName;
    }
}


