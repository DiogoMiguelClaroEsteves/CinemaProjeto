using CinemaProjeto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaProjeto.Forms
{
    public partial class FormCinema : Form
    {
        public FormCinema(Cinema cinema)
        {
            InitializeComponent();
            this.cinema = cinema;
        }

        private Cinema cinema;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (cinema != null)
            {
                textBoxEmail.Text = cinema.Email;
                textBoxMorada.Text = cinema.Morada;
                textBoxNome.Text = cinema.Nome;
                labelCriar.Text = "Editar Cinema";
            }
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            if (labelCriar.Text == "Editar Cinema")
            {
                using (var db = new CinemaContext())
                {
                    var dbCinema = db.Cinemas.FirstOrDefault(x => x.ID == cinema.ID);
                    dbCinema.Email = textBoxEmail.Text;
                    dbCinema.Nome = textBoxNome.Text;
                    dbCinema.Morada = textBoxMorada.Text;
                    db.SaveChanges();
                }
            }
            else
            {
                var novoCinema = new Cinema()
                {
                    Email = textBoxEmail.Text,
                    Nome = textBoxNome.Text,
                    Morada = textBoxMorada.Text,
                };

                using (var db = new CinemaContext())
                {
                    db.Cinemas.Add(novoCinema);
                    db.SaveChanges();
                }
            }
        }

    }
}
