using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using XMLProject;

class Program
{
    public static void Main()
    {
        /*try
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\mtodorova\source\repos\XMLProject\XMLProject\bin\Debug\net6.0\C17000608_genericode.xml");

            XmlNodeList nodes = doc.SelectNodes("//SimpleCodeList/Row/Value/SimpleValue");
            List<CodeListParser> values = new List<CodeListParser>();
            foreach (XmlNode xmlNode in nodes)
            {
                CodeListParser value = new CodeListParser();
                value.simpleValueCode = xmlNode["code"].InnerText;
                value.simpleValueName = xmlNode["name"].InnerText;

                values.Add(value);
            }
            Console.WriteLine(values);
        }
        catch
        {
            throw;
        }*/

        SimpleCodeList simpleCodeList = null;
        string path = @"C:\Users\mtodorova\source\repos\XMLProject\XMLProject\bin\Debug\net6.0\C17000608_genericode.xml";

        XmlRootAttribute xRoot = new XmlRootAttribute();
        xRoot.ElementName = "CodeList";
        xRoot.Namespace = "http://docs.oasis-open.org/codelist/ns/genericode/1.0/";
        xRoot.IsNullable = true;

        XmlSerializer serializer = new XmlSerializer(typeof(SimpleCodeList), xRoot);

        StreamReader reader = new StreamReader(path);
        simpleCodeList = (SimpleCodeList)serializer.Deserialize(reader);
        reader.Close();

        foreach (var rows in simpleCodeList.Rows)
        {
            Console.WriteLine(rows.simpleValueCode);
            Console.WriteLine(rows.simpleValueName);
        }
        Console.WriteLine(simpleCodeList.Rows.Length);
        /*public Dictionary<string, string> GetRulePlanRsa()
        {

            Dictionary<string, string> rulePlanRsa = new Dictionary<string, string>();
            using (TextReader reader = new StreamReader(@"C:\Users\mtodorova\source\repos\XMLProject\XMLProject\bin\Debug\net6.0\C17000608_genericode.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(CodeListParser));
                //return (CodeListParser)serializer.Deserialize(reader);
            }
            return rulePlanRsa;

        }
        //The Deserialize function:

        public Dictionary<string, string> GetLegalForms()
        {

            Dictionary<string, string> rulePlanLegalForms = new Dictionary<string, string>();
            using (TextReader reader = new StreamReader(@"C:\Users\mtodorova\source\repos\XMLProject\XMLProject\bin\Debug\net6.0\C60000022_genericode.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(CodeListParser));
                //return (CodeListParser)serializer.Deserialize(reader);
            }
            return rulePlanLegalForms;
        }*/
    }
}