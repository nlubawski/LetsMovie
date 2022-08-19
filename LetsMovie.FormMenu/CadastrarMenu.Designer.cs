namespace LetsMovie.FormMenu
{
    partial class frmCadastrarMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnTelaInicial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(651, 25);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnSobre
            // 
            this.btnSobre.Location = new System.Drawing.Point(337, 25);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(75, 23);
            this.btnSobre.TabIndex = 4;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = true;
            // 
            // btnTelaInicial
            // 
            this.btnTelaInicial.Location = new System.Drawing.Point(50, 25);
            this.btnTelaInicial.Name = "btnTelaInicial";
            this.btnTelaInicial.Size = new System.Drawing.Size(75, 23);
            this.btnTelaInicial.TabIndex = 3;
            this.btnTelaInicial.Text = "Tela Inicial";
            this.btnTelaInicial.UseVisualStyleBackColor = true;
            // 
            // frmCadastrarMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.btnTelaInicial);
            this.Name = "frmCadastrarMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSair;
        private Button btnSobre;
        private Button btnTelaInicial;
    }
}