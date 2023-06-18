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
    public partial class FormFilme : Form
    {
        public FormFilme()
        {
            InitializeComponent();
        }

        private void FormFilme_Load(object sender, EventArgs e)
        {
            using (var db = new CinemaContext())
            {
                var filmes = db.Filmes.ToList();
                lstFilmes.Items.AddRange(filmes.ToArray());
            }
        }

        private void btnCriarFilme_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilme.Text))
            {
                MessageBox.Show("Nome do Filme Vazio");

                return;
            }

            var novoFilme = new Filme()
            {
                Nome = txtFilme.Text,
                Activo = checkBoxAtivo.Checked,
            };

            using (var db = new CinemaContext())
            {
                db.Filmes.Add(novoFilme);
                db.SaveChanges();
            }

            lstFilmes.Items.Add(novoFilme);

            LimparCampos();
        }

        private void btnEditarFilme_Click(object sender, EventArgs e)
        {
            if (lstFilmes.SelectedItem == null)
            {
                MessageBox.Show("Nenhum filme selecionada para editar.");
                return;
            }

            Filme filme = (Filme)lstFilmes.SelectedItem;
            filme.EditarFilme(txtFilme.Text, checkBoxAtivo.Checked);

            lstFilmes.Items[lstFilmes.SelectedIndex] = filme;

            MessageBox.Show("Filme editado com sucesso!");

            LimparCampos();
        }

        private void btnEliminarFilme_Click(object sender, EventArgs e)
        {
            if (lstFilmes.SelectedItem == null)
            {
                MessageBox.Show("Nenhum filme selecionado para eliminar.");
                return;
            }

            Filme filme = (Filme)lstFilmes.SelectedItem;
            filme.RemoverFilme(filme);
            lstFilmes.Items.Remove(filme);

            LimparCampos();
        }

        private void lstFilmes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFilmes.SelectedItem == null)
            {
                return;
            }

            Filme filme = (Filme)lstFilmes.SelectedItem;

            txtFilme.Text = filme.Nome;
            checkBoxAtivo.Checked = filme.Activo;
        }

        private void LimparCampos()
        {
            txtFilme.Text = string.Empty;
            checkBoxAtivo.Checked = false;
        }
    }
}
