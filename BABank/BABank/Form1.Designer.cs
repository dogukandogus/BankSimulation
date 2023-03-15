namespace BABank
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBankOLustur = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMusteriGeldi = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.lstVip = new System.Windows.Forms.ListBox();
            this.lstBireysel = new System.Windows.Forms.ListBox();
            this.lstGiseIslem = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGiseler = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBankOLustur
            // 
            this.btnBankOLustur.Location = new System.Drawing.Point(56, 46);
            this.btnBankOLustur.Name = "btnBankOLustur";
            this.btnBankOLustur.Size = new System.Drawing.Size(133, 49);
            this.btnBankOLustur.TabIndex = 0;
            this.btnBankOLustur.Text = "Banka Oluştur";
            this.btnBankOLustur.UseVisualStyleBackColor = true;
            this.btnBankOLustur.Click += new System.EventHandler(this.btnBankOLustur_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMusteriGeldi);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtTC);
            this.groupBox1.Location = new System.Drawing.Point(224, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 157);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnMusteriGeldi
            // 
            this.btnMusteriGeldi.Location = new System.Drawing.Point(212, 102);
            this.btnMusteriGeldi.Name = "btnMusteriGeldi";
            this.btnMusteriGeldi.Size = new System.Drawing.Size(112, 28);
            this.btnMusteriGeldi.TabIndex = 2;
            this.btnMusteriGeldi.Text = "Müşteri Geldi";
            this.btnMusteriGeldi.UseVisualStyleBackColor = true;
            this.btnMusteriGeldi.Click += new System.EventHandler(this.btnMusteriGeldi_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(26, 36);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(298, 27);
            this.txtTC.TabIndex = 0;
            // 
            // lstVip
            // 
            this.lstVip.FormattingEnabled = true;
            this.lstVip.ItemHeight = 20;
            this.lstVip.Location = new System.Drawing.Point(56, 235);
            this.lstVip.Name = "lstVip";
            this.lstVip.Size = new System.Drawing.Size(107, 304);
            this.lstVip.TabIndex = 2;
            // 
            // lstBireysel
            // 
            this.lstBireysel.FormattingEnabled = true;
            this.lstBireysel.ItemHeight = 20;
            this.lstBireysel.Location = new System.Drawing.Point(280, 235);
            this.lstBireysel.Name = "lstBireysel";
            this.lstBireysel.Size = new System.Drawing.Size(107, 304);
            this.lstBireysel.TabIndex = 3;
            // 
            // lstGiseIslem
            // 
            this.lstGiseIslem.FormattingEnabled = true;
            this.lstGiseIslem.ItemHeight = 20;
            this.lstGiseIslem.Location = new System.Drawing.Point(516, 235);
            this.lstGiseIslem.Name = "lstGiseIslem";
            this.lstGiseIslem.Size = new System.Drawing.Size(107, 304);
            this.lstGiseIslem.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(712, 46);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(361, 523);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btnGiseler
            // 
            this.btnGiseler.Location = new System.Drawing.Point(602, 12);
            this.btnGiseler.Name = "btnGiseler";
            this.btnGiseler.Size = new System.Drawing.Size(94, 29);
            this.btnGiseler.TabIndex = 6;
            this.btnGiseler.Text = "Gişeler";
            this.btnGiseler.UseVisualStyleBackColor = true;
            this.btnGiseler.Click += new System.EventHandler(this.btnGiseler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 859);
            this.Controls.Add(this.btnGiseler);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lstGiseIslem);
            this.Controls.Add(this.lstBireysel);
            this.Controls.Add(this.lstVip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBankOLustur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnBankOLustur;
        private GroupBox groupBox1;
        private Button btnMusteriGeldi;
        private ComboBox comboBox1;
        private TextBox txtTC;
        private ListBox lstVip;
        private ListBox lstBireysel;
        private ListBox lstGiseIslem;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnGiseler;
    }
}