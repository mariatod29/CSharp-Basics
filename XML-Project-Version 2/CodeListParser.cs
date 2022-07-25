using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

class CodeListParser
{
    internal Dictionary<string, string> GetRulePlanRsa()
    {
        var codeListBytes = File.ReadAllBytes(@"C:\Users\mtodorova\OneDrive - Blubito GmbH\Dokumente\Codelists\C17000608_genericode.xml");
        return GetValuePairs(codeListBytes, "code", "name");
    }

    public Dictionary<string, string> GetLegalForms()
    {
        var codeListBytes = File.ReadAllBytes(@"C:\Users\mtodorova\OneDrive - Blubito GmbH\Dokumente\Codelists\C60000022_genericode.xml");
        return GetValuePairs(codeListBytes, "Code", "Bezeichnung");
    }


    Dictionary<string, string> GetValuePairs(byte[] codeListBytes, string keyName, string valueName)
    {
        XDocument xDoc = XDocument.Load(new MemoryStream(codeListBytes));
        XNamespace ns = "http://docs.oasis-open.org/codelist/ns/genericode/1.0/";
        IEnumerable<XElement> rows = from row in xDoc.Descendants(ns + "Row")
                                     select row;

        var namesByCode = new Dictionary<string, string>();

        foreach (var row in rows)
        {
            var code = row.Elements(ns + "Value").FirstOrDefault(v => (string)v.Attribute("ColumnRef") == keyName).Value ?? string.Empty;
            var value = row.Elements(ns + "Value").FirstOrDefault(v => (string)v.Attribute("ColumnRef") == valueName).Value ?? string.Empty;

            namesByCode.Add(code, value);
        }

        foreach (var item in namesByCode)
        {
            Console.WriteLine("Key - {0}, Value - {1}", item.Key, item.Value);
        }
        // namesByCode.ToList().ForEach(x => Console.WriteLine(x.Key));

        return namesByCode;
    }
}