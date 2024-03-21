using System.Diagnostics.Metrics;

namespace Snake_Game
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;
        int irány_x = 1;
        int irány_y = 0;
        int lepesszam;
        int hossz = 1;
        List<KigyoElem> kigyo = new List<KigyoElem>();
        public Form1()
        {
            InitializeComponent();
            KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irány_y = -1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                irány_y = 1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                irány_y = 0;
                irány_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                irány_y = 0;
                irány_x = 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            /*Thread thread1 = new Thread(() => timer1_Tick());
            Thread thread2 = new Thread(() => MeregTimer_Tick());
            Thread thread3 = new Thread(() => EtelTimer_Tick());
            thread1.Start();

            thread1.Start();
            thread2.Start();*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lepesszam++;

            fej_x += irány_x * KigyoElem.Meret;
            fej_y += irány_y * KigyoElem.Meret;


            foreach (object item in Controls)
            {
                if (item is KigyoElem)
                {
                    KigyoElem ke = (KigyoElem)item;

                    if (ke.Top == fej_y && ke.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }

            KigyoElem k = new();
            k.Top = fej_y;
            k.Left = fej_x;
            kigyo.Add(k);
            Controls.Add(k);
            if (lepesszam % 2 == 0)
            {
                k.BackColor = Color.Yellow;
            }

            if (kigyo.Count > hossz)
            {
                KigyoElem levagando = kigyo[0];
                kigyo.RemoveAt(0);
                Controls.Remove(levagando);
            }
        }

        private void MeregTimer_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Mereg mereg = new Mereg();
            mereg.Top = rnd.Next(0,ClientRectangle.Height);
            mereg.Left = rnd.Next(0, ClientRectangle.Width);
            Controls.Add(mereg);
            timer1.Start();
        }

        private void EtelTimer_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Etel etel = new Etel();
            etel.Top = rnd.Next(0, ClientRectangle.Height);
            etel.Left = rnd.Next(0, ClientRectangle.Width);
            Controls.Add(etel);
            timer1.Start();
        }
    }
}
