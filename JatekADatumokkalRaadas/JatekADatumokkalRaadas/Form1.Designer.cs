namespace JatekADatumokkalRaadas
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtTmPckrDatum = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblErtekeles = new System.Windows.Forms.Label();
            this.btnErtekel = new System.Windows.Forms.Button();
            this.btnTorol = new System.Windows.Forms.Button();
            this.btnBezar = new System.Windows.Forms.Button();
            this.lblTalalkozo = new System.Windows.Forms.Label();
            this.lblAktualis = new System.Windows.Forms.Label();
            this.dtTmPckrIdo = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A találkozás ideje:";
            // 
            // dtTmPckrDatum
            // 
            this.dtTmPckrDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTmPckrDatum.Location = new System.Drawing.Point(45, 53);
            this.dtTmPckrDatum.Name = "dtTmPckrDatum";
            this.dtTmPckrDatum.Size = new System.Drawing.Size(122, 20);
            this.dtTmPckrDatum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "A találkozás ideje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Aktuális idő:";
            // 
            // lblErtekeles
            // 
            this.lblErtekeles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblErtekeles.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErtekeles.Location = new System.Drawing.Point(25, 192);
            this.lblErtekeles.Name = "lblErtekeles";
            this.lblErtekeles.Size = new System.Drawing.Size(304, 31);
            this.lblErtekeles.TabIndex = 5;
            this.lblErtekeles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnErtekel
            // 
            this.btnErtekel.Location = new System.Drawing.Point(45, 260);
            this.btnErtekel.Name = "btnErtekel";
            this.btnErtekel.Size = new System.Drawing.Size(75, 23);
            this.btnErtekel.TabIndex = 6;
            this.btnErtekel.Text = "Értékel";
            this.btnErtekel.UseVisualStyleBackColor = true;
            this.btnErtekel.Click += new System.EventHandler(this.btnErtekel_Click);
            // 
            // btnTorol
            // 
            this.btnTorol.Location = new System.Drawing.Point(254, 260);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(75, 23);
            this.btnTorol.TabIndex = 7;
            this.btnTorol.Text = "Töröl";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // btnBezar
            // 
            this.btnBezar.Location = new System.Drawing.Point(149, 310);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(75, 23);
            this.btnBezar.TabIndex = 8;
            this.btnBezar.Text = "Bezár";
            this.btnBezar.UseVisualStyleBackColor = true;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // lblTalalkozo
            // 
            this.lblTalalkozo.AutoSize = true;
            this.lblTalalkozo.Location = new System.Drawing.Point(132, 107);
            this.lblTalalkozo.Name = "lblTalalkozo";
            this.lblTalalkozo.Size = new System.Drawing.Size(0, 13);
            this.lblTalalkozo.TabIndex = 9;
            // 
            // lblAktualis
            // 
            this.lblAktualis.AutoSize = true;
            this.lblAktualis.Location = new System.Drawing.Point(132, 140);
            this.lblAktualis.Name = "lblAktualis";
            this.lblAktualis.Size = new System.Drawing.Size(0, 13);
            this.lblAktualis.TabIndex = 10;
            // 
            // dtTmPckrIdo
            // 
            this.dtTmPckrIdo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTmPckrIdo.Location = new System.Drawing.Point(216, 53);
            this.dtTmPckrIdo.Name = "dtTmPckrIdo";
            this.dtTmPckrIdo.ShowUpDown = true;
            this.dtTmPckrIdo.Size = new System.Drawing.Size(113, 20);
            this.dtTmPckrIdo.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.dtTmPckrIdo);
            this.Controls.Add(this.lblAktualis);
            this.Controls.Add(this.lblTalalkozo);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.btnErtekel);
            this.Controls.Add(this.lblErtekeles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtTmPckrDatum);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Találkozás";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTmPckrDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblErtekeles;
        private System.Windows.Forms.Button btnErtekel;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.Button btnBezar;
        private System.Windows.Forms.Label lblTalalkozo;
        private System.Windows.Forms.Label lblAktualis;
        private System.Windows.Forms.DateTimePicker dtTmPckrIdo;
    }
}

