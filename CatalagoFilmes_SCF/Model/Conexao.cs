using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalagoFilmes_SCF.Model
{
    internal class Conexao
    {
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\guilherme.pnunes\source\repos\CatalagoFilmes_SCF\CatalagoFilmes_SCF\Model\filmesbd.mdf;Integrated Security=True";
        }
    }
}
