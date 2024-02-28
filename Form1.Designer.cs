namespace combobox
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
            cmbSehirler = new ComboBox();
            groupBox1 = new GroupBox();
            btnOku = new Button();
            btnSil = new Button();
            btnHepsinisil = new Button();
            btndegistir = new Button();
            lblbilgi = new Label();
            txtsehir = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbSehirler
            // 
            cmbSehirler.AccessibleRole = AccessibleRole.ScrollBar;
            cmbSehirler.FormattingEnabled = true;
            cmbSehirler.Location = new Point(0, 47);
            cmbSehirler.Name = "cmbSehirler";
            cmbSehirler.Size = new Size(219, 28);
            cmbSehirler.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbSehirler);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 116);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Şehirler";
            // 
            // btnOku
            // 
            btnOku.Location = new Point(330, 25);
            btnOku.Name = "btnOku";
            btnOku.Size = new Size(119, 47);
            btnOku.TabIndex = 2;
            btnOku.Text = "OKU";
            btnOku.UseVisualStyleBackColor = true;
            btnOku.Click += btnOku_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(330, 81);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(119, 47);
            btnSil.TabIndex = 2;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnHepsinisil
            // 
            btnHepsinisil.Location = new Point(495, 81);
            btnHepsinisil.Name = "btnHepsinisil";
            btnHepsinisil.Size = new Size(119, 47);
            btnHepsinisil.TabIndex = 2;
            btnHepsinisil.Text = "HEPSİNİ SİL";
            btnHepsinisil.UseVisualStyleBackColor = true;
            btnHepsinisil.Click += btnHepsinisil_Click;
            // 
            // btndegistir
            // 
            btndegistir.Location = new Point(495, 25);
            btndegistir.Name = "btndegistir";
            btndegistir.Size = new Size(119, 47);
            btndegistir.TabIndex = 2;
            btndegistir.Text = "DEĞİŞTİR";
            btndegistir.UseVisualStyleBackColor = true;
            btndegistir.Click += btndegistir_Click;
            // 
            // lblbilgi
            // 
            lblbilgi.BorderStyle = BorderStyle.Fixed3D;
            lblbilgi.Location = new Point(12, 226);
            lblbilgi.Name = "lblbilgi";
            lblbilgi.Size = new Size(602, 126);
            lblbilgi.TabIndex = 3;
            lblbilgi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtsehir
            // 
            txtsehir.Location = new Point(489, 162);
            txtsehir.Name = "txtsehir";
            txtsehir.Size = new Size(125, 27);
            txtsehir.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(345, 166);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 5;
            label1.Text = "Yeni Değer";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 361);
            Controls.Add(label1);
            Controls.Add(txtsehir);
            Controls.Add(lblbilgi);
            Controls.Add(btndegistir);
            Controls.Add(btnHepsinisil);
            Controls.Add(btnSil);
            Controls.Add(btnOku);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSehirler;
        private GroupBox groupBox1;
        private Button btnOku;
        private Button btnSil;
        private Button btnHepsinisil;
        private Button btndegistir;
        private Label lblbilgi;
        private TextBox txtsehir;
        private Label label1;
    }
}
