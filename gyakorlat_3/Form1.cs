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
            //EZ AZ ELS� K�T FUNKCI�HOZ KELLETT(szorz�t�bla plusz funkci�kkal)
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    SzinezodoGomb uj = new SzinezodoGomb(); //oszt�lyok helye a 'Program.cs' k�dsorban tal�lhat�
                    uj.Width = 100;
                    uj.Height = 50;

                    uj.Left = i * 110;
                    uj.Top = j * 55;

                    uj.Text = (i *j).ToString();

                    Controls.Add(uj);
                }
            }
            */
            //HARMADIK FELADATHOZ KELL(sz�mol�k gobokk�nt)
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