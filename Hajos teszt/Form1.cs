using System.Windows.Forms;

namespace Hajos_teszt
{
    public partial class Form1 : Form
    {
        List<Kerdes> OsszesKerdes;
        List<Kerdes> AktivKerdesek;
        int AktivKerdes = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AktivKerdesek = new List<Kerdes>();
            OsszesKerdes = KerdesBeolvasas();
            for (int i = 0; i < 7; i++)
            {
                AktivKerdesek.Add(OsszesKerdes[0]);
                OsszesKerdes.RemoveAt(0);
            }
            dataGridView1.DataSource = AktivKerdesek;
        }
        List<Kerdes> KerdesBeolvasas()
        {
            List<Kerdes> lista = new List<Kerdes>();
            StreamReader sr = new StreamReader("C:\\Users\\jzako\\source\\repos\\szoft_TT65SP\\Hajos teszt\\text.txt", true);//Local
            while(!sr.EndOfStream) { 
                string sor = sr.ReadLine() ?? string.Empty;
                string[] tomb = sor.Split('\t');
                if (tomb.Length != 7) continue;

                Kerdes k = new Kerdes();
                k.KerdesSzoveg = tomb[1];
                k.Valasz1 = tomb[2];
                k.Valasz2 = tomb[3];
                k.Valasz3 = tomb[4];
                k.URL = tomb[5];

                int.TryParse(tomb[6], out int jovalasz);

                k.HelyesValasz = jovalasz;

                lista.Add(k);
            }
            sr.Close();
            return lista;
        }
    }
}
