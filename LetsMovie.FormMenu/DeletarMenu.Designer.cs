namespace LetsMovie.FormMenu
{
    partial class frmDeletar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeletar));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnTelaInicial = new System.Windows.Forms.Button();
            this.picMovie = new System.Windows.Forms.PictureBox();
            this.picSeries = new System.Windows.Forms.PictureBox();
            this.picDoc = new System.Windows.Forms.PictureBox();
            this.labSeries = new System.Windows.Forms.Label();
            this.labFilmes = new System.Windows.Forms.Label();
            this.labDoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(636, 32);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.Location = new System.Drawing.Point(322, 32);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(75, 23);
            this.btnSobre.TabIndex = 8;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnTelaInicial
            // 
            this.btnTelaInicial.Location = new System.Drawing.Point(35, 32);
            this.btnTelaInicial.Name = "btnTelaInicial";
            this.btnTelaInicial.Size = new System.Drawing.Size(75, 23);
            this.btnTelaInicial.TabIndex = 7;
            this.btnTelaInicial.Text = "Tela Inicial";
            this.btnTelaInicial.UseVisualStyleBackColor = true;
            this.btnTelaInicial.Click += new System.EventHandler(this.btnTelaInicial_Click);
            // 
            // picMovie
            // 
            this.picMovie.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picMovie.ErrorImage")));
            this.picMovie.Image = ((System.Drawing.Image)(resources.GetObject("picMovie.Image")));
            this.picMovie.InitialImage = ((System.Drawing.Image)(resources.GetObject("picMovie.InitialImage")));
            this.picMovie.Location = new System.Drawing.Point(34, 118);
            this.picMovie.Name = "picMovie";
            this.picMovie.Size = new System.Drawing.Size(221, 177);
            this.picMovie.TabIndex = 10;
            this.picMovie.TabStop = false;
            this.picMovie.Click += new System.EventHandler(this.picMovie_Click);
            // 
            // picSeries
            // 
            this.picSeries.Image = ((System.Drawing.Image)(resources.GetObject("picSeries.Image")));
            this.picSeries.Location = new System.Drawing.Point(298, 198);
            this.picSeries.Name = "picSeries";
            this.picSeries.Size = new System.Drawing.Size(212, 177);
            this.picSeries.TabIndex = 11;
            this.picSeries.TabStop = false;
            // 
            // picDoc
            // 
            this.picDoc.Image = ((System.Drawing.Image)(resources.GetObject("picDoc.Image")));
            this.picDoc.Location = new System.Drawing.Point(547, 118);
            this.picDoc.Name = "picDoc";
            this.picDoc.Size = new System.Drawing.Size(221, 177);
            this.picDoc.TabIndex = 12;
            this.picDoc.TabStop = false;
            // 
            // labSeries
            // 
            this.labSeries.AutoSize = true;
            this.labSeries.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labSeries.Location = new System.Drawing.Point(361, 163);
            this.labSeries.Name = "labSeries";
            this.labSeries.Size = new System.Drawing.Size(82, 30);
            this.labSeries.TabIndex = 13;
            this.labSeries.Text = "SÉRIES";
            // 
            // labFilmes
            // 
            this.labFilmes.AutoSize = true;
            this.labFilmes.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labFilmes.Location = new System.Drawing.Point(94, 298);
            this.labFilmes.Name = "labFilmes";
            this.labFilmes.Size = new System.Drawing.Size(87, 30);
            this.labFilmes.TabIndex = 14;
            this.labFilmes.Text = "FILMES";
            // 
            // labDoc
            // 
            this.labDoc.AutoSize = true;
            this.labDoc.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labDoc.Location = new System.Drawing.Point(553, 298);
            this.labDoc.Name = "labDoc";
            this.labDoc.Size = new System.Drawing.Size(203, 30);
            this.labDoc.TabIndex = 15;
            this.labDoc.Text = "DOCUMENTÁRIOS";
            // 
            // frmDeletar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labDoc);
            this.Controls.Add(this.labFilmes);
            this.Controls.Add(this.labSeries);
            this.Controls.Add(this.picDoc);
            this.Controls.Add(this.picSeries);
            this.Controls.Add(this.picMovie);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.btnTelaInicial);
            this.Name = "frmDeletar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deletar";
            ((System.ComponentModel.ISupportInitialize)(this.picMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnVoltar;
        private Button btnSobre;
        private Button btnTelaInicial;
        private PictureBox picMovie;
        private PictureBox picSeries;
        private PictureBox picDoc;
        private Label labSeries;
        private Label labFilmes;
        private Label labDoc;
    }
}