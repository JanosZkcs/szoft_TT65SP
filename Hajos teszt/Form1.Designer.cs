namespace Hajos_teszt
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
            Elso = new ValaszGomb();
            Negyedik = new ValaszGomb();
            Harmadik = new ValaszGomb();
            Masodik = new ValaszGomb();
            SuspendLayout();
            // 
            // Elso
            // 
            Elso.BackColor = Color.LightGray;
            Elso.BorderStyle = BorderStyle.None;
            Elso.Location = new Point(34, 125);
            Elso.Multiline = true;
            Elso.Name = "Elso";
            Elso.ReadOnly = true;
            Elso.Size = new Size(334, 34);
            Elso.TabIndex = 0;
            // 
            // Negyedik
            // 
            Negyedik.BackColor = Color.LightGray;
            Negyedik.BorderStyle = BorderStyle.None;
            Negyedik.Location = new Point(391, 181);
            Negyedik.Multiline = true;
            Negyedik.Name = "Negyedik";
            Negyedik.ReadOnly = true;
            Negyedik.Size = new Size(346, 34);
            Negyedik.TabIndex = 1;
            // 
            // Harmadik
            // 
            Harmadik.BackColor = Color.LightGray;
            Harmadik.BorderStyle = BorderStyle.None;
            Harmadik.Location = new Point(34, 181);
            Harmadik.Multiline = true;
            Harmadik.Name = "Harmadik";
            Harmadik.ReadOnly = true;
            Harmadik.Size = new Size(334, 34);
            Harmadik.TabIndex = 2;
            // 
            // Masodik
            // 
            Masodik.BackColor = Color.LightGray;
            Masodik.BorderStyle = BorderStyle.None;
            Masodik.Location = new Point(391, 125);
            Masodik.Multiline = true;
            Masodik.Name = "Masodik";
            Masodik.ReadOnly = true;
            Masodik.Size = new Size(346, 34);
            Masodik.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Masodik);
            Controls.Add(Harmadik);
            Controls.Add(Negyedik);
            Controls.Add(Elso);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ValaszGomb Elso;
        private ValaszGomb Negyedik;
        private ValaszGomb Harmadik;
        private ValaszGomb Masodik;
    }
}
