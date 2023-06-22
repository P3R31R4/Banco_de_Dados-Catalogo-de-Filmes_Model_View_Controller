using CatalagoFilmes_SCF.Model;
using CatalagoFilmes_SCF.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CatalagoFilmes_SCF.Controller
{
    internal class FilmeController
    {
        public void CadastrarFilme()
        {
            SqlConnection cn  = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("InserirFilmeP", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nome", FIlme.NomeFilme);
                cmd.Parameters.AddWithValue("@estreia", FIlme.EstreiaFilme);
                cmd.Parameters.AddWithValue("@categoria", FIlme.CategoriaFilme);
                cmd.Parameters.AddWithValue("@duracao", FIlme.DuracaoFilme);

                SqlParameter nv = cmd.Parameters.Add("@id", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Filme cadastrado com sucesso, Deseja Cadastrar outro Filme?",
                    "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    TelaCadastroFilme TelaFilme = new TelaCadastroFilme();
                    TelaFilme.Show();
                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
