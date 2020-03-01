using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class CSaveandLoad
    {
        protected string mPath;
        protected List<COperation> mOperationList;
        

        public CSaveandLoad()
        {
            mPath = "Operation.txt";
            mOperationList = new List<COperation>();
            
        }

        public void AddintoBase(COperation aRownanie) // Funkcja dodajaca element do listy
        {
            
            if (mOperationList.Count >= 3)
            {
                mOperationList.Insert(0, aRownanie);
                mOperationList.RemoveAt(3);
            }
            else
            {
                mOperationList.Insert(0,aRownanie);
            }
        }

        

        public string SendScore()
        {
            if (mOperationList.Count() != 0)
            {
                string aMathematicalScore = mOperationList[0].Score;
                mOperationList.RemoveAt(0);
                return aMathematicalScore;
            }
            else
            {
                return null;
            }

        }

        public string SendMathOperation()
        {
            if (mOperationList.Count != 0)
            {
                return mOperationList[0].Operation;
            }else
            {
                return null;
            }
            
        }
        public virtual void SaveinFile()
        {
            using (StreamWriter aSaving = new StreamWriter(mPath))
            {
                aSaving.WriteLine("1+1+1+1+1");
                aSaving.WriteLine(5);
            }

        }
        public virtual int LoadFromFile()
        {
                COperation aAddtoBase = new COperation("1","1");
                mOperationList.Add(aAddtoBase);
            return 1;
            
        }
       

        public string ShowaBase()
        {
            string aTobeReturn = "";
            for (int i = 0; i < mOperationList.Count() && mOperationList[i].Operation != null; i++)
            {

                aTobeReturn += i + 1 + ": " + mOperationList[i].Operation + " = " + mOperationList[i].Score + "\n";
            }
            return aTobeReturn;

        }

        

    }
    

}
