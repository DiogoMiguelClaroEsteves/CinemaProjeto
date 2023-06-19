
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
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data e Hora";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm ";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(39, 44);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(211, 22);
            this.dateTimePicker.TabIndex = 1;
            this.dateTimePicker.Value = new System.DateTime(2023, 6, 19, 19, 43, 43, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(36, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preço";
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(39, 117);
            this.textBoxPreco.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(211, 22);
            this.textBoxPreco.TabIndex = 18;
            // 
            // btnCriarSessao
            // 
            this.btnCriarSessao.Location = new System.Drawing.Point(39, 252);
            this.btnCriarSessao.Name = "btnCriarSessao";
            this.btnCriarSessao.Size = new System.Drawing.Size(105, 25);
            this.btnCriarSessao.TabIndex = 22;
            this.btnCriarSessao.Text = "Criar Sessao";
            this.btnCriarSessao.UseVisualStyleBackColor = true;
            this.btnCriarSessao.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBoxSessoes);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(339, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(456, 326);
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
            this.listBoxSessoes.ItemHeight = 16;
            this.listBoxSessoes.Location = new System.Drawing.Point(6, 18);
            this.listBoxSessoes.Name = "listBoxSessoes";
            this.listBoxSessoes.Size = new System.Drawing.Size(443, 292);
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
            this.btnEliminarSessao.Location = new System.Drawing.Point(39, 357);
            this.btnEliminarSessao.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarSessao.Name = "btnEliminarSessao";
            this.btnEliminarSessao.Size = new System.Drawing.Size(105, 28);
            this.btnEliminarSessao.TabIndex = 25;
            this.btnEliminarSessao.Text = "Eliminar Sessao";
            this.btnEliminarSessao.UseVisualStyleBackColor = true;
            this.btnEliminarSessao.Click += new System.EventHandler(this.btnEliminarSessao_Click);
            // 
            // btnEditarSessao
            // 
            this.btnEditarSessao.Location = new System.Drawing.Point(39, 305);
            this.btnEditarSessao.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarSessao.Name = "btnEditarSessao";
            this.btnEditarSessao.Size = new System.Drawing.Size(105, 28);
            this.btnEditarSessao.TabIndex = 24;
            this.btnEditarSessao.Text = "Editar Sessao";
            this.btnEditarSessao.UseVisualStyleBackColor = true;
            this.btnEditarSessao.Click += new System.EventHandler(this.btnEditarSessao_Click);
            // 
            // FormSessoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarSessao);
            this.Controls.Add(this.btnEditarSessao);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnCriarSessao);
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label1);
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