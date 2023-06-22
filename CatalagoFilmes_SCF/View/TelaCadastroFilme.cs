using CatalagoFilmes_SCF.Controller;
using CatalagoFilmes_SCF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalagoFilmes_SCF.View
{
    public partial class TelaCadastroFilme : Form
    {
        public TelaCadastroFilme()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txBox_Filme_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            FIlme.NomeFilme = txBox_Filme.Text;
            FIlme.EstreiaFilme = txBox_Estreia.Text;
            FIlme.DuracaoFilme = txBox_Duracao.Text;
            FIlme.CategoriaFilme = cbBox_Categoria.Text;

            FilmeController cadastro = new FilmeController();
            cadastro.CadastrarFilme();

        }

        private void TelaCadastroFilme_Load(object sender, EventArgs e)
        {

        }
    }
}
