using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadaciSvanTipuric
{
    public partial class DateTimePickerKontrola : Form
    {
        public DateTimePickerKontrola()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            DateTime dt1 = dateTimePicker1.Value;
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Vas datum leta je:\n");
            sb1.Append(dt1.ToShortDateString() + "\n");
            // objektu klase DateTime, dt2, dodjeljuje se vrijednost
            // koju je korisnik izabrao u kontroli za vrijeme
            DateTime dt2 = dateTimePicker2.Value;
            sb1.Append("Vase vrijeme polaska je:\n");
            sb1.Append(dt2.ToShortTimeString());
            // ispis kreiranog stringa u richText box-u
            richTextBox1.AppendText(sb1.ToString());


        }
    }
}
