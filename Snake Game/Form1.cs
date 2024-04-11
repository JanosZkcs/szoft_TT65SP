using System.Diagnostics;
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
        int eltelt;
        int hossz = 1;
        List<KigyoElem> kigyo = new List<KigyoElem>();
            Random rnd = new Random();
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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lepesszam++;
            eltelt += 500;

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

            if (eltelt % 5000 == 0)
            {
                KajaSpawn();
            }
        }

        private void KajaSpawn()
        {
            Etel etel = new();
            etel.Top = rnd.Next(0,ClientRectangle.Height);
            etel.Left = rnd.Next(0,ClientRectangle.Width);
            Controls.Add(etel);
        }
    }
}
