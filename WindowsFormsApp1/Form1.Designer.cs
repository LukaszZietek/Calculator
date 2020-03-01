namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Wypisywacz = new System.Windows.Forms.TextBox();
            this.WyswietlenieBazy = new System.Windows.Forms.RichTextBox();
            this.AddToLast = new System.Windows.Forms.Button();
            this.LoadBase = new System.Windows.Forms.Button();
            this.Przecinek = new System.Windows.Forms.Button();
            this.Rownosc = new System.Windows.Forms.Button();
            this.Odejmowanie = new System.Windows.Forms.Button();
            this.Dodawanie = new System.Windows.Forms.Button();
            this.Dzielenie = new System.Windows.Forms.Button();
            this.Mnozenie = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.Button10 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Wypisywacz
            // 
            this.Wypisywacz.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Wypisywacz.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Wypisywacz.Cursor = System.Windows.Forms.Cursors.Default;
            this.Wypisywacz.Enabled = false;
            this.Wypisywacz.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wypisywacz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Wypisywacz.Location = new System.Drawing.Point(26, 27);
            this.Wypisywacz.MaximumSize = new System.Drawing.Size(436, 100);
            this.Wypisywacz.MinimumSize = new System.Drawing.Size(418, 100);
            this.Wypisywacz.Name = "Wypisywacz";
            this.Wypisywacz.ReadOnly = true;
            this.Wypisywacz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Wypisywacz.Size = new System.Drawing.Size(418, 100);
            this.Wypisywacz.TabIndex = 19;
            this.Wypisywacz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Wypisywacz.TextChanged += new System.EventHandler(this.Wypisywacz_TextChanged);
            // 
            // WyswietlenieBazy
            // 
            this.WyswietlenieBazy.BackColor = System.Drawing.SystemColors.MenuText;
            this.WyswietlenieBazy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WyswietlenieBazy.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.WyswietlenieBazy.HideSelection = false;
            this.WyswietlenieBazy.Location = new System.Drawing.Point(26, 431);
            this.WyswietlenieBazy.Name = "WyswietlenieBazy";
            this.WyswietlenieBazy.ReadOnly = true;
            this.WyswietlenieBazy.Size = new System.Drawing.Size(418, 25);
            this.WyswietlenieBazy.TabIndex = 41;
            this.WyswietlenieBazy.Text = "";
            this.WyswietlenieBazy.Visible = false;
            // 
            // AddToLast
            // 
            this.AddToLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddToLast.Image = global::WindowsFormsApp1.Properties.Resources.ATL;
            this.AddToLast.Location = new System.Drawing.Point(26, 375);
            this.AddToLast.Name = "AddToLast";
            this.AddToLast.Size = new System.Drawing.Size(100, 50);
            this.AddToLast.TabIndex = 42;
            this.AddToLast.Tag = "1";
            this.AddToLast.UseVisualStyleBackColor = true;
            this.AddToLast.Click += new System.EventHandler(this.AddToLast_Click);
            // 
            // LoadBase
            // 
            this.LoadBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoadBase.Image = global::WindowsFormsApp1.Properties.Resources.Load;
            this.LoadBase.Location = new System.Drawing.Point(26, 151);
            this.LoadBase.Name = "LoadBase";
            this.LoadBase.Size = new System.Drawing.Size(100, 50);
            this.LoadBase.TabIndex = 40;
            this.LoadBase.Tag = "1";
            this.LoadBase.UseVisualStyleBackColor = true;
            this.LoadBase.Click += new System.EventHandler(this.LoadBase_Click);
            // 
            // Przecinek
            // 
            this.Przecinek.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Przecinek.Image = global::WindowsFormsApp1.Properties.Resources.przecinek;
            this.Przecinek.Location = new System.Drawing.Point(238, 375);
            this.Przecinek.Name = "Przecinek";
            this.Przecinek.Size = new System.Drawing.Size(100, 50);
            this.Przecinek.TabIndex = 37;
            this.Przecinek.Tag = "1";
            this.Przecinek.Text = "&,";
            this.Przecinek.UseVisualStyleBackColor = true;
            this.Przecinek.Click += new System.EventHandler(this.Przecinek_Click);
            // 
            // Rownosc
            // 
            this.Rownosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Rownosc.Image = global::WindowsFormsApp1.Properties.Resources.Rowna_sie;
            this.Rownosc.Location = new System.Drawing.Point(344, 375);
            this.Rownosc.Name = "Rownosc";
            this.Rownosc.Size = new System.Drawing.Size(100, 50);
            this.Rownosc.TabIndex = 36;
            this.Rownosc.Tag = "1";
            this.Rownosc.Text = "&=";
            this.Rownosc.UseVisualStyleBackColor = true;
            this.Rownosc.Click += new System.EventHandler(this.Rownosc_Click);
            // 
            // Odejmowanie
            // 
            this.Odejmowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Odejmowanie.Image = global::WindowsFormsApp1.Properties.Resources.Odejmowanie;
            this.Odejmowanie.Location = new System.Drawing.Point(344, 319);
            this.Odejmowanie.Name = "Odejmowanie";
            this.Odejmowanie.Size = new System.Drawing.Size(100, 50);
            this.Odejmowanie.TabIndex = 35;
            this.Odejmowanie.Tag = "1";
            this.Odejmowanie.Text = "&-";
            this.Odejmowanie.UseVisualStyleBackColor = true;
            this.Odejmowanie.Click += new System.EventHandler(this.Odejmowanie_Click);
            // 
            // Dodawanie
            // 
            this.Dodawanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dodawanie.Image = global::WindowsFormsApp1.Properties.Resources.Dodawanie;
            this.Dodawanie.Location = new System.Drawing.Point(344, 263);
            this.Dodawanie.Name = "Dodawanie";
            this.Dodawanie.Size = new System.Drawing.Size(100, 50);
            this.Dodawanie.TabIndex = 34;
            this.Dodawanie.Tag = "1";
            this.Dodawanie.Text = "&+";
            this.Dodawanie.UseVisualStyleBackColor = true;
            this.Dodawanie.Click += new System.EventHandler(this.Dodawanie_Click);
            // 
            // Dzielenie
            // 
            this.Dzielenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dzielenie.Image = global::WindowsFormsApp1.Properties.Resources.Dzielenie;
            this.Dzielenie.Location = new System.Drawing.Point(344, 207);
            this.Dzielenie.Name = "Dzielenie";
            this.Dzielenie.Size = new System.Drawing.Size(100, 50);
            this.Dzielenie.TabIndex = 33;
            this.Dzielenie.Tag = "1";
            this.Dzielenie.Text = "&/";
            this.Dzielenie.UseVisualStyleBackColor = true;
            this.Dzielenie.Click += new System.EventHandler(this.Dzielenie_Click);
            // 
            // Mnozenie
            // 
            this.Mnozenie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Mnozenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Mnozenie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Mnozenie.Image = global::WindowsFormsApp1.Properties.Resources.Mnozenie;
            this.Mnozenie.Location = new System.Drawing.Point(344, 151);
            this.Mnozenie.Name = "Mnozenie";
            this.Mnozenie.Size = new System.Drawing.Size(100, 50);
            this.Mnozenie.TabIndex = 32;
            this.Mnozenie.Tag = "1";
            this.Mnozenie.Text = "&*";
            this.Mnozenie.UseVisualStyleBackColor = true;
            this.Mnozenie.Click += new System.EventHandler(this.Mnozenie_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button12.Image = global::WindowsFormsApp1.Properties.Resources.CE;
            this.button12.Location = new System.Drawing.Point(238, 151);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 50);
            this.button12.TabIndex = 31;
            this.button12.Tag = "1";
            this.button12.Text = "C&E";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Button12_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button11.Image = global::WindowsFormsApp1.Properties.Resources.C;
            this.button11.Location = new System.Drawing.Point(132, 151);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 50);
            this.button11.TabIndex = 30;
            this.button11.Tag = "1";
            this.button11.Text = "&C";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Button11_Click);
            // 
            // Button10
            // 
            this.Button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button10.Image = global::WindowsFormsApp1.Properties.Resources._0;
            this.Button10.Location = new System.Drawing.Point(132, 375);
            this.Button10.Name = "Button10";
            this.Button10.Size = new System.Drawing.Size(100, 50);
            this.Button10.TabIndex = 29;
            this.Button10.Tag = "1";
            this.Button10.Text = "&0";
            this.Button10.UseVisualStyleBackColor = true;
            this.Button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // Button9
            // 
            this.Button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button9.Image = global::WindowsFormsApp1.Properties.Resources._9;
            this.Button9.Location = new System.Drawing.Point(238, 319);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(100, 50);
            this.Button9.TabIndex = 28;
            this.Button9.Tag = "1";
            this.Button9.Text = "&9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // Button8
            // 
            this.Button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button8.Image = global::WindowsFormsApp1.Properties.Resources._8;
            this.Button8.Location = new System.Drawing.Point(132, 319);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(100, 50);
            this.Button8.TabIndex = 27;
            this.Button8.Tag = "1";
            this.Button8.Text = "&8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // Button7
            // 
            this.Button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button7.Image = global::WindowsFormsApp1.Properties.Resources._7;
            this.Button7.Location = new System.Drawing.Point(26, 319);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(100, 50);
            this.Button7.TabIndex = 26;
            this.Button7.Tag = "1";
            this.Button7.Text = "&7";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Button6
            // 
            this.Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button6.Image = global::WindowsFormsApp1.Properties.Resources._6;
            this.Button6.Location = new System.Drawing.Point(238, 263);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(100, 50);
            this.Button6.TabIndex = 25;
            this.Button6.Tag = "1";
            this.Button6.Text = "&6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button5
            // 
            this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button5.Image = global::WindowsFormsApp1.Properties.Resources._5;
            this.Button5.Location = new System.Drawing.Point(132, 263);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(100, 50);
            this.Button5.TabIndex = 24;
            this.Button5.Tag = "1";
            this.Button5.Text = "&5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button4
            // 
            this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button4.Image = global::WindowsFormsApp1.Properties.Resources._4;
            this.Button4.Location = new System.Drawing.Point(26, 263);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(100, 50);
            this.Button4.TabIndex = 23;
            this.Button4.Tag = "1";
            this.Button4.Text = "&4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button3.Image = global::WindowsFormsApp1.Properties.Resources._3;
            this.Button3.Location = new System.Drawing.Point(238, 207);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(100, 50);
            this.Button3.TabIndex = 22;
            this.Button3.Tag = "1";
            this.Button3.Text = "&3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button2.Image = global::WindowsFormsApp1.Properties.Resources._2;
            this.Button2.Location = new System.Drawing.Point(132, 207);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(100, 50);
            this.Button2.TabIndex = 21;
            this.Button2.Tag = "1";
            this.Button2.Text = "&2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button1.Image = global::WindowsFormsApp1.Properties.Resources.Cyfra_1;
            this.Button1.Location = new System.Drawing.Point(26, 207);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(100, 50);
            this.Button1.TabIndex = 20;
            this.Button1.Tag = "1";
            this.Button1.Text = "&1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(468, 467);
            this.Controls.Add(this.AddToLast);
            this.Controls.Add(this.WyswietlenieBazy);
            this.Controls.Add(this.LoadBase);
            this.Controls.Add(this.Przecinek);
            this.Controls.Add(this.Rownosc);
            this.Controls.Add(this.Odejmowanie);
            this.Controls.Add(this.Dodawanie);
            this.Controls.Add(this.Dzielenie);
            this.Controls.Add(this.Mnozenie);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.Button10);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Wypisywacz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Wypisywacz;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button Button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button Mnozenie;
        private System.Windows.Forms.Button Dzielenie;
        private System.Windows.Forms.Button Dodawanie;
        private System.Windows.Forms.Button Odejmowanie;
        private System.Windows.Forms.Button Rownosc;
        private System.Windows.Forms.Button Przecinek;
        private System.Windows.Forms.Button LoadBase;
        private System.Windows.Forms.RichTextBox WyswietlenieBazy;
        private System.Windows.Forms.Button AddToLast;
    }
}

