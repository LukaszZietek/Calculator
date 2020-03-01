using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class COperation
    {
        private string mMathOperation;
        private string mMathScore;

        public COperation(string aOperation = null,string aScore = null)
        {
            this.mMathOperation = aOperation;
            this.mMathScore = aScore;
            
        }
        ~COperation()
        {
            mMathOperation = null;
            mMathScore = null;
        }

       
        public string Operation
        {
            get
            {
                return mMathOperation;
            }
            set
            {
                mMathOperation = value;
            }
        }
        public string Score
        {
            get
            {
                return mMathScore;
            }
            set
            {
                mMathScore = value;
            }
        }

        public static COperation operator+(COperation aObj1, COperation aObj2) // Przeciazony operator dodawania
        {
            double aFigure1 = 0;
            string aEndString = "";
            double aFigure2 = 0;
            
            if (aObj1.Score!=null)
            {
               aFigure1 = Double.Parse(aObj1.Score);
            }
            if (aObj2.Score != null)
            {
                aFigure2 = Double.Parse(aObj2.Score);
            }
            if (aObj1.Operation != null)
            {
                aEndString = aObj1.mMathOperation + "+" + aObj2.mMathOperation;
            }else
            {
                aEndString = aObj2.mMathOperation;
            }

            return new COperation(aEndString, (aFigure1 + aFigure2).ToString());
        }
    }
}
