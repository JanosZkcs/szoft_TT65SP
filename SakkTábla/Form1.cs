namespace SakkTábla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int tavolsag = 50; //feltételezés: első blokk fehér
            int h = 50;
            for (int sor = 1; sor <= 8; sor++)
            {
                for(int oszlop = 1; oszlop <= 8; oszlop++)
                {
                    if (oszlop % 2 == 0 && sor % 2 == 1) { 
                        Button b = new Button();
                        b.BackColor = Color.Black;
                        b.Width = 50;
                        b.Height = 50;
                        b.Left = tavolsag * oszlop;
                        b.Top = h;
                        Controls.Add(b);
                    }
                    else if(oszlop % 2 == 1 && sor % 2 == 0) { 
                        Button b = new Button();
                        b.BackColor= Color.Black;
                        b.Width = 50;
                        b.Height = 50;
                        b.Left = tavolsag * oszlop;
                        b.Top= h;
                        Controls.Add(b);
                    }
                    else
                    {
                        Button b = new Button();
                        b.BackColor = Color.White;
                        b.Width = 50;
                        b.Height = 50;
                        b.Left = tavolsag * oszlop;
                        b.Top = h;
                        Controls.Add(b);
                    }
                }
                h += 50;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
