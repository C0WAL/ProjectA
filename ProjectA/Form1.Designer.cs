namespace ProjectA
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
         private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.Observer = new System.Windows.Forms.Timer(this.components);
            this.Gracz = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Zycie1 = new System.Windows.Forms.PictureBox();
            this.Zycie2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Gracz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zycie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zycie2)).BeginInit();
            this.SuspendLayout();
            // 
            // Gracz
            // 
            this.Gracz.Location = new System.Drawing.Point(291, 326);
            this.Gracz.Name = "Gracz";
            this.Gracz.Size = new System.Drawing.Size(40, 37);
            this.Gracz.TabIndex = 0;
            this.Gracz.TabStop = false;
            this.Gracz.Click += new System.EventHandler(this.Gracz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // pictureBox1
            // 
            this.Zycie1.Location = new System.Drawing.Point(106, 355);
            this.Zycie1.Name = "pictureBox1";
            this.Zycie1.Size = new System.Drawing.Size(53, 44);
            this.Zycie1.TabIndex = 3;
            this.Zycie1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.Zycie2.Location = new System.Drawing.Point(171, 354);
            this.Zycie2.Name = "pictureBox2";
            this.Zycie2.Size = new System.Drawing.Size(55, 44);
            this.Zycie2.TabIndex = 4;
            this.Zycie2.TabStop = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(637, 415);
            this.Controls.Add(this.Zycie2);
            this.Controls.Add(this.Zycie1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gracz);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Gracz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zycie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zycie2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Gracz_Click(object sender, EventArgs e)
        {

        }

    }

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer Observer;
        private System.Windows.Forms.PictureBox Gracz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Zycie1;
        private System.Windows.Forms.PictureBox Zycie2;
    }
    
}