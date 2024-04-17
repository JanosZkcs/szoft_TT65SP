using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kvíz_játék
{
    public partial class KerdesUserControl : UserControl
    {
        public int JoValasz;
        public KerdesUserControl()
        {
            InitializeComponent();
        }

        private void KerdesUserControl_Load(object sender, EventArgs e)
        {
        }

        private void buttonElsoValasz_Click(object sender, EventArgs e)
        {
            buttonElsoValasz.BackColor = Color.Red;
            Szinezd();
        }

        private void buttonMasodikValasz_Click(object sender, EventArgs e)
        {

            buttonMasodikValasz.BackColor = Color.Red;
            Szinezd();
        }

        private void buttonHarmadikValasz_Click(object sender, EventArgs e)
        {
            buttonHarmadikValasz.BackColor = Color.Red;
            Szinezd();
        }

        private void buttonNegyedikValasz_Click(object sender, EventArgs e)
        {
            buttonNegyedikValasz.BackColor = Color.Red;
            Szinezd();
        }
        void Szinezd()
        {
            if (JoValasz == 1) buttonElsoValasz.BackColor = Color.Green;
            if (JoValasz == 2) buttonMasodikValasz.BackColor = Color.Green;
            if (JoValasz == 3) buttonHarmadikValasz.BackColor = Color.Green;
            if (JoValasz == 4) buttonNegyedikValasz.BackColor = Color.Green;
        }
    }
}
