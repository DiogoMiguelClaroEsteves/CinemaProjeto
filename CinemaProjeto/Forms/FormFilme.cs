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

            var novoFilme = new CinemaProjeto.Filme()
            {
                Nome = txtFilme.Text,
                Activo = checkBoxAtivo.Checked,
                Duracao = numericUpDown1.Text,
                Categoria = comboBox1.Text,
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

            CinemaProjeto.Filme filme = (CinemaProjeto.Filme)lstFilmes.SelectedItem;
            filme.EditarFilme(txtFilme.Text, checkBoxAtivo.Checked, numericUpDown1.Text, comboBox1.Text);

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

            CinemaProjeto.Filme filme = (CinemaProjeto.Filme)lstFilmes.SelectedItem;
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

            CinemaProjeto.Filme filme = (CinemaProjeto.Filme)lstFilmes.SelectedItem;

            txtFilme.Text = filme.Nome;
            checkBoxAtivo.Checked = filme.Activo;
        }

        private void LimparCampos()
        {
            txtFilme.Text = string.Empty;
            checkBoxAtivo.Checked = false;
        }
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFilme_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
