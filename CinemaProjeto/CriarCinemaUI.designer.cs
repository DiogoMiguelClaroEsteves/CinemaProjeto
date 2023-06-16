
namespace Projeto
{
    partial class CriarCinemaUI
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
            this.labelCriar = new System.Windows.Forms.Label();
            this.labelMorada = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxMorada = new System.Windows.Forms.TextBox();
            this.buttonCriar = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCriar
            // 
            this.labelCriar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelCriar.Location = new System.Drawing.Point(80, 11);
            this.labelCriar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCriar.Name = "labelCriar";
            this.labelCriar.Size = new System.Drawing.Size(324, 63);
            this.labelCriar.TabIndex = 0;
            this.labelCriar.Text = "Criar Cinema";
            // 
            // labelMorada
            // 
            this.labelMorada.AutoSize = true;
            this.labelMorada.Location = new System.Drawing.Point(129, 151);
            this.labelMorada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMorada.Name = "labelMorada";
            this.labelMorada.Size = new System.Drawing.Size(54, 16);
            this.labelMorada.TabIndex = 1;
            this.labelMorada.Text = "Morada";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(129, 85);
            this.labelNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(44, 16);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(133, 106);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(380, 22);
            this.textBoxNome.TabIndex = 3;
            // 
            // textBoxMorada
            // 
            this.textBoxMorada.Location = new System.Drawing.Point(133, 171);
            this.textBoxMorada.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMorada.Name = "textBoxMorada";
            this.textBoxMorada.Size = new System.Drawing.Size(380, 22);
            this.textBoxMorada.TabIndex = 4;
            // 
            // buttonCriar
            // 
            this.buttonCriar.Location = new System.Drawing.Point(413, 305);
            this.buttonCriar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCriar.Name = "buttonCriar";
            this.buttonCriar.Size = new System.Drawing.Size(100, 28);
            this.buttonCriar.TabIndex = 5;
            this.buttonCriar.Text = "Criar";
            this.buttonCriar.UseVisualStyleBackColor = true;
            this.buttonCriar.Click += new System.EventHandler(this.buttonCriar_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(134, 228);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(380, 22);
            this.textBoxEmail.TabIndex = 7;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(130, 208);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 16);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "Email";
            // 
            // CriarCinemaUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 383);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.buttonCriar);
            this.Controls.Add(this.textBoxMorada);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelMorada);
            this.Controls.Add(this.labelCriar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CriarCinemaUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCriar;
        private System.Windows.Forms.Label labelMorada;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxMorada;
        private System.Windows.Forms.Button buttonCriar;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
    }
}