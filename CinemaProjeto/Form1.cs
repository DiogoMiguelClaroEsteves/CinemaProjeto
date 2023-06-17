using Projeto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaProjeto
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Cinema cinema;
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Nirmala UI", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(22, 35, 64);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }   

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
               activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHome(), sender);
        }

        private void btncinema_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCinema(), sender);
        }

        private void buttonCriarCinema_Click(object sender, EventArgs e)
        {
            CriarCinemaUI criarCinemaUI = new CriarCinemaUI(cinema);
            criarCinemaUI.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //verificar se já existe cinema registado para guardar configuração
            using (var db = new CinemaContext())
            {
                cinema = db.Cinemas.FirstOrDefault();
                if(cinema != null)
                {
                    buttonCriarCinema.Text = "Editar Cinema";
                }
            }
        }

        private void btnfilmes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFilme(), sender);
        }

        private void btnsalas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSala(), sender);
        }

        private void btnbilhetes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormBilhetes(), sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
