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
    public partial class frmCadastrarMenu : Form
    {
        public frmCadastrarMenu()
        {
            InitializeComponent();
        }

        private void btnTelaInicial_Click(object sender, EventArgs e)
        {
           // new frmMenu();
           /// this.Hide();

                // chama a consulta de produtos como vc fez
                frmMenu Menu = new frmMenu();
                Menu.ShowDialog();

                // apos chamar o ShowDialog seu form de consulta abrirá ACIMA do FrmPedido, ou seja, este continua aberto atras,
                // portanto voce nao tem que instancia-lo de novo

        }

        private void frmCadastrar_Load(object sender, EventArgs e)
        {

        }

        private void btnTelaInicial_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            frmMenu menu = new frmMenu();
            menu.ShowDialog();
            this.Visible = true;
        }



        //private void btnSair_Click(object sender, EventArgs e)
        //{

        //}
    }
}
