﻿
namespace CinemaProjeto.Forms
{
    partial class FormSala
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
            this.lstSalas = new System.Windows.Forms.ListBox();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCriarSala = new System.Windows.Forms.Button();
            this.btnEditarSala = new System.Windows.Forms.Button();
            this.btnEliminarSala = new System.Windows.Forms.Button();
            this.numericColunas = new System.Windows.Forms.NumericUpDown();
            this.numericFilas = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericColunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFilas)).BeginInit();
            this.SuspendLayout();
            // 
            // lstSalas
            // 
            this.lstSalas.FormattingEnabled = true;
            this.lstSalas.ItemHeight = 16;
            this.lstSalas.Location = new System.Drawing.Point(16, 255);
            this.lstSalas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstSalas.Name = "lstSalas";
            this.lstSalas.Size = new System.Drawing.Size(767, 180);
            this.lstSalas.TabIndex = 0;
            this.lstSalas.SelectedIndexChanged += new System.EventHandler(this.lstSalas_SelectedIndexChanged);
            // 
            // txtSala
            // 
            this.txtSala.Location = new System.Drawing.Point(16, 50);
            this.txtSala.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(309, 22);
            this.txtSala.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome da Sala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(17, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Colunas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(17, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filas";
            // 
            // btnCriarSala
            // 
            this.btnCriarSala.Location = new System.Drawing.Point(460, 47);
            this.btnCriarSala.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCriarSala.Name = "btnCriarSala";
            this.btnCriarSala.Size = new System.Drawing.Size(100, 28);
            this.btnCriarSala.TabIndex = 7;
            this.btnCriarSala.Text = "Criar Sala";
            this.btnCriarSala.UseVisualStyleBackColor = true;
            this.btnCriarSala.Click += new System.EventHandler(this.btnCriarSala_Click);
            // 
            // btnEditarSala
            // 
            this.btnEditarSala.Location = new System.Drawing.Point(460, 118);
            this.btnEditarSala.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditarSala.Name = "btnEditarSala";
            this.btnEditarSala.Size = new System.Drawing.Size(100, 28);
            this.btnEditarSala.TabIndex = 8;
            this.btnEditarSala.Text = "Editar Sala";
            this.btnEditarSala.UseVisualStyleBackColor = true;
            this.btnEditarSala.Click += new System.EventHandler(this.btnEditarSala_Click);
            // 
            // btnEliminarSala
            // 
            this.btnEliminarSala.Location = new System.Drawing.Point(460, 188);
            this.btnEliminarSala.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarSala.Name = "btnEliminarSala";
            this.btnEliminarSala.Size = new System.Drawing.Size(100, 28);
            this.btnEliminarSala.TabIndex = 9;
            this.btnEliminarSala.Text = "Eliminar Sala";
            this.btnEliminarSala.UseVisualStyleBackColor = true;
            this.btnEliminarSala.Click += new System.EventHandler(this.btnEliminarSala_Click);
            // 
            // numericColunas
            // 
            this.numericColunas.Location = new System.Drawing.Point(17, 121);
            this.numericColunas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericColunas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericColunas.Name = "numericColunas";
            this.numericColunas.Size = new System.Drawing.Size(309, 22);
            this.numericColunas.TabIndex = 10;
            this.numericColunas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericFilas
            // 
            this.numericFilas.Location = new System.Drawing.Point(16, 192);
            this.numericFilas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericFilas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericFilas.Name = "numericFilas";
            this.numericFilas.Size = new System.Drawing.Size(309, 22);
            this.numericFilas.TabIndex = 11;
            this.numericFilas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Sala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericFilas);
            this.Controls.Add(this.numericColunas);
            this.Controls.Add(this.btnEliminarSala);
            this.Controls.Add(this.btnEditarSala);
            this.Controls.Add(this.btnCriarSala);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSala);
            this.Controls.Add(this.lstSalas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Sala";
            this.Text = "Sala";
            this.Load += new System.EventHandler(this.FormSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericColunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFilas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSalas;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCriarSala;
        private System.Windows.Forms.Button btnEditarSala;
        private System.Windows.Forms.Button btnEliminarSala;
        private System.Windows.Forms.NumericUpDown numericColunas;
        private System.Windows.Forms.NumericUpDown numericFilas;
    }
}