namespace FrmSchiffeUndBoote
{
    partial class FrmLandEinfuegen
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
            btn_Loeschen = new Button();
            btn_EInfuegen = new Button();
            lbx_Laender = new ListBox();
            tbx_Name = new TextBox();
            tbx_Kuerzel = new TextBox();
            lbl_Kuerzel = new Label();
            lbl_Name = new Label();
            SuspendLayout();
            // 
            // btn_Loeschen
            // 
            btn_Loeschen.Location = new Point(69, 166);
            btn_Loeschen.Name = "btn_Loeschen";
            btn_Loeschen.Size = new Size(75, 107);
            btn_Loeschen.TabIndex = 0;
            btn_Loeschen.Text = "-";
            btn_Loeschen.UseVisualStyleBackColor = true;
            btn_Loeschen.Click += btn_Loeschen_Click;
            // 
            // btn_EInfuegen
            // 
            btn_EInfuegen.Location = new Point(161, 166);
            btn_EInfuegen.Name = "btn_EInfuegen";
            btn_EInfuegen.Size = new Size(75, 107);
            btn_EInfuegen.TabIndex = 1;
            btn_EInfuegen.Text = "+";
            btn_EInfuegen.UseVisualStyleBackColor = true;
            btn_EInfuegen.Click += btn_EInfuegen_Click;
            // 
            // lbx_Laender
            // 
            lbx_Laender.FormattingEnabled = true;
            lbx_Laender.ItemHeight = 15;
            lbx_Laender.Location = new Point(12, 66);
            lbx_Laender.Name = "lbx_Laender";
            lbx_Laender.Size = new Size(308, 94);
            lbx_Laender.TabIndex = 2;
            // 
            // tbx_Name
            // 
            tbx_Name.Location = new Point(326, 76);
            tbx_Name.Name = "tbx_Name";
            tbx_Name.Size = new Size(100, 23);
            tbx_Name.TabIndex = 3;
            // 
            // tbx_Kuerzel
            // 
            tbx_Kuerzel.Location = new Point(326, 163);
            tbx_Kuerzel.Name = "tbx_Kuerzel";
            tbx_Kuerzel.Size = new Size(100, 23);
            tbx_Kuerzel.TabIndex = 4;
            // 
            // lbl_Kuerzel
            // 
            lbl_Kuerzel.AutoSize = true;
            lbl_Kuerzel.Location = new Point(326, 145);
            lbl_Kuerzel.Name = "lbl_Kuerzel";
            lbl_Kuerzel.Size = new Size(39, 15);
            lbl_Kuerzel.TabIndex = 5;
            lbl_Kuerzel.Text = "Kürzel";
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Location = new Point(326, 58);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(39, 15);
            lbl_Name.TabIndex = 6;
            lbl_Name.Text = "Name";
            // 
            // FrmLandEinfuegen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 450);
            Controls.Add(lbl_Name);
            Controls.Add(lbl_Kuerzel);
            Controls.Add(tbx_Kuerzel);
            Controls.Add(tbx_Name);
            Controls.Add(lbx_Laender);
            Controls.Add(btn_EInfuegen);
            Controls.Add(btn_Loeschen);
            Name = "FrmLandEinfuegen";
            Text = "FrmLandEinfuegen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Loeschen;
        private Button btn_EInfuegen;
        private ListBox lbx_Laender;
        private TextBox tbx_Name;
        private TextBox tbx_Kuerzel;
        private Label lbl_Kuerzel;
        private Label lbl_Name;
    }
}