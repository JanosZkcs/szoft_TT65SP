﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Snake_Game
{
    internal class Mereg : UserControl
    {
        public static int Meret = 20;
        public Mereg()
        {
            Width = Mereg.Meret;
            Height = Mereg.Meret;
            BackColor = Color.Red;
        }
    }
    internal class Etel : UserControl
    {
        public static int Meret = 20;
        public Etel()
        {
            Width = Mereg.Meret;
            Height = Mereg.Meret;
            BackColor= Color.Red;
        }
    }
}
