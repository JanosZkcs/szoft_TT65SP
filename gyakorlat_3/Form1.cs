namespace gyakorlat_3
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
            //EZ AZ ELSÕ KÉT FUNKCIÓHOZ KELLETT(szorzótábla plusz funkciókkal)
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    SzinezodoGomb uj = new SzinezodoGomb(); //osztályok helye a 'Program.cs' kódsorban található
                    uj.Width = 100;
                    uj.Height = 50;

                    uj.Left = i * 110;
                    uj.Top = j * 55;

                    uj.Text = (i *j).ToString();

                    Controls.Add(uj);
                }
            }
            */
            //HARMADIK FELADATHOZ KELL(számolók gobokként)
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    SzamoloGomb uj = new SzamoloGomb();
                    uj.Left = j * 50;
                    uj.Top = i * 50;

                    Controls.Add(uj);
                }
            }
        }
    }
}