namespace JatekADatumokkal
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
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnKiir = new System.Windows.Forms.Button();
            this.btnTorol = new System.Windows.Forms.Button();
            this.btnBezar = new System.Windows.Forms.Button();
            this.lblDatum = new System.Windows.Forms.Label();
            this.txtEvSzam = new System.Windows.Forms.TextBox();
            this.txtNap = new System.Windows.Forms.TextBox();
            this.txtNapSzam = new System.Windows.Forms.TextBox();
            this.txtNapSorszam = new System.Windows.Forms.TextBox();
            this.txtKesobbiDatum = new System.Windows.Forms.TextBox();
            this.lblGratulacio = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mskdTxtSzulDatum = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(42, 289);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pontos dátum és idő:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Születési dátum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ennyi éves vagy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ilyen napon születtél:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tetszőleges dátum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ez az év ennyiedik napja:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "nappal későbbi dátum:";
            // 
            // btnKiir
            // 
            this.btnKiir.Location = new System.Drawing.Point(88, 356);
            this.btnKiir.Name = "btnKiir";
            this.btnKiir.Size = new System.Drawing.Size(75, 23);
            this.btnKiir.TabIndex = 8;
            this.btnKiir.Text = "Kiír";
            this.btnKiir.UseVisualStyleBackColor = true;
            this.btnKiir.Click += new System.EventHandler(this.btnKiir_Click);
            // 
            // btnTorol
            // 
            this.btnTorol.Location = new System.Drawing.Point(244, 356);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(75, 23);
            this.btnTorol.TabIndex = 9;
            this.btnTorol.Text = "Töröl";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // btnBezar
            // 
            this.btnBezar.Location = new System.Drawing.Point(407, 356);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(75, 23);
            this.btnBezar.TabIndex = 10;
            this.btnBezar.Text = "Bezár";
            this.btnBezar.UseVisualStyleBackColor = true;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatum.Location = new System.Drawing.Point(165, 18);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(57, 20);
            this.lblDatum.TabIndex = 11;
            this.lblDatum.Text = "label8";
            // 
            // txtEvSzam
            // 
            this.txtEvSzam.Enabled = false;
            this.txtEvSzam.Location = new System.Drawing.Point(130, 142);
            this.txtEvSzam.Name = "txtEvSzam";
            this.txtEvSzam.Size = new System.Drawing.Size(63, 20);
            this.txtEvSzam.TabIndex = 13;
            // 
            // txtNap
            // 
            this.txtNap.Enabled = false;
            this.txtNap.Location = new System.Drawing.Point(396, 141);
            this.txtNap.Name = "txtNap";
            this.txtNap.Size = new System.Drawing.Size(113, 20);
            this.txtNap.TabIndex = 14;
            // 
            // txtNapSzam
            // 
            this.txtNapSzam.Location = new System.Drawing.Point(233, 289);
            this.txtNapSzam.Name = "txtNapSzam";
            this.txtNapSzam.Size = new System.Drawing.Size(44, 20);
            this.txtNapSzam.TabIndex = 15;
            this.txtNapSzam.TextChanged += new System.EventHandler(this.txtNapSzam_TextChanged);
            // 
            // txtNapSorszam
            // 
            this.txtNapSorszam.Enabled = false;
            this.txtNapSorszam.Location = new System.Drawing.Point(427, 248);
            this.txtNapSorszam.Name = "txtNapSorszam";
            this.txtNapSorszam.Size = new System.Drawing.Size(82, 20);
            this.txtNapSorszam.TabIndex = 16;
            // 
            // txtKesobbiDatum
            // 
            this.txtKesobbiDatum.Enabled = false;
            this.txtKesobbiDatum.Location = new System.Drawing.Point(427, 289);
            this.txtKesobbiDatum.Name = "txtKesobbiDatum";
            this.txtKesobbiDatum.Size = new System.Drawing.Size(82, 20);
            this.txtKesobbiDatum.TabIndex = 17;
            // 
            // lblGratulacio
            // 
            this.lblGratulacio.AutoSize = true;
            this.lblGratulacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGratulacio.ForeColor = System.Drawing.Color.Firebrick;
            this.lblGratulacio.Location = new System.Drawing.Point(206, 199);
            this.lblGratulacio.Name = "lblGratulacio";
            this.lblGratulacio.Size = new System.Drawing.Size(57, 20);
            this.lblGratulacio.TabIndex = 18;
            this.lblGratulacio.Text = "label8";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mskdTxtSzulDatum
            // 
            this.mskdTxtSzulDatum.Location = new System.Drawing.Point(130, 82);
            this.mskdTxtSzulDatum.Mask = "0000-00-00";
            this.mskdTxtSzulDatum.Name = "mskdTxtSzulDatum";
            this.mskdTxtSzulDatum.Size = new System.Drawing.Size(75, 20);
            this.mskdTxtSzulDatum.TabIndex = 19;
            this.mskdTxtSzulDatum.ValidatingType = typeof(System.DateTime);
            this.mskdTxtSzulDatum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskdTxtSzulDatum_KeyPress);
            this.mskdTxtSzulDatum.Leave += new System.EventHandler(this.mskdTxtSzulDatum_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.mskdTxtSzulDatum);
            this.Controls.Add(this.lblGratulacio);
            this.Controls.Add(this.txtKesobbiDatum);
            this.Controls.Add(this.txtNapSorszam);
            this.Controls.Add(this.txtNapSzam);
            this.Controls.Add(this.txtNap);
            this.Controls.Add(this.txtEvSzam);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.btnKiir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Dátum és idő kezelése";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKiir;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.Button btnBezar;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.TextBox txtEvSzam;
        private System.Windows.Forms.TextBox txtNap;
        private System.Windows.Forms.TextBox txtNapSzam;
        private System.Windows.Forms.TextBox txtNapSorszam;
        private System.Windows.Forms.TextBox txtKesobbiDatum;
        private System.Windows.Forms.Label lblGratulacio;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MaskedTextBox mskdTxtSzulDatum;
    }
}

