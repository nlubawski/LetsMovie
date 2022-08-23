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
            this.LabTitulo = new System.Windows.Forms.Label();
            this.labUpdTitulo = new System.Windows.Forms.Label();
            this.lblNovoTitulo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labAtualizar = new System.Windows.Forms.Label();
            this.labAtualizadoOk = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labTitle.Location = new System.Drawing.Point(271, 29);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(295, 30);
            this.labTitle.TabIndex = 1;
            this.labTitle.Text = "ATUALIZAR TÍTULO - FILME";
            // 
            // LabTitulo
            // 
            this.LabTitulo.AutoSize = true;
            this.LabTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabTitulo.Location = new System.Drawing.Point(171, 143);
            this.LabTitulo.Name = "LabTitulo";
            this.LabTitulo.Size = new System.Drawing.Size(0, 21);
            this.LabTitulo.TabIndex = 2;
            // 
            // labUpdTitulo
            // 
            this.labUpdTitulo.AutoSize = true;
            this.labUpdTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labUpdTitulo.Location = new System.Drawing.Point(265, 98);
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
            this.lblNovoTitulo.Location = new System.Drawing.Point(311, 277);
            this.lblNovoTitulo.Name = "lblNovoTitulo";
            this.lblNovoTitulo.Size = new System.Drawing.Size(174, 25);
            this.lblNovoTitulo.TabIndex = 5;
            this.lblNovoTitulo.Text = "Digite o novo Título:";
            this.lblNovoTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(287, 310);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 33);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labAtualizar
            // 
            this.labAtualizar.AutoSize = true;
            this.labAtualizar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labAtualizar.Location = new System.Drawing.Point(245, 385);
            this.labAtualizar.Name = "labAtualizar";
            this.labAtualizar.Size = new System.Drawing.Size(118, 25);
            this.labAtualizar.TabIndex = 6;
            this.labAtualizar.Text = "Atualizando...";
            // 
            // labAtualizadoOk
            // 
            this.labAtualizadoOk.AutoSize = true;
            this.labAtualizadoOk.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labAtualizadoOk.Location = new System.Drawing.Point(421, 385);
            this.labAtualizadoOk.Name = "labAtualizadoOk";
            this.labAtualizadoOk.Size = new System.Drawing.Size(208, 25);
            this.labAtualizadoOk.TabIndex = 7;
            this.labAtualizadoOk.Text = "Atualizado com sucesso!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(567, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(283, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(240, 110);
            this.dataGridView1.TabIndex = 10;
            // 
            // frmUpdateMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 438);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labAtualizadoOk);
            this.Controls.Add(this.labAtualizar);
            this.Controls.Add(this.lblNovoTitulo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labUpdTitulo);
            this.Controls.Add(this.LabTitulo);
            this.Controls.Add(this.labTitle);
            this.Name = "frmUpdateMovie";
            this.Text = "UpdateMovieForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labTitle;
        private Label LabTitulo;
        private Label labUpdTitulo;
        private Label lblNovoTitulo;
        private TextBox textBox1;
        private Label labAtualizar;
        private Label labAtualizadoOk;
        private Button button1;
        private DataGridView dataGridView1;
    }
}