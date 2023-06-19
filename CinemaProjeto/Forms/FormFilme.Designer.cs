
namespace CinemaProjeto.Forms
{
    partial class FormFilme
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
            this.btnEliminarFilme = new System.Windows.Forms.Button();
            this.btnEditarFilme = new System.Windows.Forms.Button();
            this.btnCriarFilme = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilme = new System.Windows.Forms.TextBox();
            this.lstFilmes = new System.Windows.Forms.ListBox();
            this.checkBoxAtivo = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarFilme
            // 
            this.btnEliminarFilme.Location = new System.Drawing.Point(460, 182);
            this.btnEliminarFilme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarFilme.Name = "btnEliminarFilme";
            this.btnEliminarFilme.Size = new System.Drawing.Size(105, 28);
            this.btnEliminarFilme.TabIndex = 19;
            this.btnEliminarFilme.Text = "Eliminar Filme";
            this.btnEliminarFilme.UseVisualStyleBackColor = true;
            this.btnEliminarFilme.Click += new System.EventHandler(this.btnEliminarFilme_Click);
            // 
            // btnEditarFilme
            // 
            this.btnEditarFilme.Location = new System.Drawing.Point(460, 112);
            this.btnEditarFilme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditarFilme.Name = "btnEditarFilme";
            this.btnEditarFilme.Size = new System.Drawing.Size(105, 28);
            this.btnEditarFilme.TabIndex = 18;
            this.btnEditarFilme.Text = "Editar Filme";
            this.btnEditarFilme.UseVisualStyleBackColor = true;
            this.btnEditarFilme.Click += new System.EventHandler(this.btnEditarFilme_Click);
            // 
            // btnCriarFilme
            // 
            this.btnCriarFilme.Location = new System.Drawing.Point(460, 41);
            this.btnCriarFilme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCriarFilme.Name = "btnCriarFilme";
            this.btnCriarFilme.Size = new System.Drawing.Size(105, 28);
            this.btnCriarFilme.TabIndex = 17;
            this.btnCriarFilme.Text = "Criar Filme";
            this.btnCriarFilme.UseVisualStyleBackColor = true;
            this.btnCriarFilme.Click += new System.EventHandler(this.btnCriarFilme_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(17, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ativo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(17, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Duração";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome do Filme";
            // 
            // txtFilme
            // 
            this.txtFilme.Location = new System.Drawing.Point(16, 44);
            this.txtFilme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilme.Name = "txtFilme";
            this.txtFilme.Size = new System.Drawing.Size(309, 22);
            this.txtFilme.TabIndex = 13;
            this.txtFilme.TextChanged += new System.EventHandler(this.txtFilme_TextChanged);
            // 
            // lstFilmes
            // 
            this.lstFilmes.FormattingEnabled = true;
            this.lstFilmes.ItemHeight = 16;
            this.lstFilmes.Location = new System.Drawing.Point(16, 249);
            this.lstFilmes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstFilmes.Name = "lstFilmes";
            this.lstFilmes.Size = new System.Drawing.Size(767, 180);
            this.lstFilmes.TabIndex = 12;
            this.lstFilmes.SelectedIndexChanged += new System.EventHandler(this.lstFilmes_SelectedIndexChanged);
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.AutoSize = true;
            this.checkBoxAtivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxAtivo.Location = new System.Drawing.Point(21, 190);
            this.checkBoxAtivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxAtivo.Name = "checkBoxAtivo";
            this.checkBoxAtivo.Size = new System.Drawing.Size(106, 21);
            this.checkBoxAtivo.TabIndex = 22;
            this.checkBoxAtivo.Text = "Em Exibição";
            this.checkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(16, 112);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(311, 22);
            this.numericUpDown1.TabIndex = 23;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCategoria.Location = new System.Drawing.Point(173, 162);
            this.labelCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(69, 17);
            this.labelCategoria.TabIndex = 24;
            this.labelCategoria.Text = "Categoria";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Comédia",
            "Sci-fi",
            "Terror",
            "Romance",
            "Acção",
            "Thriller",
            "Drama",
            "Mistério",
            "Crime",
            "Aventura",
            "Fantasia",
            "Animação"});
            this.comboBox1.Location = new System.Drawing.Point(177, 183);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 24);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Filme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.checkBoxAtivo);
            this.Controls.Add(this.btnEliminarFilme);
            this.Controls.Add(this.btnEditarFilme);
            this.Controls.Add(this.btnCriarFilme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilme);
            this.Controls.Add(this.lstFilmes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Filme";
            this.Text = "Filme";
            this.Load += new System.EventHandler(this.FormFilme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminarFilme;
        private System.Windows.Forms.Button btnEditarFilme;
        private System.Windows.Forms.Button btnCriarFilme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilme;
        private System.Windows.Forms.ListBox lstFilmes;
        private System.Windows.Forms.CheckBox checkBoxAtivo;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}