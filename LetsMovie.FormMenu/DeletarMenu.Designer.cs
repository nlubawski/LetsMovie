namespace LetsMovie.FormMenu
{
    partial class frmDeletarMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeletarMenu));
            this.labFilmes = new System.Windows.Forms.Label();
            this.picMovie = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // labFilmes
            // 
            this.labFilmes.AutoSize = true;
            this.labFilmes.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labFilmes.Location = new System.Drawing.Point(114, 304);
            this.labFilmes.Name = "labFilmes";
            this.labFilmes.Size = new System.Drawing.Size(87, 30);
            this.labFilmes.TabIndex = 25;
            this.labFilmes.Text = "FILMES";
            // 
            // picMovie
            // 
            this.picMovie.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picMovie.ErrorImage")));
            this.picMovie.Image = ((System.Drawing.Image)(resources.GetObject("picMovie.Image")));
            this.picMovie.InitialImage = ((System.Drawing.Image)(resources.GetObject("picMovie.InitialImage")));
            this.picMovie.Location = new System.Drawing.Point(54, 124);
            this.picMovie.Name = "picMovie";
            this.picMovie.Size = new System.Drawing.Size(221, 177);
            this.picMovie.TabIndex = 24;
            this.picMovie.TabStop = false;
            this.picMovie.Click += new System.EventHandler(this.picMovie_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(672, 38);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 23;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.Location = new System.Drawing.Point(358, 38);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(75, 23);
            this.btnSobre.TabIndex = 22;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = true;
            // 
            // frmDeletarMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labFilmes);
            this.Controls.Add(this.picMovie);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSobre);
            this.Name = "frmDeletarMenu";
            this.Text = "DeletarMenu";
            this.Load += new System.EventHandler(this.DeletarMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labFilmes;
        private PictureBox picMovie;
        private Button btnVoltar;
        private Button btnSobre;
    }
}