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
            if (string.IsNullOrEmpty(txtSala.Text) || string.IsNullOrEmpty(numericColunas.Text) || string.IsNullOrEmpty(numericFilas.Text))
            {
                return;
            }

            Sala sala = new Sala(txtSala.Text, numericColunas.Value, numericFilas.Value);
            lstSalas.Items.Add(sala);
        }
    }
}
