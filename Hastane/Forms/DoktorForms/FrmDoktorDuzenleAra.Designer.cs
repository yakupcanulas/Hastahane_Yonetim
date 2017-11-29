namespace Hastane.Forms.DoktorForms
{
    partial class FrmDoktorDuzenleAra
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
            this.liste = new System.Windows.Forms.ListBox();
            this.txtDktDznAra = new System.Windows.Forms.TextBox();
            this.btnDktDznAraTemizle = new System.Windows.Forms.Button();
            this.btnDktDznAraKaydet = new System.Windows.Forms.Button();
            this.comboBirimDktDznAra = new System.Windows.Forms.ComboBox();
            this.comboKanDktDznAra = new System.Windows.Forms.ComboBox();
            this.comboCinsiDktDznAra = new System.Windows.Forms.ComboBox();
            this.dateDktDogumDznAra = new System.Windows.Forms.DateTimePicker();
            this.txtDktTCDznAra = new System.Windows.Forms.TextBox();
            this.txtDktSoyadDuznAra = new System.Windows.Forms.TextBox();
            this.txtDktAdDuznAra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDktDznAraSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // liste
            // 
            this.liste.FormattingEnabled = true;
            this.liste.Location = new System.Drawing.Point(261, 52);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(195, 225);
            this.liste.TabIndex = 66;
            this.liste.SelectedIndexChanged += new System.EventHandler(this.lstDktDznAra_SelectedIndexChanged);
            // 
            // txtDktDznAra
            // 
            this.txtDktDznAra.Location = new System.Drawing.Point(261, 20);
            this.txtDktDznAra.Name = "txtDktDznAra";
            this.txtDktDznAra.Size = new System.Drawing.Size(195, 20);
            this.txtDktDznAra.TabIndex = 65;
            this.txtDktDznAra.TextChanged += new System.EventHandler(this.txtDktDznAra_TextChanged);
            // 
            // btnDktDznAraTemizle
            // 
            this.btnDktDznAraTemizle.Location = new System.Drawing.Point(127, 295);
            this.btnDktDznAraTemizle.Name = "btnDktDznAraTemizle";
            this.btnDktDznAraTemizle.Size = new System.Drawing.Size(75, 50);
            this.btnDktDznAraTemizle.TabIndex = 63;
            this.btnDktDznAraTemizle.Text = "Temizle";
            this.btnDktDznAraTemizle.UseVisualStyleBackColor = true;
            // 
            // btnDktDznAraKaydet
            // 
            this.btnDktDznAraKaydet.Location = new System.Drawing.Point(35, 295);
            this.btnDktDznAraKaydet.Name = "btnDktDznAraKaydet";
            this.btnDktDznAraKaydet.Size = new System.Drawing.Size(75, 50);
            this.btnDktDznAraKaydet.TabIndex = 62;
            this.btnDktDznAraKaydet.Text = "Kaydet";
            this.btnDktDznAraKaydet.UseVisualStyleBackColor = true;
            this.btnDktDznAraKaydet.Click += new System.EventHandler(this.btnDktDznAraKaydet_Click);
            // 
            // comboBirimDktDznAra
            // 
            this.comboBirimDktDznAra.FormattingEnabled = true;
            this.comboBirimDktDznAra.Location = new System.Drawing.Point(90, 231);
            this.comboBirimDktDznAra.Name = "comboBirimDktDznAra";
            this.comboBirimDktDznAra.Size = new System.Drawing.Size(150, 21);
            this.comboBirimDktDznAra.TabIndex = 59;
            // 
            // comboKanDktDznAra
            // 
            this.comboKanDktDznAra.FormattingEnabled = true;
            this.comboKanDktDznAra.Location = new System.Drawing.Point(90, 196);
            this.comboKanDktDznAra.Name = "comboKanDktDznAra";
            this.comboKanDktDznAra.Size = new System.Drawing.Size(150, 21);
            this.comboKanDktDznAra.TabIndex = 58;
            // 
            // comboCinsiDktDznAra
            // 
            this.comboCinsiDktDznAra.FormattingEnabled = true;
            this.comboCinsiDktDznAra.Location = new System.Drawing.Point(90, 160);
            this.comboCinsiDktDznAra.Name = "comboCinsiDktDznAra";
            this.comboCinsiDktDznAra.Size = new System.Drawing.Size(150, 21);
            this.comboCinsiDktDznAra.TabIndex = 57;
            // 
            // dateDktDogumDznAra
            // 
            this.dateDktDogumDznAra.Location = new System.Drawing.Point(90, 124);
            this.dateDktDogumDznAra.Name = "dateDktDogumDznAra";
            this.dateDktDogumDznAra.Size = new System.Drawing.Size(150, 20);
            this.dateDktDogumDznAra.TabIndex = 56;
            // 
            // txtDktTCDznAra
            // 
            this.txtDktTCDznAra.Location = new System.Drawing.Point(90, 89);
            this.txtDktTCDznAra.Name = "txtDktTCDznAra";
            this.txtDktTCDznAra.Size = new System.Drawing.Size(150, 20);
            this.txtDktTCDznAra.TabIndex = 55;
            // 
            // txtDktSoyadDuznAra
            // 
            this.txtDktSoyadDuznAra.Location = new System.Drawing.Point(90, 55);
            this.txtDktSoyadDuznAra.Name = "txtDktSoyadDuznAra";
            this.txtDktSoyadDuznAra.Size = new System.Drawing.Size(150, 20);
            this.txtDktSoyadDuznAra.TabIndex = 54;
            // 
            // txtDktAdDuznAra
            // 
            this.txtDktAdDuznAra.Location = new System.Drawing.Point(90, 21);
            this.txtDktAdDuznAra.Name = "txtDktAdDuznAra";
            this.txtDktAdDuznAra.Size = new System.Drawing.Size(150, 20);
            this.txtDktAdDuznAra.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Birim";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Kan Grubu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Cinsiyet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Doğum Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "TCKN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Ad";
            // 
            // btnDktDznAraSil
            // 
            this.btnDktDznAraSil.Location = new System.Drawing.Point(219, 295);
            this.btnDktDznAraSil.Name = "btnDktDznAraSil";
            this.btnDktDznAraSil.Size = new System.Drawing.Size(75, 50);
            this.btnDktDznAraSil.TabIndex = 67;
            this.btnDktDznAraSil.Text = "Sil";
            this.btnDktDznAraSil.UseVisualStyleBackColor = true;
            // 
            // FrmDoktorDuzenleAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 391);
            this.Controls.Add(this.btnDktDznAraSil);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.txtDktDznAra);
            this.Controls.Add(this.btnDktDznAraTemizle);
            this.Controls.Add(this.btnDktDznAraKaydet);
            this.Controls.Add(this.comboBirimDktDznAra);
            this.Controls.Add(this.comboKanDktDznAra);
            this.Controls.Add(this.comboCinsiDktDznAra);
            this.Controls.Add(this.dateDktDogumDznAra);
            this.Controls.Add(this.txtDktTCDznAra);
            this.Controls.Add(this.txtDktSoyadDuznAra);
            this.Controls.Add(this.txtDktAdDuznAra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDoktorDuzenleAra";
            this.Text = "FrmDoktorDuzenleAra";
            this.Load += new System.EventHandler(this.FrmDoktorDuzenleAra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox liste;
        private System.Windows.Forms.TextBox txtDktDznAra;
        private System.Windows.Forms.Button btnDktDznAraTemizle;
        private System.Windows.Forms.Button btnDktDznAraKaydet;
        private System.Windows.Forms.ComboBox comboBirimDktDznAra;
        private System.Windows.Forms.ComboBox comboKanDktDznAra;
        private System.Windows.Forms.ComboBox comboCinsiDktDznAra;
        private System.Windows.Forms.DateTimePicker dateDktDogumDznAra;
        private System.Windows.Forms.TextBox txtDktTCDznAra;
        private System.Windows.Forms.TextBox txtDktSoyadDuznAra;
        private System.Windows.Forms.TextBox txtDktAdDuznAra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDktDznAraSil;
    }
}