namespace LetsMovie.FormMenu
{
    partial class UpdateSerie
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.labAtualizadoOk = new System.Windows.Forms.Label();
            this.labAtualizar = new System.Windows.Forms.Label();
            this.lblNovoTitulo = new System.Windows.Forms.Label();
            this.textBoxUpdate = new System.Windows.Forms.TextBox();
            this.labUpdTitulo = new System.Windows.Forms.Label();
            this.frmUpdateSerie = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnTelaInicial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(257, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(240, 110);
            this.dataGridView1.TabIndex = 18;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(541, 332);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 17;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // labAtualizadoOk
            // 
            this.labAtualizadoOk.AutoSize = true;
            this.labAtualizadoOk.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labAtualizadoOk.Location = new System.Drawing.Point(395, 400);
            this.labAtualizadoOk.Name = "labAtualizadoOk";
            this.labAtualizadoOk.Size = new System.Drawing.Size(208, 25);
            this.labAtualizadoOk.TabIndex = 16;
            this.labAtualizadoOk.Text = "Atualizado com sucesso!";
            // 
            // labAtualizar
            // 
            this.labAtualizar.AutoSize = true;
            this.labAtualizar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labAtualizar.Location = new System.Drawing.Point(219, 400);
            this.labAtualizar.Name = "labAtualizar";
            this.labAtualizar.Size = new System.Drawing.Size(118, 25);
            this.labAtualizar.TabIndex = 15;
            this.labAtualizar.Text = "Atualizando...";
            // 
            // lblNovoTitulo
            // 
            this.lblNovoTitulo.AutoSize = true;
            this.lblNovoTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNovoTitulo.Location = new System.Drawing.Point(285, 292);
            this.lblNovoTitulo.Name = "lblNovoTitulo";
            this.lblNovoTitulo.Size = new System.Drawing.Size(174, 25);
            this.lblNovoTitulo.TabIndex = 14;
            this.lblNovoTitulo.Text = "Digite o novo Título:";
            // 
            // textBoxUpdate
            // 
            this.textBoxUpdate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUpdate.Location = new System.Drawing.Point(261, 325);
            this.textBoxUpdate.Name = "textBoxUpdate";
            this.textBoxUpdate.Size = new System.Drawing.Size(233, 33);
            this.textBoxUpdate.TabIndex = 13;
            // 
            // labUpdTitulo
            // 
            this.labUpdTitulo.AutoSize = true;
            this.labUpdTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labUpdTitulo.Location = new System.Drawing.Point(239, 113);
            this.labUpdTitulo.Name = "labUpdTitulo";
            this.labUpdTitulo.Size = new System.Drawing.Size(283, 25);
            this.labUpdTitulo.TabIndex = 12;
            this.labUpdTitulo.Text = "Selecione o Título a ser atualizado:";
            // 
            // frmUpdateSerie
            // 
            this.frmUpdateSerie.AutoSize = true;
            this.frmUpdateSerie.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.frmUpdateSerie.Location = new System.Drawing.Point(230, 43);
            this.frmUpdateSerie.Name = "frmUpdateSerie";
            this.frmUpdateSerie.Size = new System.Drawing.Size(302, 30);
            this.frmUpdateSerie.TabIndex = 11;
            this.frmUpdateSerie.Text = "ATUALIZAR TÍTULO - SÉRIES";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(658, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 20;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnTelaInicial
            // 
            this.btnTelaInicial.Location = new System.Drawing.Point(57, 12);
            this.btnTelaInicial.Name = "btnTelaInicial";
            this.btnTelaInicial.Size = new System.Drawing.Size(75, 23);
            this.btnTelaInicial.TabIndex = 19;
            this.btnTelaInicial.Text = "Tela Inicial";
            this.btnTelaInicial.UseVisualStyleBackColor = true;
            this.btnTelaInicial.Click += new System.EventHandler(this.btnTelaInicial_Click);
            // 
            // UpdateSerie
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
            this.Name = "UpdateSerie";
            this.Text = "UpdateSerie";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnEnviar;
        private Label labAtualizadoOk;
        private Label labAtualizar;
        private Label lblNovoTitulo;
        private TextBox textBoxUpdate;
        private Label labUpdTitulo;
        private Label frmUpdateSerie;
        private Button btnVoltar;
        private Button btnTelaInicial;
    }
}