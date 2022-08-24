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
    public partial class frmDeletarMenu : Form
    {
        public frmDeletarMenu()
        {
            InitializeComponent();
        }

        private void picMovie_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmMenu menuInicial = new frmMenu();
            menuInicial.ShowDialog();
            this.Visible = true;
        }

        private void DeletarMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
