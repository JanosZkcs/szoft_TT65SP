using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Elem> lista = new List<Elem>();
            for (int i = 0; i < 10; i++)
            {
                /*Button b = new Button();
                b.Top = i * 30;
                b.Text = Fibszam(i).ToString();
                Controls.Add(b);*/
                Elem elem = new Elem();
                elem.Sorszam = i;
                elem.Ertek = Fibszam(i);
                lista.Add(elem);
            }
            dataGridView1.DataSource = lista;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public int Fibszam(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            return Fibszam(n - 1) + Fibszam(n - 2);
        }
    }
    class Elem
    {
        public int Sorszam { get; set; }
        public long Ertek { get; set; }
    }
}
