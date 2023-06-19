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
    public partial class FormSala : Form
    {
        public FormSala()
        {
            InitializeComponent();
        }

        private void FormSala_Load(object sender, EventArgs e)
        {
            using (var db = new CinemaContext())
            {
                var salas = db.Salas.ToList();
                lstSalas.Items.AddRange(salas.ToArray());
            }
        }

        private void btnCriarSala_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSala.Text))
            {
                MessageBox.Show("Nome da Sala Vazio");

                return;
            }

            var novaSala = new CinemaProjeto.Sala()
            {
                Nome = txtSala.Text,
                Colunas = numericColunas.Value,
                Filas = numericFilas.Value,
            };

            using (var db = new CinemaContext())
            {
                db.Salas.Add(novaSala);
                db.SaveChanges();
            }

            lstSalas.Items.Add(novaSala);
            
            LimparCampos();
        }

        private void btnEditarSala_Click(object sender, EventArgs e)
        {
            if (lstSalas.SelectedItem == null)
            {
                MessageBox.Show("Nenhuma sala selecionada para editar.");
                return;
            }

            CinemaProjeto.Sala sala = (CinemaProjeto.Sala)lstSalas.SelectedItem;
            sala.EditarSala(txtSala.Text, numericColunas.Value, numericFilas.Value);

            lstSalas.Items[lstSalas.SelectedIndex] = sala;

            MessageBox.Show("Sala editada com sucesso!");

            LimparCampos();
        }

        private void btnEliminarSala_Click(object sender, EventArgs e)
        {
            if (lstSalas.SelectedItem == null)
            {
                MessageBox.Show("Nenhuma sala selecionada para eliminar.");
                return;
            }

            CinemaProjeto.Sala sala = (CinemaProjeto.Sala)lstSalas.SelectedItem;
            sala.RemoverSala(sala);
            lstSalas.Items.Remove(sala);

            LimparCampos();
        }

        private void lstSalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSalas.SelectedItem == null)
            {
                return;
            }

            CinemaProjeto.Sala sala = (CinemaProjeto.Sala)lstSalas.SelectedItem;

            txtSala.Text = sala.Nome;
            numericColunas.Value = sala.Colunas;
            numericFilas.Value = sala.Filas;
        }

        private void LimparCampos()
        {
            txtSala.Text = string.Empty;
            numericColunas.Value = 1;
            numericFilas.Value = 1;
        }
    }
}
