
namespace CinemaProjeto.Forms
{
    partial class FormSessoes
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.btnCriarSessao = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBoxSessoes = new System.Windows.Forms.ListBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnEliminarSessao = new System.Windows.Forms.Button();
            this.btnEditarSessao = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data e Hora";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm ";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(29, 36);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(159, 20);
            this.dateTimePicker.TabIndex = 1;
            this.dateTimePicker.Value = new System.DateTime(2023, 6, 19, 19, 43, 43, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(27, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preço";
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(29, 95);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(159, 20);
            this.textBoxPreco.TabIndex = 18;
            // 
            // btnCriarSessao
            // 
            this.btnCriarSessao.Location = new System.Drawing.Point(29, 205);
            this.btnCriarSessao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCriarSessao.Name = "btnCriarSessao";
            this.btnCriarSessao.Size = new System.Drawing.Size(79, 20);
            this.btnCriarSessao.TabIndex = 22;
            this.btnCriarSessao.Text = "Criar Sessao";
            this.btnCriarSessao.UseVisualStyleBackColor = true;
            this.btnCriarSessao.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBoxSessoes);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(254, 19);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(342, 265);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sessões";
            // 
            // listBoxSessoes
            // 
            this.listBoxSessoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxSessoes.FormattingEnabled = true;
            this.listBoxSessoes.Location = new System.Drawing.Point(4, 15);
            this.listBoxSessoes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxSessoes.Name = "listBoxSessoes";
            this.listBoxSessoes.Size = new System.Drawing.Size(333, 238);
            this.listBoxSessoes.TabIndex = 0;
            this.listBoxSessoes.SelectedIndexChanged += new System.EventHandler(this.listBoxSessoes_SelectedIndexChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnEliminarSessao
            // 
            this.btnEliminarSessao.Location = new System.Drawing.Point(29, 290);
            this.btnEliminarSessao.Name = "btnEliminarSessao";
            this.btnEliminarSessao.Size = new System.Drawing.Size(79, 23);
            this.btnEliminarSessao.TabIndex = 25;
            this.btnEliminarSessao.Text = "Eliminar Sessao";
            this.btnEliminarSessao.UseVisualStyleBackColor = true;
            this.btnEliminarSessao.Click += new System.EventHandler(this.btnEliminarSessao_Click);
            // 
            // btnEditarSessao
            // 
            this.btnEditarSessao.Location = new System.Drawing.Point(29, 248);
            this.btnEditarSessao.Name = "btnEditarSessao";
            this.btnEditarSessao.Size = new System.Drawing.Size(79, 23);
            this.btnEditarSessao.TabIndex = 24;
            this.btnEditarSessao.Text = "Editar Sessao";
            this.btnEditarSessao.UseVisualStyleBackColor = true;
            this.btnEditarSessao.Click += new System.EventHandler(this.btnEditarSessao_Click);
            // 
            // FormSessoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnEliminarSessao);
            this.Controls.Add(this.btnEditarSessao);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnCriarSessao);
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSessoes";
            this.Text = "Sessoes";
            this.Load += new System.EventHandler(this.FormSessoes_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.Button btnCriarSessao;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBoxSessoes;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnEliminarSessao;
        private System.Windows.Forms.Button btnEditarSessao;
    }
}