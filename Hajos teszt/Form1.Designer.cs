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
            Harmadik = new ValaszGomb();
            Masodik = new ValaszGomb();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            KovetkezoB = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            Elso.Size = new Size(371, 73);
            Elso.TabIndex = 0;
            // 
            // Harmadik
            // 
            Harmadik.BackColor = Color.LightGray;
            Harmadik.BorderStyle = BorderStyle.None;
            Harmadik.Location = new Point(34, 291);
            Harmadik.Multiline = true;
            Harmadik.Name = "Harmadik";
            Harmadik.ReadOnly = true;
            Harmadik.Size = new Size(371, 79);
            Harmadik.TabIndex = 2;
            // 
            // Masodik
            // 
            Masodik.BackColor = Color.LightGray;
            Masodik.BorderStyle = BorderStyle.None;
            Masodik.Location = new Point(34, 204);
            Masodik.Multiline = true;
            Masodik.Name = "Masodik";
            Masodik.ReadOnly = true;
            Masodik.Size = new Size(371, 81);
            Masodik.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 77);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(411, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(377, 245);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // KovetkezoB
            // 
            KovetkezoB.BackColor = SystemColors.ControlLight;
            KovetkezoB.Location = new Point(302, 425);
            KovetkezoB.Name = "KovetkezoB";
            KovetkezoB.Size = new Size(200, 72);
            KovetkezoB.TabIndex = 6;
            KovetkezoB.Text = "Következő";
            KovetkezoB.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 537);
            Controls.Add(KovetkezoB);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(Masodik);
            Controls.Add(Harmadik);
            Controls.Add(Elso);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ValaszGomb Elso;
        private ValaszGomb Harmadik;
        private ValaszGomb Masodik;
        private Label label1;
        private PictureBox pictureBox1;
        private Button KovetkezoB;
    }
}
