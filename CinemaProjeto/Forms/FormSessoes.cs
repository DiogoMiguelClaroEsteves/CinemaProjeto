﻿using System;
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
    public partial class FormSessoes : Form
    {
        public FormSessoes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPreco.Text))
            {
                MessageBox.Show("Tem de preencher o campo do Preço");

                return;
            }

            var novaSessao = new CinemaProjeto.Sessao()
            {
                DataHora = dateTimePicker.Value,
                preco = textBoxPreco.Text,               
            };

            using (var db = new CinemaContext())
            {
                db.Sessoes.Add(novaSessao);
                db.SaveChanges();
            }

            listBoxSessoes.Items.Add(novaSessao);

            LimparCampos();
        }

        private void FormSessoes_Load(object sender, EventArgs e)
        {
            using (var db = new CinemaContext())
            {
                var sessoes = db.Sessoes.ToList();
                listBoxSessoes.Items.AddRange(sessoes.ToArray());
            }
        }

        private void listBoxSessoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSessoes.SelectedItem == null)
            {
                return;
            }

            CinemaProjeto.Sessao sessao = (CinemaProjeto.Sessao)listBoxSessoes.SelectedItem;

            dateTimePicker.Value = sessao.DataHora;
            textBoxPreco.Text = sessao.preco;
        }

        private void btnEliminarSessao_Click(object sender, EventArgs e)
        {
            if (listBoxSessoes.SelectedItem == null)
            {
                MessageBox.Show("Nenhum sessão selecionado para eliminar.");
                return;
            }

            CinemaProjeto.Sessao sessao = (CinemaProjeto.Sessao)listBoxSessoes.SelectedItem;
            sessao.RemoverSessao(sessao);
            listBoxSessoes.Items.Remove(sessao);

            LimparCampos();
        }

        private void btnEditarSessao_Click(object sender, EventArgs e)
        {
            if (listBoxSessoes.SelectedItem == null)
            {
                MessageBox.Show("Nenhuma sessão selecionada para editar.");
                return;
            }

            CinemaProjeto.Sessao sessao = (CinemaProjeto.Sessao)listBoxSessoes.SelectedItem;
            sessao.EditarSessao(dateTimePicker.Value, textBoxPreco.Text);

            listBoxSessoes.Items[listBoxSessoes.SelectedIndex] = sessao;

            MessageBox.Show("Sala editada com sucesso!");

            LimparCampos();
        }

        private void LimparCampos()
        {
            textBoxPreco.Text = string.Empty;
        }
    }
}
