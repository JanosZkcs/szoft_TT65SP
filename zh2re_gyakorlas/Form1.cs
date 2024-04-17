using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace zh2re_gyakorlas
{
    public partial class Form1 : Form
    {
        BindingList<Futok> futok = new BindingList<Futok>();
        public Form1()
        {
            InitializeComponent(); ////dataGridView1.DataSource = futok;!!!!BAD
            futokBindingSource.DataSource = futok;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("adatok.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var t = csv.GetRecords<Futok>();

                foreach (var item in t)
                {
                    futok.Add(item);
                }

                sr.Close(); //KELL
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);
                    csv.WriteRecords(futok);


                    streamWriter.Close(); //nagyon fontos
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (futokBindingSource.Current == null) return;

            if (MessageBox.Show("Törlöd?", "Elem törlése", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                futokBindingSource.RemoveCurrent();
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            if (form2.ShowDialog() == DialogResult.OK)
            {
                futokBindingSource.Add(form2.ujFuto);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double osszeg = 0;
            int db = 0;
            
            foreach (var item in futok)
            {
                if (item.Nemzetiseg == "USA")
                {
                    osszeg += item.EredmenyPerc;
                    db++;
                }
            }

            double Avg = osszeg / db;
        }
    }
}
