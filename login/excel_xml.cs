using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Walkin_Report.login
{
    public class excel_xml
    {
        public string get_xml_tag(string tagName)
        {
            string path = "dbconfig.xml";

            if (!File.Exists(path))
                return null;

            XDocument doc = XDocument.Load(path);

            XElement element = doc.Descendants(tagName).FirstOrDefault();

            if (element == null)
                return null;

            return element.Value;
        }

        public void set_xml_tag(string tagName, string value)
        {
            string path = "dbconfig.xml";

            XDocument doc;

            if (File.Exists(path))
                doc = XDocument.Load(path);
            else
                doc = new XDocument(new XElement("config"));

            XElement element = doc.Descendants(tagName).FirstOrDefault();

            if (element == null)
            {
                doc.Root.Add(new XElement(tagName, value));
            }
            else
            {
                element.Value = value;
            }

            doc.Save(path);
        }
    }
}
