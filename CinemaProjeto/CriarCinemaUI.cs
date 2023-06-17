using CinemaProjeto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class CriarCinemaUI : Form
    {
        private Cinema cinema;

        public CriarCinemaUI(Cinema cinema)
        {
            InitializeComponent();
            this.cinema = cinema;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (cinema != null)
            {
                textBoxEmail.Text = cinema.Email;
                textBoxMorada.Text = cinema.Morada;
                textBoxNome.Text = cinema.Nome;
                labelCriar.Text = "Editar Cinema";
                buttonCriar.Text = "Editar";
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
            this.Hide();

        }
    }

}
