using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio.helpers
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public int Id { get; set; }
    }

    public class FuncionarioService
    {
        public List<Funcionario> ListagemFuncionarioFake()
        {
            var lista = new List<Funcionario>();

            lista.Add(new Funcionario()
            {
                Id = 98869765,
                Nome = "João Vitor",

            });
            lista.Add(new Funcionario()
            {
                Id = 1093057,
                Nome = "Amanda Rocha",

            });
            lista.Add(new Funcionario()
            {
                Id = 86739575,
                Nome = "Neymar Junior"

            });
            lista.Add(new Funcionario()
            {
                Id = 39859380,
                Nome = "vitoria Campos"
            });
            return lista;
        }
    }
}









