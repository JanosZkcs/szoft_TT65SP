using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zh2re_gyakorlas
{
    public partial class Form2 : Form
    {
        public Futok ujFuto = new Futok();
        public Form2()
        {
            InitializeComponent();
            futokBindingSource.DataSource = ujFuto;
        }

        private void Form2_Load(object sender, EventArgs e)
        { 
        }
    }
}
