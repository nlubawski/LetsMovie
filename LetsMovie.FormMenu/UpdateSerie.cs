﻿using System;
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
    public partial class UpdateSerie : Form
    {
        public UpdateSerie()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmAtualizar atualizar = new frmAtualizar();
            atualizar.ShowDialog();
            this.Visible = true;
        }

        private void btnTelaInicial_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmMenu menuInicial = new frmMenu();
            menuInicial.ShowDialog();
            this.Visible = true;
        }
    }
}