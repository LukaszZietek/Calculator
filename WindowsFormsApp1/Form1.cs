using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    
    public partial class Form1 : Form
    {
        private bool mLoadTrueorFalse;
        private CSaveandLoad mBase;
        public Form1()
        {
            InitializeComponent();
            mBase = new CBase();
            mLoadTrueorFalse = false;
            mBase.SaveinFile();
        }
        public Form1(string aPath, int aChoose)
        {
            InitializeComponent();
            if(aChoose == 1)
            {
                mBase = new CBaseXML(aPath);
            }
            if(aChoose == 2)
            {
                mBase = new CBase(aPath);
            }
            mLoadTrueorFalse = false;
            mBase.SaveinFile();

        }



        
        
        



        public decimal ScoreofMathOperation(ref decimal aFigure1, ref decimal aFigure2,char aMark)
        {
            if(aMark=='+')
            {
                return aFigure1 + aFigure2;

            }
            if(aMark=='-')
            {
                return aFigure1 - aFigure2;

            }
            if(aMark=='*')
            {
                return aFigure1 * aFigure2;

            }
            if (aMark == '÷')
            {
                if (aFigure2 != 0)
                {
                    return aFigure1 / aFigure2;
                }
                else
                {
                    Wypisywacz.Text = "Blad dzielenia x503/0";
                }
            }
            return 0;
        }

        public void FinderofFigure(int aWhereLeft, int aWhereRight, ref string aEquals, ref int aLoop) // Wykonuje dzialania i zwraca ciag znakow 
        {
            
            string aChanged;
            string aFigureinLeft;
            string aFigureinRight;
            Decimal aScoreofMathOperation;
            while (aWhereLeft >= 0 && aEquals[aWhereLeft] != '*' && aEquals[aWhereLeft] != '-' && aEquals[aWhereLeft] != '+' && aEquals[aWhereLeft] != '÷')
            {
                aWhereLeft--;
            }

            while (aWhereRight + 1 < aEquals.Length && aEquals[aWhereRight + 1] != '*' && aEquals[aWhereRight + 1] != '-' && aEquals[aWhereRight + 1] != '+' && aEquals[aWhereRight + 1] != '÷')
            {
                aWhereRight++;

            }
            aFigureinLeft = aEquals.Substring(aWhereLeft + 1, aLoop - aWhereLeft - 1);
            aFigureinRight = aEquals.Substring(aLoop + 1, aWhereRight - aLoop);
            Decimal aFigureFirst = Decimal.Parse(aFigureinLeft);
            Decimal aFigureSecond = Decimal.Parse(aFigureinRight);
            aScoreofMathOperation = ScoreofMathOperation(ref aFigureFirst,ref aFigureSecond, aEquals[aLoop]);
            aChanged = aEquals.Replace(aFigureinLeft + aEquals[aLoop] + aFigureinRight, aScoreofMathOperation.ToString());
            aEquals = aChanged;
            aLoop = 0;

        }

        public void FunctionofEqual(ref string aEquals) // Funkcja ta wyszukuje znak w rownaniu i przesyla oryginalnego stringa z rownaniem do funkcji ktora wykonuje dzialania
        {
            
            
            

            for(int j = 0; j<aEquals.Length;j++) // Wyszukuje znakow mnozenia i dzielenia(jako priorytet)
            {
                if(aEquals[j]== '*' || aEquals[j]== '÷')
                {
                    FinderofFigure(j - 1, j + 1,ref aEquals,ref j);
                }

            }
            
            for(int j = 0;j<aEquals.Length;j++) // Wyszukuje pozostale znaki czyli "+" i "-"
            {
                if(aEquals[j]=='+' || aEquals[j]=='-')
                {
                    FinderofFigure(j - 1, j + 1, ref aEquals, ref j);
                }

            }

        }

        public bool CheckingChar(char aMark)
        {
            // ---------------- Sprawdzanie czy nie ma dwoch znakow "+" , "-" , "*", "÷" obok siebie
            string aText = Wypisywacz.Text;
            if (aText.Length != 0)
            {
                if (aText[aText.Length - 1] != '+' && aText[aText.Length - 1] != '-' && aText[aText.Length - 1] != '*' && aText[aText.Length - 1] != '÷' && aText[aText.Length - 1] != ',')
                {
                    return true;


                }
                else
                {
                    if (aText[aText.Length - 1] != aMark)
                    {
                        Wypisywacz.Text = aText.Remove(aText.Length - 1);
                        return true;

                    }
                    return false;

                }


            }


            return false;

        }

        public void InteractionofFigureButton(int aFigure) // Dzialanie przyciskow cyfr typu 1,2,3,4
        {
            // Wpisanie wartości do okienka tekstowego.
            if (Wypisywacz.Text == "")
            {
                Wypisywacz.Text = aFigure.ToString();
            }
            else
            {
                string aText = Wypisywacz.Text;
                aText = aText + aFigure.ToString();
                Wypisywacz.Text = aText;
               
            }


        }

        public void InteractionofCharButton(char aMark) // Dzialanie przyciskow znakowych typu +,-
        {
            if (Wypisywacz.Text != "" && CheckingChar(aMark) == true)
            {
                string aText = Wypisywacz.Text;
                aText = aText + aMark.ToString();
                Wypisywacz.Text = aText;
            }
            


        }

        

       






        private void Button1_Click(object sender, EventArgs e)
        {
            int aFigure = 1;
            InteractionofFigureButton(aFigure);
        }

        private void Wypisywacz_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int aFigure = 2;
            InteractionofFigureButton(aFigure);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            InteractionofFigureButton(3);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            InteractionofFigureButton(4);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            InteractionofFigureButton(5);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            InteractionofFigureButton(6);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            InteractionofFigureButton(7);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            InteractionofFigureButton(8);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            InteractionofFigureButton(9);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            InteractionofFigureButton(0);
        }

        private void Mnozenie_Click(object sender, EventArgs e)
        {
            InteractionofCharButton('*');
        }

        private void Dodawanie_Click(object sender, EventArgs e)
        {
            InteractionofCharButton('+');
        }

        private void Odejmowanie_Click(object sender, EventArgs e)
        {
            InteractionofCharButton('-');
        }

        private void Rownosc_Click(object sender, EventArgs e)
        {
            if (Wypisywacz.Text != null && Wypisywacz.Text != "")
            {
                COperation aAddtoBase = new COperation(Wypisywacz.Text);
                string aName = Wypisywacz.Text;
                FunctionofEqual(ref aName);
                Wypisywacz.Text = aName;
                aAddtoBase.Score = aName;
                mBase.AddintoBase(aAddtoBase);
                
            }
            
        }

        private void Dzielenie_Click(object sender, EventArgs e)
        {
            InteractionofCharButton('÷');
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            Wypisywacz.Text = "";
        }

        private void Button12_Click(object sender, EventArgs e)
        {

            if (Wypisywacz.Text != "")
            {
                string aText = Wypisywacz.Text;
                Wypisywacz.Text = aText.Remove(aText.Length - 1);
            }
            

        }

        private void Przecinek_Click(object sender, EventArgs e)
        {
            InteractionofCharButton(',');
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        

        private void LoadBase_Click(object sender, EventArgs e)
        {
            int aException = 0;
            if (mLoadTrueorFalse == false)
            {
                aException = mBase.LoadFromFile();
                if (aException != -1)
                {
                    mLoadTrueorFalse = true;
                }else
                {
                    Wypisywacz.Text = "Plik o podanym adresie nie zostal jeszcze utworzony!";
                }
            }
            WyswietlenieBazy.Visible = true;
            WyswietlenieBazy.Text = mBase.ShowaBase();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            mBase.SaveinFile();
            
            MessageBox.Show("Baza danych została zapisana", "Kalkulator");

        }

        private void AddToLast_Click(object sender, EventArgs e)
        {
           if(Wypisywacz.Text !=null && Wypisywacz.Text !="")
            {
                COperation aAddtoBase = new COperation(Wypisywacz.Text);
                string aName = Wypisywacz.Text;
                FunctionofEqual(ref aName);
                aAddtoBase.Score = aName;
                COperation aWasinBase = new COperation(mBase.SendMathOperation(), mBase.SendScore());
                aWasinBase = aWasinBase + aAddtoBase;
                mBase.AddintoBase(aWasinBase);
                Wypisywacz.Text = aWasinBase.Score;
                if(WyswietlenieBazy.Visible == true)
                {
                    WyswietlenieBazy.Text = mBase.ShowaBase();
                }
                

            }
        }


    }
}
