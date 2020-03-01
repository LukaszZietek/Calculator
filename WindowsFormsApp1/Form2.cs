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
    public partial class Form2 : Form
    {
        private string mFileName;
        Form1 mNewForm;
        public Form2()
        {
            InitializeComponent();
            mFileName = null;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            
            if (mFileName != null)
            {
                if (mFileName[mFileName.Length - 1] == 'L' || mFileName[mFileName.Length - 1] == 'l')
                {
                    mNewForm = new Form1(mFileName, 1);
                }
                else
                {
                    mNewForm = new Form1(mFileName, 2);
                }

            }
            else
            {

               mNewForm = new Form1();
            }
            this.Hide();
            mNewForm.ShowDialog();
            this.Close();
        }

        

       

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog aSaveDialog = new SaveFileDialog();
            aSaveDialog.Filter = "txt files (*.txt)|*.txt|XML Files (*.XML)|*.XML";
            aSaveDialog.FilterIndex = 2;
            aSaveDialog.InitialDirectory = @"C:\Users\Lukasz\Desktop\Projekt_Visual\Projekt_PO";
            aSaveDialog.ShowDialog();
            mFileName = aSaveDialog.FileName;
            PokazSciezke.Text = mFileName;

            
            
        }
    }
}
