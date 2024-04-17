namespace zh2re_gyakorlas
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            buttonMegse = new Button();
            buttonOkF2 = new Button();
            textBox1 = new TextBox();
            futokBindingSource = new BindingSource(components);
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Nemzetiség = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)futokBindingSource).BeginInit();
            SuspendLayout();
            // 
            // buttonMegse
            // 
            buttonMegse.Location = new Point(156, 410);
            buttonMegse.Name = "buttonMegse";
            buttonMegse.Size = new Size(94, 29);
            buttonMegse.TabIndex = 0;
            buttonMegse.Text = "Mégse";
            buttonMegse.UseVisualStyleBackColor = true;
            // 
            // buttonOkF2
            // 
            buttonOkF2.Location = new Point(256, 410);
            buttonOkF2.Name = "buttonOkF2";
            buttonOkF2.Size = new Size(94, 29);
            buttonOkF2.TabIndex = 1;
            buttonOkF2.Text = "Ok";
            buttonOkF2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", futokBindingSource, "VersenyzoID", true));
            textBox1.Location = new Point(13, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(337, 27);
            textBox1.TabIndex = 2;
            // 
            // futokBindingSource
            // 
            futokBindingSource.DataSource = typeof(Futok);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", futokBindingSource, "Nev", true));
            textBox2.Location = new Point(13, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(337, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", futokBindingSource, "Nemzetiseg", true));
            textBox3.Location = new Point(12, 191);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(337, 27);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", futokBindingSource, "EredmenyPerc", true));
            textBox4.Location = new Point(13, 272);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(337, 27);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", futokBindingSource, "Kategoria", true));
            textBox5.Location = new Point(12, 344);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(338, 27);
            textBox5.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 16);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 7;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 84);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 8;
            label2.Text = "Név";
            // 
            // Nemzetiség
            // 
            Nemzetiség.AutoSize = true;
            Nemzetiség.Location = new Point(11, 154);
            Nemzetiség.Name = "Nemzetiség";
            Nemzetiség.Size = new Size(88, 20);
            Nemzetiség.TabIndex = 9;
            Nemzetiség.Text = "Nemzetiség";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 233);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 10;
            label4.Text = "Eredmény(perc)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 317);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 11;
            label5.Text = "Kategoria";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Nemzetiség);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonOkF2);
            Controls.Add(buttonMegse);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)futokBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMegse;
        private Button buttonOkF2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label Nemzetiség;
        private Label label4;
        private Label label5;
        private BindingSource futokBindingSource;
    }
}