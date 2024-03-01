namespace gyakorlas_zh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int sor = 0; sor < 10; sor++)
            {
                for(int oszlop = 0; oszlop < 10; oszlop++)
                {
                    if(oszlop <= sor) { 
                        Button gomb = new Button();
                        gomb.BackColor = Color.Fuchsia;
                        gomb.Top = sor * 50;
                        gomb.Left = oszlop * 50;
                        gomb.Width = 50;
                        gomb.Height = 50;
                        Controls.Add(gomb);
                    }
                }
            }
        }
    }
}
