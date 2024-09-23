using System;
using System.Text.Json;
using System.Xml;
using System.Xml.Linq;

namespace DocFileXML
{
    public class ReadAndWrite
    {
        public void ReadFromFile()
        {
            XmlTextReader reader = new XmlTextReader("books.xml");
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        Console.Write("<" + reader.Name);
                        Console.WriteLine(">");
                        break;
                    case XmlNodeType.Text:
                        Console.WriteLine(reader.Value);
                        break;
                    case XmlNodeType.EndElement:
                        Console.Write("</" + reader.Name);
                        Console.WriteLine(">");
                        break;
                }
            }
        }
        public bool WriteToFile()
        {
            Book book = new Book();
            book.title = "Đắc Nhân Tâm";
            book.price = 123.5f;
            try
            {
                XDocument xDoc = XDocument.Load("books.xml");
                XElement newBook = new XElement("book",
                new XElement("title", book.title),
                new XElement("price", book.price.ToString()));

                xDoc.Element("bookstore").Add(newBook);
                xDoc.Save("books.xml");
                return true;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
                return false;
            }
        }
        
    }
}