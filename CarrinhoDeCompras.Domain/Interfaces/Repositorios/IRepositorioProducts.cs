using CarrinhoDeCompras.Domain.Entidades;
using System.Collections.Generic;

namespace CarrinhoDeCompras.Domain.Interfaces.Repositorios
{
    public interface IRepositorioProducts : IRepositorioBase<Products>
    {
        IEnumerable<Products> BuscarPorNome(string nome);
    }
}
