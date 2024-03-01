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
            /*
            //Gombok főátlós és alatta
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
            }*/
            //6.feladat: karácsonyfa
            int tolas = ClientRectangle.Width / 2;
            for (int sor = 0; sor <= 11; sor++)
            {
                for (int oszlop = 0; oszlop <= 11; oszlop++)
                {
                    if (oszlop <= sor)
                    {
                        if (sor < 10)
                        {
                            Button gomb = new Button();
                            gomb.BackColor = Color.Green;
                            gomb.Top = sor * 20;
                            gomb.Left = tolas + oszlop * 20;
                            gomb.Width = 20;
                            gomb.Height = 20;
                            Controls.Add(gomb);
                        }
                        else
                        {
                            Button talp = new Button();
                            talp.BackColor = Color.Brown;
                            talp.Width = 20;
                            talp.Height = 20;
                            talp.Top = sor * 20;
                            talp.Left = ClientRectangle.Width / 2;
                            Controls.Add(talp);
                        }
                    }
                }
                tolas -= 10;
            }
        }
    }
}
