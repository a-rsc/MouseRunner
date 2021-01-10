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

        private volatile XmlDocument xmlDoc;
        private XmlNode mouseNode, teclatNode;

        private Dictionary<string, string> num = new Dictionary<string, string>()
        {
            ["metres"]="0",
            ["a"]="0",
            ["e"]="0",
            ["i"]="0",
            ["o"]="0",
            ["u"]="0",
        };

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
                        Num["metres"]=xnode.ChildNodes[0].InnerText;
                    }
                    else if(xnode.Name=="teclat")
                    {
                        teclatNode=xnode;
                        Num["a"]=xnode.ChildNodes[0].InnerText;
                        Num["e"]=xnode.ChildNodes[1].InnerText;
                        Num["i"]=xnode.ChildNodes[2].InnerText;
                        Num["o"]=xnode.ChildNodes[3].InnerText;
                        Num["u"]=xnode.ChildNodes[4].InnerText;
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
            mouseNode.ChildNodes[0].InnerText=Num["metres"];
            teclatNode.ChildNodes[0].InnerText=Num["a"];
            teclatNode.ChildNodes[1].InnerText=Num["e"];
            teclatNode.ChildNodes[2].InnerText=Num["i"];
            teclatNode.ChildNodes[3].InnerText=Num["o"];
            teclatNode.ChildNodes[4].InnerText=Num["u"];

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

        private string FileName => fileName;

        public Dictionary<string, string> Num { get => num; set => num=value; }
    }
}
