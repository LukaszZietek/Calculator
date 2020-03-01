using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace WindowsFormsApp1
{
    class CBase: CSaveandLoad
    {
        
        public CBase()
        {
           mPath = @"C:\Users\Lukasz\Desktop\Projekt_Visual\Projekt_PO\Operacje.txt";
            

        }
        public CBase(string aPath)
        {
            mPath = @"" + aPath;
           

        }
        ~CBase()
        {
            mPath = null;
            mOperationList.Clear();
        }

        
        
      
        public override void SaveinFile() // Funkcja zapisujaca do pliku .txt
        {
            
                StreamWriter aFileReady = new StreamWriter(mPath);
                
                    for(int i = 0; i < mOperationList.Count; i++)
                    {
                aFileReady.WriteLine(mOperationList[i].Operation);
                aFileReady.WriteLine(mOperationList[i].Score);
                    }
                aFileReady.Close();
                
           
            
        }
        public override int LoadFromFile() // Funkcja odczytujaca z pliku txt
        {
            string aOperation;
            string aScore;
            int aTabLoad = mOperationList.Count();
            try
            {
                using (StreamReader aOnlyRead = new StreamReader(mPath))
                {
                    do
                    {
                        aOperation = aOnlyRead.ReadLine();
                        aScore = aOnlyRead.ReadLine();
                        if (aOperation != null && aScore != null && aTabLoad != 3)
                        {
                            COperation aAddToBase = new COperation(aOperation, aScore);
                            mOperationList.Add(aAddToBase);
                            aTabLoad++;

                        }
                    } while ((aOperation != null || aScore != null) && aTabLoad != 3);

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
