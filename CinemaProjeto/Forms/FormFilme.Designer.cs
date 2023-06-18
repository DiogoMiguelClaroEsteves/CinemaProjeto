
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
            this.SuspendLayout();
            // 
            // btnEliminarFilme
            // 
            this.btnEliminarFilme.Location = new System.Drawing.Point(345, 148);
            this.btnEliminarFilme.Name = "btnEliminarFilme";
            this.btnEliminarFilme.Size = new System.Drawing.Size(79, 23);
            this.btnEliminarFilme.TabIndex = 19;
            this.btnEliminarFilme.Text = "Eliminar Filme";
            this.btnEliminarFilme.UseVisualStyleBackColor = true;
            this.btnEliminarFilme.Click += new System.EventHandler(this.btnEliminarFilme_Click);
            // 
            // btnEditarFilme
            // 
            this.btnEditarFilme.Location = new System.Drawing.Point(345, 91);
            this.btnEditarFilme.Name = "btnEditarFilme";
            this.btnEditarFilme.Size = new System.Drawing.Size(79, 23);
            this.btnEditarFilme.TabIndex = 18;
            this.btnEditarFilme.Text = "Editar Filme";
            this.btnEditarFilme.UseVisualStyleBackColor = true;
            this.btnEditarFilme.Click += new System.EventHandler(this.btnEditarFilme_Click);
            // 
            // btnCriarFilme
            // 
            this.btnCriarFilme.Location = new System.Drawing.Point(345, 33);
            this.btnCriarFilme.Name = "btnCriarFilme";
            this.btnCriarFilme.Size = new System.Drawing.Size(79, 23);
            this.btnCriarFilme.TabIndex = 17;
            this.btnCriarFilme.Text = "Criar Filme";
            this.btnCriarFilme.UseVisualStyleBackColor = true;
            this.btnCriarFilme.Click += new System.EventHandler(this.btnCriarFilme_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(13, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ativo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Duração";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome do Filme";
            // 
            // txtFilme
            // 
            this.txtFilme.Location = new System.Drawing.Point(12, 36);
            this.txtFilme.Name = "txtFilme";
            this.txtFilme.Size = new System.Drawing.Size(233, 20);
            this.txtFilme.TabIndex = 13;
            // 
            // lstFilmes
            // 
            this.lstFilmes.FormattingEnabled = true;
            this.lstFilmes.Location = new System.Drawing.Point(12, 202);
            this.lstFilmes.Name = "lstFilmes";
            this.lstFilmes.Size = new System.Drawing.Size(576, 147);
            this.lstFilmes.TabIndex = 12;
            this.lstFilmes.SelectedIndexChanged += new System.EventHandler(this.lstFilmes_SelectedIndexChanged);
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.AutoSize = true;
            this.checkBoxAtivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxAtivo.Location = new System.Drawing.Point(16, 154);
            this.checkBoxAtivo.Name = "checkBoxAtivo";
            this.checkBoxAtivo.Size = new System.Drawing.Size(84, 17);
            this.checkBoxAtivo.TabIndex = 22;
            this.checkBoxAtivo.Text = "Em Exibição";
            this.checkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // FormFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.checkBoxAtivo);
            this.Controls.Add(this.btnEliminarFilme);
            this.Controls.Add(this.btnEditarFilme);
            this.Controls.Add(this.btnCriarFilme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilme);
            this.Controls.Add(this.lstFilmes);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormFilme";
            this.Text = "FormFilme";
            this.Load += new System.EventHandler(this.FormFilme_Load);
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
    }
}