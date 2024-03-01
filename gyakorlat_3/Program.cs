using Microsoft.Win32.SafeHandles;

namespace gyakorlat_3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
    public class VillogoGomb : Button
    {
        public VillogoGomb()
        {
            MouseEnter += VillogoGomb_MouseEnter;
            MouseLeave += VillogoGomb_MouseLeave;
        }

        private void VillogoGomb_MouseLeave(object sender, EventArgs e)
        {
            BackColor = SystemColors.ButtonFace;
        }

        private void VillogoGomb_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }
    }

    public class SzinezodoGomb : Button
    {
        public SzinezodoGomb()
        {
            Width = 20;
            Height = 20;
            MouseClick += SzinezodoGomb_MouseClick;
        }

        private void SzinezodoGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            this.BackColor = Color.Fuchsia;
        }
    }

    public class SzamoloGomb : Button
    {
        int szam = 1;
        public SzamoloGomb()
        {
            Width = 20;
            Height = 20;
            Text = szam.ToString();
            MouseClick += SzamoloGomb_MouseClick;
        }

        private void SzamoloGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            if (szam < 5)
            {
                szam++;
            }
            else
            {
                szam = 1;
            }
            Text = szam.ToString();
        }
    }
    public class VeletlenGomb : Button
    {
        Random random = new Random();
        public VeletlenGomb()
        {
            Width = random.Next(50 , 500); //Random látható értékeket adtam
            Height = random.Next(50, 500);
            this.BackColor = Color.FromArgb(RGBKod(), RGBKod(), RGBKod());
        }
        private int RGBKod()
        {
            int szam = random.Next(0, 256);
            return szam;
        }
    }
}