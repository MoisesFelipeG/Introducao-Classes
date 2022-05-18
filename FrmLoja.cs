using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes_Nome
{
    public partial class FrmLoja : Form
    {
        public FrmLoja()
        {
            InitializeComponent();
        }

        private void formPrefeitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrefeito frm = new FrmPrefeito(); //INDICO QUAL FORM SERÁ ABERTO
            this.Hide(); //fechar atual
            frm.ShowDialog();
        }

        private void formLojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLoja frm = new FrmLoja(); //INDICO QUAL FORM SERÁ ABERTO
            this.Hide(); //fechar atual
            frm.ShowDialog();
        }

        private void formAlimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlimento frm = new FrmAlimento(); //INDICO QUAL FORM SERÁ ABERTO
            this.Hide(); //fechar atual
            frm.ShowDialog();
        }
    }
}
