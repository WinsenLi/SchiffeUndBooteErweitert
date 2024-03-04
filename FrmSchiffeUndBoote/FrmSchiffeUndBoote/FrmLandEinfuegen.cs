using SchiffeUndBoote;

namespace FrmSchiffeUndBoote
{
    public partial class FrmLandEinfuegen : Form
    {
        List<Land> landListe = new List<Land>();


        public FrmLandEinfuegen()
        {
            InitializeComponent();

        }


        private void btn_EInfuegen_Click(object sender, EventArgs e)
        {
            if (tbx_Kuerzel.Text != null && tbx_Name.Text != null)
            {
                Land l = new Land(tbx_Name.Text, tbx_Kuerzel.Text);
                string s = l.Name + ", " + l.Kuerzel;

                if (!lbx_Laender.Items.Contains(s))
                {
                    lbx_Laender.Items.Add(s);
                    landListe.Add(l);
                }

            }
        }

        private void btn_Loeschen_Click(object sender, EventArgs e)
        {
            if (lbx_Laender.SelectedItem != null)
            {
                lbx_Laender.Items.Remove(lbx_Laender.SelectedItem);
            }
        }
    }
}
