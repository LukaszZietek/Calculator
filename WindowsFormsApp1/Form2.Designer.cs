namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.PokazSciezke = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz miejsce i sposób zapisu danych.";
            // 
            // PokazSciezke
            // 
            this.PokazSciezke.BackColor = System.Drawing.SystemColors.MenuText;
            this.PokazSciezke.ForeColor = System.Drawing.SystemColors.Menu;
            this.PokazSciezke.Location = new System.Drawing.Point(46, 94);
            this.PokazSciezke.Name = "PokazSciezke";
            this.PokazSciezke.Size = new System.Drawing.Size(457, 22);
            this.PokazSciezke.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Image = global::WindowsFormsApp1.Properties.Resources.TrzyKropki;
            this.button2.Location = new System.Drawing.Point(428, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OK
            // 
            this.OK.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.OK;
            this.OK.Location = new System.Drawing.Point(208, 139);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(100, 50);
            this.OK.TabIndex = 1;
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(520, 202);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PokazSciezke);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OK);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Wybór Ścieżki";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PokazSciezke;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button2;
    }
}