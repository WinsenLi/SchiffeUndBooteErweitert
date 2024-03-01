using SchiffeUndBoote;
using System.Windows.Forms;

namespace FrmSchiffeUndBoote
{
    public partial class Form1 : Form
    {
        List<Land> landListe = new List<Land>();



        public Form1()
        {
            InitializeComponent();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Land_Plus_Click(object sender, EventArgs e)
        {
            if (tbx_Land_Name.Text != null && tbx_Land_Kuerzel.Text != null)
            {
                Land l = new Land(tbx_Land_Name.Text, tbx_Land_Kuerzel.Text);
                landListe.Add(l);
                lbx_Länder.DataSource = landListe;
                lbx_Länder.DisplayMember = "ToString";

                lbx_Länder.Refresh();

            }

        }

        private void lbx_Länder_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
