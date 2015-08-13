using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace MagicConstResearcher
{
    class MethodPropertyDataHandler
    {
        public Dictionary<string,PropertySet> PropertySetList;
        private string filename;
        public MethodPropertyDataHandler(string file)
        {
            try
            {
                filename = file;
                PropertySetList = new Dictionary<string, PropertySet>();
                XElement root = XElement.Load(filename);
                foreach (XElement properySet in root.Elements("PropertySet"))
                {
                    string name = properySet.Attribute("Name").Value;
                    string pr1 = properySet.Element("Property1").Value;
                    string pr2 = properySet.Element("Property2").Value;
                    string pr3 = properySet.Element("Property3").Value;
                    string method = properySet.Element("Method").Value;
                    PropertySetList.Add(name, new PropertySet(pr1, pr2, pr3, method));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void AddPropertySet(string name, string property1, string property2, string property3, string method)
        {
            PropertySetList.Add(name, new PropertySet(property1, property2, property3, method));
            XElement root = XElement.Load(filename);
            root.Add(new XElement("PropertySet",
                    new XElement("Property1",property1),
                    new XElement("Property2",property2),
                    new XElement("Property3",property3),
                    new XElement("Method", method),
                    new XAttribute("Name",name)));
            root.Save(filename);
        }

        public void DeletePropertySet(string name)
        {
            XElement root = XElement.Load(filename);
            IEnumerable<XElement> tests =
                from element in root.Elements("PropertySet")
                where element.Attribute("Name").Value == name
                select element;
            foreach (XElement test in tests)
            {
                test.Remove();
            }
            root.Save(filename);
            PropertySetList.Remove(name);
        }
    }

    class PropertySet
    {
        public string Property1;
        public string Property2;
        public string Property3;
        public string MethodName;

        public PropertySet(string property1, string property2, string property3, string method)
        {
            Property1 = property1;
            Property2 = property2;
            Property3 = property3;
            MethodName = method;
        }
    }
}
