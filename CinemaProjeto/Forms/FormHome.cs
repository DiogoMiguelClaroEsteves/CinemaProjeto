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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

  

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            using (var db = new CinemaContext())
            {
                var filmes = db.Filmes.ToList();
                listBoxFilmes.Items.AddRange(filmes.ToArray());

                var salas = db.Salas.ToList();
                listBoxSalas.Items.AddRange(salas.ToArray());
            }


        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
