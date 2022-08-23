namespace LetsMovie.FormMenu
{
    partial class frmDeleteMovies
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.labDeletadoOk = new System.Windows.Forms.Label();
            this.labDeletar = new System.Windows.Forms.Label();
            this.labUpdTitulo = new System.Windows.Forms.Label();
            this.DeleteMovie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(663, 19);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 40;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnTelaInicial
            // 
            this.btnTelaInicial.Location = new System.Drawing.Point(62, 19);
            this.btnTelaInicial.Name = "btnTelaInicial";
            this.btnTelaInicial.Size = new System.Drawing.Size(75, 23);
            this.btnTelaInicial.TabIndex = 39;
            this.btnTelaInicial.Text = "Tela Inicial";
            this.btnTelaInicial.UseVisualStyleBackColor = true;
            this.btnTelaInicial.Click += new System.EventHandler(this.btnTelaInicial_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(273, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(240, 110);
            this.dataGridView1.TabIndex = 38;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(354, 326);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 37;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // labDeletadoOk
            // 
            this.labDeletadoOk.AutoSize = true;
            this.labDeletadoOk.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labDeletadoOk.Location = new System.Drawing.Point(411, 407);
            this.labDeletadoOk.Name = "labDeletadoOk";
            this.labDeletadoOk.Size = new System.Drawing.Size(196, 25);
            this.labDeletadoOk.TabIndex = 36;
            this.labDeletadoOk.Text = "Deletado com sucesso!";
            // 
            // labDeletar
            // 
            this.labDeletar.AutoSize = true;
            this.labDeletar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labDeletar.Location = new System.Drawing.Point(235, 407);
            this.labDeletar.Name = "labDeletar";
            this.labDeletar.Size = new System.Drawing.Size(106, 25);
            this.labDeletar.TabIndex = 35;
            this.labDeletar.Text = "Deletando...";
            // 
            // labUpdTitulo
            // 
            this.labUpdTitulo.AutoSize = true;
            this.labUpdTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labUpdTitulo.Location = new System.Drawing.Point(255, 138);
            this.labUpdTitulo.Name = "labUpdTitulo";
            this.labUpdTitulo.Size = new System.Drawing.Size(270, 25);
            this.labUpdTitulo.TabIndex = 32;
            this.labUpdTitulo.Text = "Selecione o Filme a ser deletado:";
            // 
            // DeleteMovie
            // 
            this.DeleteMovie.AutoSize = true;
            this.DeleteMovie.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteMovie.Location = new System.Drawing.Point(301, 76);
            this.DeleteMovie.Name = "DeleteMovie";
            this.DeleteMovie.Size = new System.Drawing.Size(172, 30);
            this.DeleteMovie.TabIndex = 31;
            this.DeleteMovie.Text = "DELETAR FILME";
            // 
            // frmDeleteMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnTelaInicial);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.labDeletadoOk);
            this.Controls.Add(this.labDeletar);
            this.Controls.Add(this.labUpdTitulo);
            this.Controls.Add(this.DeleteMovie);
            this.Name = "frmDeleteMovies";
            this.Text = "DeleteMovies";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnVoltar;
        private Button btnTelaInicial;
        private DataGridView dataGridView1;
        private Button btnConfirmar;
        private Label labDeletadoOk;
        private Label labDeletar;
        private Label labUpdTitulo;
        private Label DeleteMovie;
    }
}