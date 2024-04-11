namespace Adatkotes
{
    partial class FormCountryData
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxName = new TextBox();
            textBoxPop = new TextBox();
            textBoxArea = new TextBox();
            ButtonOk = new Button();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 22);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Country Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 103);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "Population";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 198);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 2;
            label3.Text = "Area in km2";
            // 
            // textBoxName
            // 
            textBoxName.DataBindings.Add(new Binding("Text", bindingSource1, "Name", true));
            textBoxName.Location = new Point(20, 59);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(308, 27);
            textBoxName.TabIndex = 3;
            // 
            // textBoxPop
            // 
            textBoxPop.DataBindings.Add(new Binding("Text", bindingSource1, "Population", true));
            textBoxPop.Location = new Point(25, 147);
            textBoxPop.Name = "textBoxPop";
            textBoxPop.Size = new Size(308, 27);
            textBoxPop.TabIndex = 4;
            // 
            // textBoxArea
            // 
            textBoxArea.DataBindings.Add(new Binding("Text", bindingSource1, "AreaInSquareKm", true));
            textBoxArea.Location = new Point(25, 242);
            textBoxArea.Name = "textBoxArea";
            textBoxArea.Size = new Size(308, 27);
            textBoxArea.TabIndex = 5;
            // 
            // ButtonOk
            // 
            ButtonOk.Location = new Point(234, 322);
            ButtonOk.Name = "ButtonOk";
            ButtonOk.Size = new Size(94, 29);
            ButtonOk.TabIndex = 6;
            ButtonOk.Text = "&OK";
            ButtonOk.UseVisualStyleBackColor = true;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(CountryData);
            // 
            // FormCountryData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 363);
            Controls.Add(ButtonOk);
            Controls.Add(textBoxArea);
            Controls.Add(textBoxPop);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCountryData";
            Text = "FormCountryData";
            Load += FormCountryData_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxName;
        private TextBox textBoxPop;
        private TextBox textBoxArea;
        private Button ButtonOk;
        private BindingSource bindingSource1;
    }
}