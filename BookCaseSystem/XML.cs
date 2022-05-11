using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BookCaseSystem
{
    public class XML
    {



        // NY XML fil

        public XML()
        {
            Console.WriteLine("test");
            XmlTextWriter writer = new XmlTextWriter("product.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Table");
            createNode("1", "Product 1", "1000", writer);
            createNode("2", "Product 2", "2000", writer);
            createNode("3", "Product 3", "3000", writer);
            createNode("4", "Product 4", "4000", writer);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }
    }
}
