
namespace CinemaProjeto.Forms
{
    partial class FormCinema
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonCriar = new System.Windows.Forms.Button();
            this.textBoxMorada = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelMorada = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.ForeColor = System.Drawing.Color.Snow;
            this.groupBox1.Location = new System.Drawing.Point(34, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 337);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cinemas";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 316);
            this.listBox1.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(305, 190);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(380, 22);
            this.textBoxEmail.TabIndex = 14;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.labelEmail.Location = new System.Drawing.Point(301, 170);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 17);
            this.labelEmail.TabIndex = 13;
            this.labelEmail.Text = "Email";
            // 
            // buttonCriar
            // 
            this.buttonCriar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCriar.Location = new System.Drawing.Point(584, 267);
            this.buttonCriar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCriar.Name = "buttonCriar";
            this.buttonCriar.Size = new System.Drawing.Size(100, 28);
            this.buttonCriar.TabIndex = 12;
            this.buttonCriar.Text = "Criar";
            this.buttonCriar.UseVisualStyleBackColor = true;
            this.buttonCriar.Click += new System.EventHandler(this.buttonCriar_Click);
            // 
            // textBoxMorada
            // 
            this.textBoxMorada.Location = new System.Drawing.Point(304, 133);
            this.textBoxMorada.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMorada.Name = "textBoxMorada";
            this.textBoxMorada.Size = new System.Drawing.Size(380, 22);
            this.textBoxMorada.TabIndex = 11;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(304, 68);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(380, 22);
            this.textBoxNome.TabIndex = 10;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNome.Location = new System.Drawing.Point(300, 47);
            this.labelNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(45, 17);
            this.labelNome.TabIndex = 9;
            this.labelNome.Text = "Nome";
            // 
            // labelMorada
            // 
            this.labelMorada.AutoSize = true;
            this.labelMorada.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMorada.Location = new System.Drawing.Point(300, 113);
            this.labelMorada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMorada.Name = "labelMorada";
            this.labelMorada.Size = new System.Drawing.Size(56, 17);
            this.labelMorada.TabIndex = 8;
            this.labelMorada.Text = "Morada";
            // 
            // FormCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.buttonCriar);
            this.Controls.Add(this.textBoxMorada);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelMorada);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "FormCinema";
            this.Text = "FormCinema";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonCriar;
        private System.Windows.Forms.TextBox textBoxMorada;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelMorada;
    }
}