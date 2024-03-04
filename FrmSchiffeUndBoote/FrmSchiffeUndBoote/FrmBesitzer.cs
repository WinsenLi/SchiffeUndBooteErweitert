using SchiffeUndBoote;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmSchiffeUndBoote
{
    public partial class FrmBesitzer : Form
    {
        List<Land> landListe;

        public FrmBesitzer()
        {
            InitializeComponent();
        }

        public FrmBesitzer(List<Land> landListe):this()
        {
            this.landListe = landListe;
        }

        private void Btn_Plus_Click(object sender, EventArgs e)
        {
            
            if (tbx_Vorname.Text != null && tbx_Nachname.Text != null && tbx_ort.Text != null && tbx_plz.Text != null && tbx_strasse.Text != null && tbx_land.Text != null && tbx_hausnummer.Text != null)
            {


                Besitzer b = new Besitzer(tbx_Vorname.Text, tbx_Nachname.Text, tbx_strasse.Text, tbx_hausnummer.Text, tbx_plz.Text, tbx_ort.Text, landListe.Find(land => land.Name.Equals(tbx_land.Text, StringComparison.OrdinalIgnoreCase)));
                string s = l.Name + ", " + l.Kuerzel;

                if (!lbx_Laender.Items.Contains(s))
                {
                    lbx_Laender.Items.Add(s);
                }

            }
        }
    }
}
