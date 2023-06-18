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

        private void btnCriarSala_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSala.Text))
            {
                MessageBox.Show("Nome da Sala Vazio");

                return;
            }

            Sala sala = new Sala(txtSala.Text, numericColunas.Value, numericFilas.Value);
            lstSalas.Items.Add(sala);

            LimparCampos();
        }

        private void btnEditarSala_Click(object sender, EventArgs e)
        {
            if (lstSalas.SelectedItem == null)
            {
                MessageBox.Show("Nenhuma sala selecionada para editar.");
                return;
            }

            Sala sala = (Sala)lstSalas.SelectedItem;
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

            Sala sala = (Sala)lstSalas.SelectedItem;
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

            Sala sala = (Sala)lstSalas.SelectedItem;

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
