namespace LetsMovie.FormMenu
{
    partial class frmUpdateDoc
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnTelaInicial = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.labAtualizadoOk = new System.Windows.Forms.Label();
            this.labAtualizar = new System.Windows.Forms.Label();
            this.lblNovoTitulo = new System.Windows.Forms.Label();
            this.textBoxUpdate = new System.Windows.Forms.TextBox();
            this.labUpdTitulo = new System.Windows.Forms.Label();
            this.frmUpdateSerie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(663, 19);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 30;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnTelaInicial
            // 
            this.btnTelaInicial.Location = new System.Drawing.Point(62, 19);
            this.btnTelaInicial.Name = "btnTelaInicial";
            this.btnTelaInicial.Size = new System.Drawing.Size(75, 23);
            this.btnTelaInicial.TabIndex = 29;
            this.btnTelaInicial.Text = "Tela Inicial";
            this.btnTelaInicial.UseVisualStyleBackColor = true;
            this.btnTelaInicial.Click += new System.EventHandler(this.btnTelaInicial_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(252, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(240, 110);
            this.dataGridView1.TabIndex = 28;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(536, 339);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 27;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // labAtualizadoOk
            // 
            this.labAtualizadoOk.AutoSize = true;
            this.labAtualizadoOk.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labAtualizadoOk.Location = new System.Drawing.Point(390, 407);
            this.labAtualizadoOk.Name = "labAtualizadoOk";
            this.labAtualizadoOk.Size = new System.Drawing.Size(208, 25);
            this.labAtualizadoOk.TabIndex = 26;
            this.labAtualizadoOk.Text = "Atualizado com sucesso!";
            // 
            // labAtualizar
            // 
            this.labAtualizar.AutoSize = true;
            this.labAtualizar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labAtualizar.Location = new System.Drawing.Point(214, 407);
            this.labAtualizar.Name = "labAtualizar";
            this.labAtualizar.Size = new System.Drawing.Size(118, 25);
            this.labAtualizar.TabIndex = 25;
            this.labAtualizar.Text = "Atualizando...";
            // 
            // lblNovoTitulo
            // 
            this.lblNovoTitulo.AutoSize = true;
            this.lblNovoTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNovoTitulo.Location = new System.Drawing.Point(280, 299);
            this.lblNovoTitulo.Name = "lblNovoTitulo";
            this.lblNovoTitulo.Size = new System.Drawing.Size(174, 25);
            this.lblNovoTitulo.TabIndex = 24;
            this.lblNovoTitulo.Text = "Digite o novo Título:";
            // 
            // textBoxUpdate
            // 
            this.textBoxUpdate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUpdate.Location = new System.Drawing.Point(256, 332);
            this.textBoxUpdate.Name = "textBoxUpdate";
            this.textBoxUpdate.Size = new System.Drawing.Size(233, 33);
            this.textBoxUpdate.TabIndex = 23;
            // 
            // labUpdTitulo
            // 
            this.labUpdTitulo.AutoSize = true;
            this.labUpdTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labUpdTitulo.Location = new System.Drawing.Point(234, 120);
            this.labUpdTitulo.Name = "labUpdTitulo";
            this.labUpdTitulo.Size = new System.Drawing.Size(283, 25);
            this.labUpdTitulo.TabIndex = 22;
            this.labUpdTitulo.Text = "Selecione o Título a ser atualizado:";
            // 
            // frmUpdateSerie
            // 
            this.frmUpdateSerie.AutoSize = true;
            this.frmUpdateSerie.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.frmUpdateSerie.Location = new System.Drawing.Point(171, 53);
            this.frmUpdateSerie.Name = "frmUpdateSerie";
            this.frmUpdateSerie.Size = new System.Drawing.Size(423, 30);
            this.frmUpdateSerie.TabIndex = 21;
            this.frmUpdateSerie.Text = "ATUALIZAR TÍTULO - DOCUMENTÁRIOS";
            this.frmUpdateSerie.Click += new System.EventHandler(this.frmUpdateSerie_Click);
            // 
            // frmUpdateDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnTelaInicial);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.labAtualizadoOk);
            this.Controls.Add(this.labAtualizar);
            this.Controls.Add(this.lblNovoTitulo);
            this.Controls.Add(this.textBoxUpdate);
            this.Controls.Add(this.labUpdTitulo);
            this.Controls.Add(this.frmUpdateSerie);
            this.Name = "frmUpdateDoc";
            this.Text = "UpdateDoc";
            this.Load += new System.EventHandler(this.frmUpdateDoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnVoltar;
        private Button btnTelaInicial;
        private DataGridView dataGridView1;
        private Button btnEnviar;
        private Label labAtualizadoOk;
        private Label labAtualizar;
        private Label lblNovoTitulo;
        private TextBox textBoxUpdate;
        private Label labUpdTitulo;
        private Label frmUpdateSerie;
    }
}