﻿namespace CinemaProjeto
{
    partial class Form1
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonCriarCinema = new System.Windows.Forms.Button();
            this.btnbilhetes = new System.Windows.Forms.Button();
            this.btnsalas = new System.Windows.Forms.Button();
            this.btnfilmes = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CineGest = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.btnsessoes = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.panelMenu.Controls.Add(this.btnsessoes);
            this.panelMenu.Controls.Add(this.buttonCriarCinema);
            this.panelMenu.Controls.Add(this.btnbilhetes);
            this.panelMenu.Controls.Add(this.btnsalas);
            this.panelMenu.Controls.Add(this.btnfilmes);
            this.panelMenu.Controls.Add(this.HomeBtn);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 672);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonCriarCinema
            // 
            this.buttonCriarCinema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.buttonCriarCinema.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonCriarCinema.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCriarCinema.Location = new System.Drawing.Point(0, 150);
            this.buttonCriarCinema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCriarCinema.Name = "buttonCriarCinema";
            this.buttonCriarCinema.Size = new System.Drawing.Size(180, 42);
            this.buttonCriarCinema.TabIndex = 6;
            this.buttonCriarCinema.Text = "Criar Cinema";
            this.buttonCriarCinema.UseVisualStyleBackColor = false;
            this.buttonCriarCinema.Click += new System.EventHandler(this.buttonCriarCinema_Click);
            // 
            // btnbilhetes
            // 
            this.btnbilhetes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnbilhetes.AutoSize = true;
            this.btnbilhetes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbilhetes.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbilhetes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.btnbilhetes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbilhetes.Location = new System.Drawing.Point(0, 336);
            this.btnbilhetes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbilhetes.Name = "btnbilhetes";
            this.btnbilhetes.Size = new System.Drawing.Size(180, 43);
            this.btnbilhetes.TabIndex = 5;
            this.btnbilhetes.Text = "BILHETES";
            this.btnbilhetes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbilhetes.UseVisualStyleBackColor = true;
            this.btnbilhetes.Click += new System.EventHandler(this.btnbilhetes_Click);
            // 
            // btnsalas
            // 
            this.btnsalas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsalas.AutoSize = true;
            this.btnsalas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalas.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.btnsalas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalas.Location = new System.Drawing.Point(0, 242);
            this.btnsalas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsalas.Name = "btnsalas";
            this.btnsalas.Size = new System.Drawing.Size(180, 43);
            this.btnsalas.TabIndex = 4;
            this.btnsalas.Text = "SALAS";
            this.btnsalas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsalas.UseVisualStyleBackColor = true;
            this.btnsalas.Click += new System.EventHandler(this.btnsalas_Click);
            // 
            // btnfilmes
            // 
            this.btnfilmes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnfilmes.AutoSize = true;
            this.btnfilmes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfilmes.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfilmes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.btnfilmes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfilmes.Location = new System.Drawing.Point(0, 196);
            this.btnfilmes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnfilmes.Name = "btnfilmes";
            this.btnfilmes.Size = new System.Drawing.Size(180, 43);
            this.btnfilmes.TabIndex = 3;
            this.btnfilmes.Text = "FILMES";
            this.btnfilmes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnfilmes.UseVisualStyleBackColor = true;
            this.btnfilmes.Click += new System.EventHandler(this.btnfilmes_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HomeBtn.AutoSize = true;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.HomeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBtn.Location = new System.Drawing.Point(0, 103);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(5, 2, 3, 2);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(180, 43);
            this.HomeBtn.TabIndex = 1;
            this.HomeBtn.Text = "HOME";
            this.HomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CineGest);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 100);
            this.panel2.TabIndex = 0;
            // 
            // CineGest
            // 
            this.CineGest.AutoSize = true;
            this.CineGest.Font = new System.Drawing.Font("Showcard Gothic", 20.2F);
            this.CineGest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(6)))), ((int)(((byte)(19)))));
            this.CineGest.Location = new System.Drawing.Point(3, 27);
            this.CineGest.Name = "CineGest";
            this.CineGest.Size = new System.Drawing.Size(175, 43);
            this.CineGest.TabIndex = 0;
            this.CineGest.Text = "CineGest";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(180, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 100);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Showcard Gothic", 20.2F);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(321, 27);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(117, 43);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "HOME";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(180, 100);
            this.panelDesktopPane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(873, 572);
            this.panelDesktopPane.TabIndex = 3;
            // 
            // btnsessoes
            // 
            this.btnsessoes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsessoes.AutoSize = true;
            this.btnsessoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsessoes.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsessoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.btnsessoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsessoes.Location = new System.Drawing.Point(0, 289);
            this.btnsessoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsessoes.Name = "btnsessoes";
            this.btnsessoes.Size = new System.Drawing.Size(180, 43);
            this.btnsessoes.TabIndex = 7;
            this.btnsessoes.Text = "SESSÕES";
            this.btnsessoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsessoes.UseVisualStyleBackColor = true;
            this.btnsessoes.Click += new System.EventHandler(this.btnsessoes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1053, 672);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "CineGest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CineGest;
        private System.Windows.Forms.Button btnbilhetes;
        private System.Windows.Forms.Button btnsalas;
        private System.Windows.Forms.Button btnfilmes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button buttonCriarCinema;
        private System.Windows.Forms.Button btnsessoes;
    }
}

