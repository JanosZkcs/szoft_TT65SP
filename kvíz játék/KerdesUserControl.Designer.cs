namespace kvíz_játék
{
    partial class KerdesUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonElsoValasz = new Button();
            buttonMasodikValasz = new Button();
            buttonHarmadikValasz = new Button();
            buttonNegyedikValasz = new Button();
            labelKerdes = new Label();
            SuspendLayout();
            // 
            // buttonElsoValasz
            // 
            buttonElsoValasz.Location = new Point(3, 61);
            buttonElsoValasz.Name = "buttonElsoValasz";
            buttonElsoValasz.Size = new Size(279, 75);
            buttonElsoValasz.TabIndex = 0;
            buttonElsoValasz.Text = "button";
            buttonElsoValasz.UseVisualStyleBackColor = true;
            buttonElsoValasz.Click += buttonElsoValasz_Click;
            // 
            // buttonMasodikValasz
            // 
            buttonMasodikValasz.Location = new Point(288, 61);
            buttonMasodikValasz.Name = "buttonMasodikValasz";
            buttonMasodikValasz.Size = new Size(322, 75);
            buttonMasodikValasz.TabIndex = 1;
            buttonMasodikValasz.Text = "button2";
            buttonMasodikValasz.UseVisualStyleBackColor = true;
            buttonMasodikValasz.Click += buttonMasodikValasz_Click;
            // 
            // buttonHarmadikValasz
            // 
            buttonHarmadikValasz.Location = new Point(3, 142);
            buttonHarmadikValasz.Name = "buttonHarmadikValasz";
            buttonHarmadikValasz.Size = new Size(279, 71);
            buttonHarmadikValasz.TabIndex = 2;
            buttonHarmadikValasz.Text = "button3";
            buttonHarmadikValasz.UseVisualStyleBackColor = true;
            buttonHarmadikValasz.Click += buttonHarmadikValasz_Click;
            // 
            // buttonNegyedikValasz
            // 
            buttonNegyedikValasz.Location = new Point(288, 142);
            buttonNegyedikValasz.Name = "buttonNegyedikValasz";
            buttonNegyedikValasz.Size = new Size(322, 71);
            buttonNegyedikValasz.TabIndex = 3;
            buttonNegyedikValasz.Text = "button4";
            buttonNegyedikValasz.UseVisualStyleBackColor = true;
            buttonNegyedikValasz.Click += buttonNegyedikValasz_Click;
            // 
            // labelKerdes
            // 
            labelKerdes.AutoSize = true;
            labelKerdes.Location = new Point(12, 21);
            labelKerdes.Name = "labelKerdes";
            labelKerdes.Size = new Size(50, 20);
            labelKerdes.TabIndex = 4;
            labelKerdes.Text = "label1";
            // 
            // KerdesUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelKerdes);
            Controls.Add(buttonNegyedikValasz);
            Controls.Add(buttonHarmadikValasz);
            Controls.Add(buttonMasodikValasz);
            Controls.Add(buttonElsoValasz);
            Name = "KerdesUserControl";
            Size = new Size(624, 234);
            Load += KerdesUserControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button buttonElsoValasz;
        public Button buttonMasodikValasz;
        public Button buttonHarmadikValasz;
        public Button buttonNegyedikValasz;
        public Label labelKerdes;
    }
}
