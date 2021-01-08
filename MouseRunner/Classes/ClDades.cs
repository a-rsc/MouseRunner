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
    public sealed class ClDades
    {
        private readonly string fileName = "Dades.xml";
        private readonly string path;

        private readonly XmlDocument xmlDoc;
        private XmlNode mouseNode, teclatNode;

        private string metres = "0"; // valors per defecte - 0
        private string numA = "0", numE = "0", numI = "0", numO = "0", numU = "0"; // valors per defecte - 0

        public ClDades()
        {
            xmlDoc=new XmlDocument();
            path=Path.Combine(Application.StartupPath, string.Concat(@"..\..\Resources\", FileName));

            try
            {
                xmlDoc.Load(path);

                foreach(XmlNode xnode in xmlDoc.DocumentElement.ChildNodes)
                {
                    if(xnode.Name=="mouse")
                    {
                        mouseNode=xnode;
                        metres=xnode.ChildNodes[0].InnerText;
                    }
                    else if(xnode.Name=="teclat")
                    {
                        teclatNode=xnode;
                        numA=xnode.ChildNodes[0].InnerText;
                        numE=xnode.ChildNodes[1].InnerText;
                        numI=xnode.ChildNodes[2].InnerText;
                        numO=xnode.ChildNodes[3].InnerText;
                        numU=xnode.ChildNodes[4].InnerText;
                    }
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
            mouseNode.ChildNodes[0].InnerText=metres;
            teclatNode.ChildNodes[0].InnerText=numA;
            teclatNode.ChildNodes[1].InnerText=numE;
            teclatNode.ChildNodes[2].InnerText=numI;
            teclatNode.ChildNodes[3].InnerText=numO;
            teclatNode.ChildNodes[4].InnerText=numU;

            xmlDoc.Save(path);
        }

        private void nouXML()
        {
            // TODO: Si l'arxiu no es trobés el crearia

            /*
            <?xml version="1.0" encoding="utf-8"?>
            <dades>
              <mouse>
                <metres>36,25</metres>
              </mouse>
              <teclat>
                <A>8</A>
                <E>7</E>
                <I>13</I>
                <O>23</O>
                <U>22</U>
              </teclat>
            </dades>
            */
        }

        public string FileName => fileName;
        public string Metres { get => metres; set => metres=value; }
        public string NumA { get => numA; set => numA=value; }
        public string NumE { get => numE; set => numE=value; }
        public string NumI { get => numI; set => numI=value; }
        public string NumO { get => numO; set => numO=value; }
        public string NumU { get => numU; set => numU=value; }
    }
}
