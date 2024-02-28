namespace Pascal_Haromszog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int tolas = (ClientRectangle.Width / 2)-35; //35 = button fele px ben
            for (int i = 0; i <= 10; i++)
            {
                for(int j = 0; j <= 10; j++)
                {
                    if (i >= j)
                    {
                        PascalHszog pascalHszog = new PascalHszog();
                        Button b = new Button();
                        b.Top = i * 75;
                        b.Left = tolas + j * 70;
                        b.Width = 70;
                        b.Height = 50;
                        b.Text = pascalHszog.Binomialis(i, j).ToString();
                        this.Controls.Add(b);
                    }
                }
                tolas -= 35; //soronkénti tolás jobbra lényegében
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    public class PascalHszog
    {
        private int Faktorialis(int n)
        {
            int megoldas = 1;
            for(int i = 1; i <= n; i++)
            {
                megoldas *= i;
            }
            return megoldas;
        }
        public int Binomialis(int n, int k) {
            int megoldas;
            megoldas = Faktorialis(n)/(Faktorialis(k)*Faktorialis(n - k));
            return megoldas;
        }
    }
}
