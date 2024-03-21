using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Snake_Game
{
    internal class Mereg : Button
    {
        public static int Meret = 20;
        public Mereg()
        {
            Width = Mereg.Meret;
            Height = Mereg.Meret;
            Text = "\U0001F571";
            this.Enabled = false;
        }
    }
    internal class Etel : Button
    {
        public static int Meret = 20;
        public Etel()
        {
            Width = Mereg.Meret;
            Height = Mereg.Meret;
            Text = "\U0001F34E";
            this.Enabled = false;
        }
    }
}
