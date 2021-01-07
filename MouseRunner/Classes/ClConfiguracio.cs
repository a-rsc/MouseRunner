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
        private readonly string fileName = "Configuracio.xml";
        private readonly string path;
        
        private readonly XmlDocument xmlDoc;
        private XmlNode ampladaNode, alturaNode;

        private Dictionary<string, string> caracteristiques = new Dictionary<string, string>()
        {
            ["amplada"] = "50", // valors per defecte - meva pantalla
            ["altura"] = "30"   // valors per defecte - meva pantalla
        };

        public ClConfiguracio()
        {
            xmlDoc = new XmlDocument();
            path=Path.Combine(Application.StartupPath, string.Concat(@"..\..\Resources\", FileName));

            try
            {
                xmlDoc.Load(path);

                ampladaNode = xmlDoc.SelectSingleNode("configuracio/pantalla/amplada");
                if(ampladaNode!=null)
                {
                    Caracteristiques["amplada"]=ampladaNode.InnerText;
                }

                alturaNode = xmlDoc.SelectSingleNode("configuracio/pantalla/altura");
                if(alturaNode!=null)
                {
                    Caracteristiques["altura"]=alturaNode.InnerText;
                }
            }
            catch(Exception)
            {
                // Si l'arxiu no es trobés el crearia
                nouXML();
            }
        }

        public void Save()
        {
            ampladaNode.InnerText=Caracteristiques["amplada"];
            alturaNode.InnerText=Caracteristiques["altura"];

            xmlDoc.Save(path);
        }

        private void nouXML()
        {
            // Utilitzem objectes de System.XML
            // XmlDocument xmlDoc = new XmlDocument();

            XmlNode xNodeArrel, xNodePantalla;
            XmlElement xElement;
            XmlDeclaration xDeclaracio;
            XmlComment xComentari;

            // Inserció declaració sobre l'estàndard XML i la codificació, el "yes" indica que aquest XML no depèn d'una font externa (un arxiu d'schema DTD, XSD)
            xDeclaracio=xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "yes");
            xmlDoc.InsertBefore(xDeclaracio, xmlDoc.DocumentElement);

            // Afegim un comentari
            xComentari=xmlDoc.CreateComment("Característiques pantalla projectada: amplada i altura (cm)");
            xmlDoc.InsertAfter(xComentari, xDeclaracio);

            xNodeArrel=xmlDoc.CreateElement("configuracio");
            xmlDoc.AppendChild(xNodeArrel);

            xNodePantalla=xmlDoc.CreateElement("pantalla");
            xNodeArrel.AppendChild(xNodePantalla);

            foreach(var item in Caracteristiques)
            {
                xElement=xmlDoc.CreateElement(item.Key);
                xElement.InnerText=item.Value;
                xNodePantalla.AppendChild(xElement);
            }

            xmlDoc.Save(path);
        }

        public Dictionary<string, string> Caracteristiques { get => caracteristiques; set => caracteristiques=value; }
        public string FileName => fileName;
    }
}
