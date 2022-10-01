using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio.helpers
{
    public class Produto
    {
        public string Nome { get; set; }
        public decimal ValorUnitario { get; set; }
        public int Id { get; set; }
    }

    public class ProdutoService
    {
        public List<Produto> ListagemProdutosFake()
        {
            var lista = new List<Produto>();

            lista.Add(new Produto()
            {
                Id = 34567,
                Nome = "Martelo",
                ValorUnitario = 39.99m

            });
            lista.Add(new Produto()
            {
                Id = 69679,
                Nome = "Parafusadeira",
                ValorUnitario = 77.64m
            });
            lista.Add(new Produto()
            {
                Id = 57907,
                Nome = "Chave De Fenda",
                ValorUnitario = 25.54m
            });
            lista.Add(new Produto()
            {
                Id = 87964,
                Nome = "Alicate",
                ValorUnitario = 42.00m
            });
            return lista;
        }
    }          
    
}
