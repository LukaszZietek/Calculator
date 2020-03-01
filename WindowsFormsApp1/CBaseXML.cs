using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;


namespace WindowsFormsApp1
{
    class CBaseXML: CSaveandLoad
    {
        private List<COperation> mExtraList;

        public CBaseXML() // Konstruktor bezargumentowy CBaseXML
        {
            mPath = @"C:\Users\Lukasz\Desktop\Projekt_Visual\Projekt_PO\Operation.XML";
            mExtraList = new List<COperation>();
           

        }
        public CBaseXML(string aPath)
        {
            mPath = @"" + aPath;
            mExtraList = new List<COperation>();
            
        }
        ~CBaseXML()
        {
            mPath = null;
            mOperationList.Clear();
            mExtraList.Clear();
        }
        

        

        public override void SaveinFile() // Funkcja zapisujaca do pliku XML
        {
            XDocument aXMLBase = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("This is last operation"),
                new XElement("Dzialanie",
                            from COperation in mOperationList
                            select new XElement("Dzialanie",
                                   new XElement("Rownanie", COperation.Operation),
                                   new XElement("Wynik", COperation.Score)
                                   )
                             )
                          );
            aXMLBase.Save(mPath);
            
            



        }

        public override int LoadFromFile() // Funkcja odczytujaca z pliku xml i wrzucająca składniki do listy
        {

            int i = 0;
            int aListSize = mOperationList.Count();

            try
            {
                XDocument aXMLBase = XDocument.Load(mPath);
                mExtraList = (from COperation in aXMLBase.Root.Elements("Dzialanie")
                             select new COperation(
                            COperation.Element("Rownanie").Value,
                            COperation.Element("Wynik").Value
                                )
                                ).ToList<COperation>();
                while (i < mExtraList.Count() && mExtraList[i] != null && aListSize != 3)
                {
                    mOperationList.Add(mExtraList[i]);
                    i++;
                    aListSize++;
                }
            }
            catch(FileNotFoundException)
            {
                return -1;
            }
            
            return 1;
        }
    }
}
