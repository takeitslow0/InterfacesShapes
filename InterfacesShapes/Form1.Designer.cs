namespace InterfacesShapes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rbDaire = new System.Windows.Forms.RadioButton();
            this.rbDortgen = new System.Windows.Forms.RadioButton();
            this.rbUcgen = new System.Windows.Forms.RadioButton();
            this.pDaire = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPi = new System.Windows.Forms.CheckBox();
            this.tbYaricap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pDiger = new System.Windows.Forms.Panel();
            this.tbYukseklik = new System.Windows.Forms.TextBox();
            this.tbGenislik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.ddlIslem = new System.Windows.Forms.ComboBox();
            this.lSonuc = new System.Windows.Forms.Label();
            this.pDaire.SuspendLayout();
            this.pDiger.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbDaire
            // 
            this.rbDaire.AutoSize = true;
            this.rbDaire.BackColor = System.Drawing.Color.Black;
            this.rbDaire.Checked = true;
            this.rbDaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbDaire.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.rbDaire.Location = new System.Drawing.Point(12, 9);
            this.rbDaire.Name = "rbDaire";
            this.rbDaire.Size = new System.Drawing.Size(64, 20);
            this.rbDaire.TabIndex = 0;
            this.rbDaire.TabStop = true;
            this.rbDaire.Text = "Daire";
            this.rbDaire.UseMnemonic = false;
            this.rbDaire.UseVisualStyleBackColor = false;
            this.rbDaire.CheckedChanged += new System.EventHandler(this.rbDaire_CheckedChanged);
            // 
            // rbDortgen
            // 
            this.rbDortgen.AutoSize = true;
            this.rbDortgen.BackColor = System.Drawing.Color.Black;
            this.rbDortgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbDortgen.ForeColor = System.Drawing.Color.Aqua;
            this.rbDortgen.Location = new System.Drawing.Point(86, 7);
            this.rbDortgen.Name = "rbDortgen";
            this.rbDortgen.Size = new System.Drawing.Size(86, 22);
            this.rbDortgen.TabIndex = 1;
            this.rbDortgen.Text = "Dörtgen";
            this.rbDortgen.UseVisualStyleBackColor = false;
            this.rbDortgen.CheckedChanged += new System.EventHandler(this.rbDortgen_CheckedChanged);
            // 
            // rbUcgen
            // 
            this.rbUcgen.AutoSize = true;
            this.rbUcgen.BackColor = System.Drawing.Color.Black;
            this.rbUcgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbUcgen.ForeColor = System.Drawing.Color.Turquoise;
            this.rbUcgen.Location = new System.Drawing.Point(178, 7);
            this.rbUcgen.Name = "rbUcgen";
            this.rbUcgen.Size = new System.Drawing.Size(110, 24);
            this.rbUcgen.TabIndex = 2;
            this.rbUcgen.TabStop = true;
            this.rbUcgen.Text = "Dik Üçgen";
            this.rbUcgen.UseVisualStyleBackColor = false;
            this.rbUcgen.CheckedChanged += new System.EventHandler(this.rbUcgen_CheckedChanged);
            // 
            // pDaire
            // 
            this.pDaire.BackColor = System.Drawing.Color.DimGray;
            this.pDaire.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pDaire.Controls.Add(this.label4);
            this.pDaire.Controls.Add(this.cbPi);
            this.pDaire.Controls.Add(this.tbYaricap);
            this.pDaire.Controls.Add(this.label1);
            this.pDaire.Location = new System.Drawing.Point(12, 35);
            this.pDaire.Name = "pDaire";
            this.pDaire.Size = new System.Drawing.Size(258, 152);
            this.pDaire.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Eğer işaretli değilse pi 3.14 olarak alınır";
            // 
            // cbPi
            // 
            this.cbPi.AutoSize = true;
            this.cbPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbPi.Location = new System.Drawing.Point(72, 31);
            this.cbPi.Name = "cbPi";
            this.cbPi.Size = new System.Drawing.Size(118, 17);
            this.cbPi.TabIndex = 2;
            this.cbPi.Text = "PI: 3 ise işaretle";
            this.cbPi.UseVisualStyleBackColor = true;
            // 
            // tbYaricap
            // 
            this.tbYaricap.BackColor = System.Drawing.Color.Maroon;
            this.tbYaricap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbYaricap.ForeColor = System.Drawing.Color.Gold;
            this.tbYaricap.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbYaricap.Location = new System.Drawing.Point(72, 3);
            this.tbYaricap.Name = "tbYaricap";
            this.tbYaricap.Size = new System.Drawing.Size(162, 22);
            this.tbYaricap.TabIndex = 1;
            this.tbYaricap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbYaricap_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yarıçap: ";
            // 
            // pDiger
            // 
            this.pDiger.BackColor = System.Drawing.Color.DimGray;
            this.pDiger.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pDiger.Controls.Add(this.tbYukseklik);
            this.pDiger.Controls.Add(this.tbGenislik);
            this.pDiger.Controls.Add(this.label3);
            this.pDiger.Controls.Add(this.label2);
            this.pDiger.Location = new System.Drawing.Point(303, 40);
            this.pDiger.Name = "pDiger";
            this.pDiger.Size = new System.Drawing.Size(258, 152);
            this.pDiger.TabIndex = 4;
            this.pDiger.Visible = false;
            // 
            // tbYukseklik
            // 
            this.tbYukseklik.BackColor = System.Drawing.Color.Maroon;
            this.tbYukseklik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbYukseklik.ForeColor = System.Drawing.Color.Gold;
            this.tbYukseklik.Location = new System.Drawing.Point(80, 26);
            this.tbYukseklik.Name = "tbYukseklik";
            this.tbYukseklik.Size = new System.Drawing.Size(162, 24);
            this.tbYukseklik.TabIndex = 1;
            this.tbYukseklik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbYukseklik_KeyPress);
            // 
            // tbGenislik
            // 
            this.tbGenislik.BackColor = System.Drawing.Color.Maroon;
            this.tbGenislik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbGenislik.ForeColor = System.Drawing.Color.Gold;
            this.tbGenislik.Location = new System.Drawing.Point(80, 0);
            this.tbGenislik.Name = "tbGenislik";
            this.tbGenislik.Size = new System.Drawing.Size(162, 24);
            this.tbGenislik.TabIndex = 1;
            this.tbGenislik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGenislik_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yükseklik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Genişlik:";
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.Transparent;
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnHesapla.Location = new System.Drawing.Point(195, 193);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // ddlIslem
            // 
            this.ddlIslem.BackColor = System.Drawing.Color.Gold;
            this.ddlIslem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ddlIslem.FormattingEnabled = true;
            this.ddlIslem.Location = new System.Drawing.Point(20, 193);
            this.ddlIslem.Name = "ddlIslem";
            this.ddlIslem.Size = new System.Drawing.Size(160, 24);
            this.ddlIslem.TabIndex = 5;
            // 
            // lSonuc
            // 
            this.lSonuc.AutoSize = true;
            this.lSonuc.BackColor = System.Drawing.Color.Black;
            this.lSonuc.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSonuc.ForeColor = System.Drawing.Color.Red;
            this.lSonuc.Location = new System.Drawing.Point(20, 224);
            this.lSonuc.Name = "lSonuc";
            this.lSonuc.Size = new System.Drawing.Size(66, 18);
            this.lSonuc.TabIndex = 6;
            this.lSonuc.Text = "Sonuç: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(581, 285);
            this.Controls.Add(this.lSonuc);
            this.Controls.Add(this.ddlIslem);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.pDiger);
            this.Controls.Add(this.pDaire);
            this.Controls.Add(this.rbUcgen);
            this.Controls.Add(this.rbDortgen);
            this.Controls.Add(this.rbDaire);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Shapes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pDaire.ResumeLayout(false);
            this.pDaire.PerformLayout();
            this.pDiger.ResumeLayout(false);
            this.pDiger.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDaire;
        private System.Windows.Forms.RadioButton rbDortgen;
        private System.Windows.Forms.RadioButton rbUcgen;
        private System.Windows.Forms.Panel pDaire;
        private System.Windows.Forms.TextBox tbYaricap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pDiger;
        private System.Windows.Forms.TextBox tbYukseklik;
        private System.Windows.Forms.TextBox tbGenislik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.ComboBox ddlIslem;
        private System.Windows.Forms.Label lSonuc;
        private System.Windows.Forms.CheckBox cbPi;
        private System.Windows.Forms.Label label4;
    }
}

