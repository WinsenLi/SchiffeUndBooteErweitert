using SchiffeUndBoote;
using System.Windows.Forms;

namespace FrmSchiffeUndBoote
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();


        }

        private void btn_Land_Einfuegen_Click(object sender, EventArgs e)
        {
            FrmLandEinfuegen frmLandEinfuegen = new FrmLandEinfuegen();
            frmLandEinfuegen.Show();
        }

        private void btn_Boote_Click(object sender, EventArgs e)
        {
            FrmBoote frmBoote = new FrmBoote();
            frmBoote.Show();
        }

        private void btn_Besitzer_Click(object sender, EventArgs e)
        {
            FrmBesitzer frmBesitzer = new FrmBesitzer();
            frmBesitzer.Show();
        }
    }
}
