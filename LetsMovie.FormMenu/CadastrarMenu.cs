using LetsMovie.Infra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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

        private void frmCadastrarMenu_Load(object sender, EventArgs e)
        {

        }

        private void frmCadastrarMenu_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox1 = new ListBox();
            // Set the size and location of the ListBox.
            listBox1.Size = new System.Drawing.Size(200, 100);
            listBox1.Location = new System.Drawing.Point(10, 10);
            // Add the ListBox to the form.
            this.Controls.Add(listBox1);
            // Set the ListBox to display items in multiple columns.
            listBox1.MultiColumn = true;
            // Set the selection mode to multiple and extended.
            listBox1.SelectionMode = SelectionMode.MultiExtended;

            // Shutdown the painting of the ListBox as items are added.
            listBox1.BeginUpdate();
            // Loop through and add 50 items to the ListBox.
            for (int x = 0; x < 50; x++)
            {
                listBox1.Items.Add("arroz " + x.ToString());
            }
            // Allow the ListBox to repaint and display the new items.
            listBox1.EndUpdate();

            // Select three items from the ListBox.
            listBox1.SetSelected(1, true);
            listBox1.SetSelected(3, true);
            listBox1.SetSelected(5, true);

            Debug.WriteLine(listBox1.SelectedItems[0].ToString());
        }



        //private void btnSair_Click(object sender, EventArgs e)
        //{

        //}
    }
}
