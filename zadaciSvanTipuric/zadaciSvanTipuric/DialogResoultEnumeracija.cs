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
    public partial class DialogResoultEnumeracija : Form
    {
        public DialogResoultEnumeracija()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Odaberite Yes / No / Cancel";
            string naslov = "Naslovna linija Dijaloga za poruke";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            MessageBoxIcon ikona = MessageBoxIcon.Information;
            DialogResult rez = MessageBox.Show(poruka, naslov, buttons, ikona);
            switch (rez)
            {
                case DialogResult.Yes:
                    textBoxRezultat.Text = "Izabrali ste dugme YES";
                    break;
                case DialogResult.No:
                    textBoxRezultat.Text = "Izabrali ste dugme NO";
                    break;
                case DialogResult.Cancel:
                    textBoxRezultat.Text = "Izabrali ste dugme Cancel";
                    break;
            }

        }

        private void textBoxRezultat_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
