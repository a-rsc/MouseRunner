using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MouseRunner.Classes
{
    // Only one instance
    public sealed class ClConfiguracio
    {
        private readonly string path = Path.Combine(Application.StartupPath, @"..\..\Resources\Configuracio.xml");
        
        private readonly XmlDocument xmlDoc;
        private XmlNode ampladaNode, alturaNode;

        private string amplada = "50"; // valors per defecte - meva pantalla
        private string altura = "30"; // valors per defecte - meva pantalla

        public ClConfiguracio()
        {
            xmlDoc = new XmlDocument();

            try
            {
                xmlDoc.Load(path);

                ampladaNode = xmlDoc.SelectSingleNode("configuracio/amplada");
                if(ampladaNode!=null)
                {
                    amplada=ampladaNode.InnerText;
                }

                alturaNode = xmlDoc.SelectSingleNode("configuracio/altura");
                if(alturaNode!=null)
                {
                    altura=alturaNode.InnerText;
                }
            }
            catch
            {
            }
        }

        public void Save()
        {
            ampladaNode.InnerText=amplada;
            alturaNode.InnerText=altura;

            xmlDoc.Save(path);
        }

        public string Amplada { get => amplada; set => amplada=value; }
        public string Altura { get => altura; set => altura=value; }
    }
}
