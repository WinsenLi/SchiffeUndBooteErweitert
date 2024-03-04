namespace FrmSchiffeUndBoote
{
    partial class FrmBesitzer
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
            listBox1 = new ListBox();
            btn_Minus = new Button();
            Btn_Plus = new Button();
            tbx_Vorname = new TextBox();
            tbx_land = new TextBox();
            tbx_plz = new TextBox();
            tbx_ort = new TextBox();
            tbx_hausnummer = new TextBox();
            tbx_strasse = new TextBox();
            tbx_Nachname = new TextBox();
            lbl_Vorname = new Label();
            lbl_Land = new Label();
            lbl_plz = new Label();
            lbl_ort = new Label();
            lbl_hausnummer = new Label();
            lbl_strasse = new Label();
            lbl_Nachname = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(61, 35);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(236, 184);
            listBox1.TabIndex = 0;
            // 
            // btn_Minus
            // 
            btn_Minus.Location = new Point(61, 225);
            btn_Minus.Name = "btn_Minus";
            btn_Minus.Size = new Size(105, 49);
            btn_Minus.TabIndex = 1;
            btn_Minus.Text = "-";
            btn_Minus.UseVisualStyleBackColor = true;
            // 
            // Btn_Plus
            // 
            Btn_Plus.Location = new Point(172, 225);
            Btn_Plus.Name = "Btn_Plus";
            Btn_Plus.Size = new Size(125, 49);
            Btn_Plus.TabIndex = 2;
            Btn_Plus.Text = "+";
            Btn_Plus.UseVisualStyleBackColor = true;
            Btn_Plus.Click += Btn_Plus_Click;
            // 
            // tbx_Vorname
            // 
            tbx_Vorname.Location = new Point(358, 35);
            tbx_Vorname.Name = "tbx_Vorname";
            tbx_Vorname.Size = new Size(134, 23);
            tbx_Vorname.TabIndex = 3;
            // 
            // tbx_land
            // 
            tbx_land.Location = new Point(358, 348);
            tbx_land.Name = "tbx_land";
            tbx_land.Size = new Size(134, 23);
            tbx_land.TabIndex = 4;
            // 
            // tbx_plz
            // 
            tbx_plz.Location = new Point(358, 304);
            tbx_plz.Name = "tbx_plz";
            tbx_plz.Size = new Size(134, 23);
            tbx_plz.TabIndex = 5;
            // 
            // tbx_ort
            // 
            tbx_ort.Location = new Point(358, 251);
            tbx_ort.Name = "tbx_ort";
            tbx_ort.Size = new Size(134, 23);
            tbx_ort.TabIndex = 6;
            // 
            // tbx_hausnummer
            // 
            tbx_hausnummer.Location = new Point(358, 196);
            tbx_hausnummer.Name = "tbx_hausnummer";
            tbx_hausnummer.Size = new Size(134, 23);
            tbx_hausnummer.TabIndex = 7;
            // 
            // tbx_strasse
            // 
            tbx_strasse.Location = new Point(358, 140);
            tbx_strasse.Name = "tbx_strasse";
            tbx_strasse.Size = new Size(134, 23);
            tbx_strasse.TabIndex = 8;
            // 
            // tbx_Nachname
            // 
            tbx_Nachname.Location = new Point(358, 90);
            tbx_Nachname.Name = "tbx_Nachname";
            tbx_Nachname.Size = new Size(134, 23);
            tbx_Nachname.TabIndex = 9;
            // 
            // lbl_Vorname
            // 
            lbl_Vorname.AutoSize = true;
            lbl_Vorname.Location = new Point(358, 17);
            lbl_Vorname.Name = "lbl_Vorname";
            lbl_Vorname.Size = new Size(54, 15);
            lbl_Vorname.TabIndex = 10;
            lbl_Vorname.Text = "Vorname";
            // 
            // lbl_Land
            // 
            lbl_Land.AutoSize = true;
            lbl_Land.Location = new Point(358, 330);
            lbl_Land.Name = "lbl_Land";
            lbl_Land.Size = new Size(33, 15);
            lbl_Land.TabIndex = 11;
            lbl_Land.Text = "Land";
            // 
            // lbl_plz
            // 
            lbl_plz.AutoSize = true;
            lbl_plz.Location = new Point(358, 286);
            lbl_plz.Name = "lbl_plz";
            lbl_plz.Size = new Size(67, 15);
            lbl_plz.TabIndex = 12;
            lbl_plz.Text = "Postleitzahl";
            // 
            // lbl_ort
            // 
            lbl_ort.AutoSize = true;
            lbl_ort.Location = new Point(358, 233);
            lbl_ort.Name = "lbl_ort";
            lbl_ort.Size = new Size(24, 15);
            lbl_ort.TabIndex = 13;
            lbl_ort.Text = "Ort";
            // 
            // lbl_hausnummer
            // 
            lbl_hausnummer.AutoSize = true;
            lbl_hausnummer.Location = new Point(358, 178);
            lbl_hausnummer.Name = "lbl_hausnummer";
            lbl_hausnummer.Size = new Size(80, 15);
            lbl_hausnummer.TabIndex = 14;
            lbl_hausnummer.Text = "Hausnummer";
            // 
            // lbl_strasse
            // 
            lbl_strasse.AutoSize = true;
            lbl_strasse.Location = new Point(358, 122);
            lbl_strasse.Name = "lbl_strasse";
            lbl_strasse.Size = new Size(40, 15);
            lbl_strasse.TabIndex = 15;
            lbl_strasse.Text = "Straße";
            // 
            // lbl_Nachname
            // 
            lbl_Nachname.AutoSize = true;
            lbl_Nachname.Location = new Point(358, 72);
            lbl_Nachname.Name = "lbl_Nachname";
            lbl_Nachname.Size = new Size(65, 15);
            lbl_Nachname.TabIndex = 16;
            lbl_Nachname.Text = "Nachname";
            // 
            // FrmBesitzer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_Nachname);
            Controls.Add(lbl_strasse);
            Controls.Add(lbl_hausnummer);
            Controls.Add(lbl_ort);
            Controls.Add(lbl_plz);
            Controls.Add(lbl_Land);
            Controls.Add(lbl_Vorname);
            Controls.Add(tbx_Nachname);
            Controls.Add(tbx_strasse);
            Controls.Add(tbx_hausnummer);
            Controls.Add(tbx_ort);
            Controls.Add(tbx_plz);
            Controls.Add(tbx_land);
            Controls.Add(tbx_Vorname);
            Controls.Add(Btn_Plus);
            Controls.Add(btn_Minus);
            Controls.Add(listBox1);
            Name = "FrmBesitzer";
            Text = "FrmBesitzer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button btn_Minus;
        private Button Btn_Plus;
        private TextBox tbx_Vorname;
        private TextBox tbx_land;
        private TextBox tbx_plz;
        private TextBox tbx_ort;
        private TextBox tbx_hausnummer;
        private TextBox tbx_strasse;
        private TextBox tbx_Nachname;
        private Label lbl_Vorname;
        private Label lbl_Land;
        private Label lbl_plz;
        private Label lbl_ort;
        private Label lbl_hausnummer;
        private Label lbl_strasse;
        private Label lbl_Nachname;
    }
}