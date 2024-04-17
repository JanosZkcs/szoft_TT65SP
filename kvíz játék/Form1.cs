namespace kvíz_játék
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            int jelenlegiValt = 0;
            InitializeComponent();
            StreamReader sr = new StreamReader("jatek2.txt");
            while (!sr.EndOfStream)
            {
                string kerdes = sr.ReadLine();
                string valasz1 = sr.ReadLine();
                string valasz2 = sr.ReadLine();
                string valasz3 = sr.ReadLine();
                string valasz4 = sr.ReadLine();
                int joValasz = int.Parse(sr.ReadLine());

                KerdesUserControl kru = new KerdesUserControl();
                kru.Top = kru.Height * jelenlegiValt;
                kru.labelKerdes.Text = kerdes;
                kru.buttonElsoValasz.Text = valasz1;
                kru.buttonMasodikValasz.Text = valasz2;
                kru.buttonHarmadikValasz.Text = valasz3;
                kru.buttonNegyedikValasz.Text = valasz4;
                kru.JoValasz = joValasz;

                Controls.Add(kru);

                jelenlegiValt++;
            }
            sr.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
