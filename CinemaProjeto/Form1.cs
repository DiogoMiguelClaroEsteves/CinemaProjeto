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
        private Cinema cinema;
        public Form1()
        {
            InitializeComponent();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {

        }

        private void btncinema_Click(object sender, EventArgs e)
        {

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
    }
}
