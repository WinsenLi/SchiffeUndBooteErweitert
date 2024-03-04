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
            btn_Land_Einfuegen = new Button();
            btn_Boote = new Button();
            btn_Besitzer = new Button();
            SuspendLayout();
            // 
            // btn_Land_Einfuegen
            // 
            btn_Land_Einfuegen.Location = new Point(132, 171);
            btn_Land_Einfuegen.Name = "btn_Land_Einfuegen";
            btn_Land_Einfuegen.Size = new Size(108, 51);
            btn_Land_Einfuegen.TabIndex = 0;
            btn_Land_Einfuegen.Text = "Land einfügen";
            btn_Land_Einfuegen.UseVisualStyleBackColor = true;
            btn_Land_Einfuegen.Click += btn_Land_Einfuegen_Click;
            // 
            // btn_Boote
            // 
            btn_Boote.Location = new Point(307, 171);
            btn_Boote.Name = "btn_Boote";
            btn_Boote.Size = new Size(121, 51);
            btn_Boote.TabIndex = 1;
            btn_Boote.Text = "Boote";
            btn_Boote.UseVisualStyleBackColor = true;
            btn_Boote.Click += btn_Boote_Click;
            // 
            // btn_Besitzer
            // 
            btn_Besitzer.Location = new Point(456, 171);
            btn_Besitzer.Name = "btn_Besitzer";
            btn_Besitzer.Size = new Size(121, 51);
            btn_Besitzer.TabIndex = 2;
            btn_Besitzer.Text = "Besitzer";
            btn_Besitzer.UseVisualStyleBackColor = true;
            btn_Besitzer.Click += btn_Besitzer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Besitzer);
            Controls.Add(btn_Boote);
            Controls.Add(btn_Land_Einfuegen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Land_Einfuegen;
        private Button btn_Boote;
        private Button btn_Besitzer;
    }
}
