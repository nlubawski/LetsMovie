using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsMovie.FormMenu
{
    public partial class frmAtualizar : Form
    {
        public frmAtualizar()
        {
            InitializeComponent();
        }

        private void btnTelaInicial_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmMenu menu = new frmMenu();
            menu.ShowDialog();
            this.Visible = true;
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmSobre sobre = new frmSobre();
            sobre.ShowDialog();
            this.Visible = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmMenu menuInicial = new frmMenu();
            menuInicial.ShowDialog();
            this.Visible = true;
        }

        private void frmAtualizar_Load(object sender, EventArgs e)
        {

        }

        private void picMovie_Click(object sender, EventArgs e)
        {
        }

        private void picSeries_Click(object sender, EventArgs e)
        {
        }

        private void picDoc_Click(object sender, EventArgs e)
        {
        }
    }
}
