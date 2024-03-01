namespace FrmSchiffeUndBoote
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
            lbx_Schiffe = new ListBox();
            lbx_Boote = new ListBox();
            lbx_Länder = new ListBox();
            lbx_Besitzer = new ListBox();
            btn_Land_Minus = new Button();
            btn_Land_Plus = new Button();
            lbl_Land_Name = new Label();
            lbl_Land_Kuerzel = new Label();
            tbx_Land_Name = new TextBox();
            tbx_Land_Kuerzel = new TextBox();
            SuspendLayout();
            // 
            // lbx_Schiffe
            // 
            lbx_Schiffe.FormattingEnabled = true;
            lbx_Schiffe.ItemHeight = 15;
            lbx_Schiffe.Location = new Point(503, 262);
            lbx_Schiffe.Name = "lbx_Schiffe";
            lbx_Schiffe.Size = new Size(120, 94);
            lbx_Schiffe.TabIndex = 0;
            // 
            // lbx_Boote
            // 
            lbx_Boote.FormattingEnabled = true;
            lbx_Boote.ItemHeight = 15;
            lbx_Boote.Location = new Point(629, 200);
            lbx_Boote.Name = "lbx_Boote";
            lbx_Boote.Size = new Size(120, 94);
            lbx_Boote.TabIndex = 1;
            // 
            // lbx_Länder
            // 
            lbx_Länder.FormattingEnabled = true;
            lbx_Länder.ItemHeight = 15;
            lbx_Länder.Location = new Point(26, 36);
            lbx_Länder.MultiColumn = true;
            lbx_Länder.Name = "lbx_Länder";
            lbx_Länder.Size = new Size(120, 94);
            lbx_Länder.TabIndex = 2;
            lbx_Länder.SelectedIndexChanged += lbx_Länder_SelectedIndexChanged;
            // 
            // lbx_Besitzer
            // 
            lbx_Besitzer.FormattingEnabled = true;
            lbx_Besitzer.ItemHeight = 15;
            lbx_Besitzer.Location = new Point(580, 57);
            lbx_Besitzer.Name = "lbx_Besitzer";
            lbx_Besitzer.Size = new Size(120, 94);
            lbx_Besitzer.TabIndex = 3;
            // 
            // btn_Land_Minus
            // 
            btn_Land_Minus.Location = new Point(26, 136);
            btn_Land_Minus.Name = "btn_Land_Minus";
            btn_Land_Minus.Size = new Size(53, 25);
            btn_Land_Minus.TabIndex = 4;
            btn_Land_Minus.Text = "-";
            btn_Land_Minus.UseVisualStyleBackColor = true;
            // 
            // btn_Land_Plus
            // 
            btn_Land_Plus.Location = new Point(85, 136);
            btn_Land_Plus.Name = "btn_Land_Plus";
            btn_Land_Plus.Size = new Size(61, 25);
            btn_Land_Plus.TabIndex = 5;
            btn_Land_Plus.Text = "+";
            btn_Land_Plus.UseVisualStyleBackColor = true;
            btn_Land_Plus.Click += btn_Land_Plus_Click;
            // 
            // lbl_Land_Name
            // 
            lbl_Land_Name.AutoSize = true;
            lbl_Land_Name.Location = new Point(152, 36);
            lbl_Land_Name.Name = "lbl_Land_Name";
            lbl_Land_Name.Size = new Size(39, 15);
            lbl_Land_Name.TabIndex = 6;
            lbl_Land_Name.Text = "Name";
            // 
            // lbl_Land_Kuerzel
            // 
            lbl_Land_Kuerzel.AutoSize = true;
            lbl_Land_Kuerzel.Location = new Point(152, 88);
            lbl_Land_Kuerzel.Name = "lbl_Land_Kuerzel";
            lbl_Land_Kuerzel.Size = new Size(39, 15);
            lbl_Land_Kuerzel.TabIndex = 7;
            lbl_Land_Kuerzel.Text = "Kürzel";
            // 
            // tbx_Land_Name
            // 
            tbx_Land_Name.Location = new Point(152, 54);
            tbx_Land_Name.Name = "tbx_Land_Name";
            tbx_Land_Name.Size = new Size(100, 23);
            tbx_Land_Name.TabIndex = 8;
            tbx_Land_Name.TextChanged += textBox1_TextChanged;
            // 
            // tbx_Land_Kuerzel
            // 
            tbx_Land_Kuerzel.Location = new Point(152, 106);
            tbx_Land_Kuerzel.Name = "tbx_Land_Kuerzel";
            tbx_Land_Kuerzel.Size = new Size(100, 23);
            tbx_Land_Kuerzel.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbx_Land_Kuerzel);
            Controls.Add(tbx_Land_Name);
            Controls.Add(lbl_Land_Kuerzel);
            Controls.Add(lbl_Land_Name);
            Controls.Add(btn_Land_Plus);
            Controls.Add(btn_Land_Minus);
            Controls.Add(lbx_Besitzer);
            Controls.Add(lbx_Länder);
            Controls.Add(lbx_Boote);
            Controls.Add(lbx_Schiffe);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbx_Schiffe;
        private ListBox lbx_Boote;
        private ListBox lbx_Länder;
        private ListBox lbx_Besitzer;
        private Button btn_Land_Minus;
        private Button btn_Land_Plus;
        private Label lbl_Land_Name;
        private Label lbl_Land_Kuerzel;
        private TextBox tbx_Land_Name;
        private TextBox tbx_Land_Kuerzel;
    }
}
