
namespace LetsMovie.FormMenu
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (CloseCancel() == false)
            {
                e.Cancel = true;
            };
        }

        public static bool CloseCancel()
        {
            const string message = "Quer mesmo sair?";
            const string caption = "Fechar";
            var result = MessageBox.Show (message, caption, MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }
        private void btnSair_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmCadastrarMenu cadastrar = new frmCadastrarMenu();
            cadastrar.ShowDialog();
            this.Visible = true;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmSobre cadastrar = new frmSobre();
            cadastrar.ShowDialog();
            this.Visible = true;
        }

        private void btnTelaInicial_Click(object sender, EventArgs e)
        {

        }
    }
}
