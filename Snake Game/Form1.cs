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

            fej_x += irány_x * KigyoElem.Meret;
            fej_y += irány_y * KigyoElem.Meret;


            foreach (KigyoElem item in Controls)
            {
                if (item.Top == fej_y && item.Left == fej_x)
                {
                    timer1.Enabled = false;
                    return;
                }
            }

            KigyoElem k = new();
            k.Top = fej_y;
            k.Left = fej_x;
            Controls.Add(k);
            if (lepesszam % 2 == 0) 
            { 
                k.BackColor = Color.Yellow; 
            }

            if (Controls.Count > hossz)
            {
                Controls.RemoveAt(0);
            }
        }
    }
}
