namespace LetsMovie.FormMenu
{
    partial class frmUpdateMovie
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
            this.labTitle = new System.Windows.Forms.Label();
            this.labUpdTitulo = new System.Windows.Forms.Label();
            this.lblNovoTitulo = new System.Windows.Forms.Label();
            this.textBoxUpdate = new System.Windows.Forms.TextBox();
            this.labAtualizar = new System.Windows.Forms.Label();
            this.labAtualizadoOk = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnTelaInicial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labTitle.Location = new System.Drawing.Point(262, 41);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(307, 30);
            this.labTitle.TabIndex = 1;
            this.labTitle.Text = "ATUALIZAR TÍTULO - FILMES";
            // 
            // labUpdTitulo
            // 
            this.labUpdTitulo.AutoSize = true;
            this.labUpdTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labUpdTitulo.Location = new System.Drawing.Point(269, 110);
            this.labUpdTitulo.Name = "labUpdTitulo";
            this.labUpdTitulo.Size = new System.Drawing.Size(283, 25);
            this.labUpdTitulo.TabIndex = 3;
            this.labUpdTitulo.Text = "Selecione o Título a ser atualizado:";
            this.labUpdTitulo.Click += new System.EventHandler(this.labUpdTitulo_Click);
            // 
            // lblNovoTitulo
            // 
            this.lblNovoTitulo.AutoSize = true;
            this.lblNovoTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNovoTitulo.Location = new System.Drawing.Point(315, 289);
            this.lblNovoTitulo.Name = "lblNovoTitulo";
            this.lblNovoTitulo.Size = new System.Drawing.Size(174, 25);
            this.lblNovoTitulo.TabIndex = 5;
            this.lblNovoTitulo.Text = "Digite o novo Título:";
            this.lblNovoTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxUpdate
            // 
            this.textBoxUpdate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUpdate.Location = new System.Drawing.Point(291, 322);
            this.textBoxUpdate.Name = "textBoxUpdate";
            this.textBoxUpdate.Size = new System.Drawing.Size(233, 33);
            this.textBoxUpdate.TabIndex = 4;
            this.textBoxUpdate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labAtualizar
            // 
            this.labAtualizar.AutoSize = true;
            this.labAtualizar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labAtualizar.Location = new System.Drawing.Point(249, 385);
            this.labAtualizar.Name = "labAtualizar";
            this.labAtualizar.Size = new System.Drawing.Size(118, 25);
            this.labAtualizar.TabIndex = 6;
            this.labAtualizar.Text = "Atualizando...";
            // 
            // labAtualizadoOk
            // 
            this.labAtualizadoOk.AutoSize = true;
            this.labAtualizadoOk.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labAtualizadoOk.Location = new System.Drawing.Point(425, 385);
            this.labAtualizadoOk.Name = "labAtualizadoOk";
            this.labAtualizadoOk.Size = new System.Drawing.Size(208, 25);
            this.labAtualizadoOk.TabIndex = 7;
            this.labAtualizadoOk.Text = "Atualizado com sucesso!";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(547, 329);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(287, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(240, 110);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(682, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnTelaInicial
            // 
            this.btnTelaInicial.Location = new System.Drawing.Point(81, 12);
            this.btnTelaInicial.Name = "btnTelaInicial";
            this.btnTelaInicial.Size = new System.Drawing.Size(75, 23);
            this.btnTelaInicial.TabIndex = 11;
            this.btnTelaInicial.Text = "Tela Inicial";
            this.btnTelaInicial.UseVisualStyleBackColor = true;
            this.btnTelaInicial.Click += new System.EventHandler(this.btnTelaInicial_Click);
            // 
            // frmUpdateMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 438);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnTelaInicial);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.labAtualizadoOk);
            this.Controls.Add(this.labAtualizar);
            this.Controls.Add(this.lblNovoTitulo);
            this.Controls.Add(this.textBoxUpdate);
            this.Controls.Add(this.labUpdTitulo);
            this.Controls.Add(this.labTitle);
            this.Name = "frmUpdateMovie";
            this.Text = "UpdateMovieForm";
            this.Load += new System.EventHandler(this.frmUpdateMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labTitle;
        private Label labUpdTitulo;
        private Label lblNovoTitulo;
        private TextBox textBoxUpdate;
        private Label labAtualizar;
        private Label labAtualizadoOk;
        private Button btnEnviar;
        private DataGridView dataGridView1;
        private Button btnVoltar;
        private Button btnTelaInicial;
    }
}