using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DemoDesignPatterns.Configuration
{
    public class ConfigReaderWorker
    {
        public void StartReadConfigfile(string filePath)
        {
            XmlDocument cfg = new XmlDocument();
            cfg.Load(filePath);

            XmlNode? portNode = cfg.DocumentElement.SelectSingleNode("Port");
            if (portNode != null)
            {
                int port = int.Parse(portNode.InnerText.Trim());
                Console.WriteLine("Indlæst port = " + port);
            }

            XmlNode? nameNode = cfg.DocumentElement.SelectSingleNode("Name");
            if (nameNode != null)
            {
                string name  = nameNode.InnerText.Trim();
                Console.WriteLine("Indlæst navn = " + name);
            }

        }
    }
}
