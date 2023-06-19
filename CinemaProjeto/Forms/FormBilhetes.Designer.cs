
namespace CinemaProjeto.Forms
{
    partial class FormBilhetes
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
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonVender = new System.Windows.Forms.Button();
            this.textBoxMorada = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelMorada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(18, 169);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(380, 22);
            this.textBoxEmail.TabIndex = 21;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEmail.Location = new System.Drawing.Point(14, 149);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(36, 17);
            this.labelEmail.TabIndex = 20;
            this.labelEmail.Text = "Sala";
            this.labelEmail.Click += new System.EventHandler(this.labelEmail_Click);
            // 
            // buttonVender
            // 
            this.buttonVender.Location = new System.Drawing.Point(297, 246);
            this.buttonVender.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVender.Name = "buttonVender";
            this.buttonVender.Size = new System.Drawing.Size(100, 28);
            this.buttonVender.TabIndex = 19;
            this.buttonVender.Text = "Vender";
            this.buttonVender.UseVisualStyleBackColor = true;
            this.buttonVender.Click += new System.EventHandler(this.buttonCriar_Click);
            // 
            // textBoxMorada
            // 
            this.textBoxMorada.Location = new System.Drawing.Point(17, 112);
            this.textBoxMorada.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMorada.Name = "textBoxMorada";
            this.textBoxMorada.Size = new System.Drawing.Size(380, 22);
            this.textBoxMorada.TabIndex = 18;
            this.textBoxMorada.TextChanged += new System.EventHandler(this.textBoxMorada_TextChanged);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(17, 47);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(380, 22);
            this.textBoxNome.TabIndex = 17;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNome.Location = new System.Drawing.Point(13, 26);
            this.labelNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(45, 17);
            this.labelNome.TabIndex = 16;
            this.labelNome.Text = "Nome";
            this.labelNome.Click += new System.EventHandler(this.labelNome_Click);
            // 
            // labelMorada
            // 
            this.labelMorada.AutoSize = true;
            this.labelMorada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMorada.Location = new System.Drawing.Point(13, 92);
            this.labelMorada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMorada.Name = "labelMorada";
            this.labelMorada.Size = new System.Drawing.Size(41, 17);
            this.labelMorada.TabIndex = 15;
            this.labelMorada.Text = "Filme";
            this.labelMorada.Click += new System.EventHandler(this.labelMorada_Click);
            // 
            // FormBilhetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.buttonVender);
            this.Controls.Add(this.textBoxMorada);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelMorada);
            this.Name = "FormBilhetes";
            this.Text = "Bilhetes";
            this.Load += new System.EventHandler(this.Bilhetes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonVender;
        private System.Windows.Forms.TextBox textBoxMorada;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelMorada;
    }
}