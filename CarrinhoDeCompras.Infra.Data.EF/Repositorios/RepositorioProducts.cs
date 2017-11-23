using System.Collections.Generic;
using CarrinhoDeCompras.Domain.Entidades;
using System.Linq;
using CarrinhoDeCompras.Domain.Interfaces.Repositorios;
using CarrinhoDeCompras.Infra.Data.EF.Repositorios;

namespace CarrinhoDeCompras.Infra.Data.EF.Repositorios
{
    public class RepositorioProducts : RepositorioBase<Products>, IRepositorioProducts
    {
        public IEnumerable<Products> BuscarPorNome(string nome)
        {
            return db.Products.Where(p => p.ProductName == nome);
        }
    }
}
