using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsAppLogin.Termek;

namespace WindowsFormsAppLogin
{
    public partial class FormTermek : Form
    {
        private List<Megrendeles> megrendelesek = new List<Megrendeles>();
        public FormTermek()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(megrendelesiSzamTextBox.Text, out int megrendelesiSzam) &&
                !string.IsNullOrEmpty(termekNevTextBox.Text) &&
                int.TryParse(eladottMennyisegTextBox.Text, out int eladottMennyiseg))
            {
                Megrendeles megrendeles = new Megrendeles
                {
                    MegrendelesiSzam = megrendelesiSzam,
                    TermekNev = termekNevTextBox.Text,
                    EladottMennyiseg = eladottMennyiseg
                };

                megrendelesek.Add(megrendeles);

                // Itt hozzáadhatod a tábla frissítését vagy más kezelési logikát.

                // Tisztítsd az űrlapot az új adatok felvétele után.
                megrendelesiSzamTextBox.Clear();
                termekNevTextBox.Clear();
                eladottMennyisegTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Hibás adatok. Kérlek ellenőrizd a megadott értékeket.");
            }
        }
    }
}
