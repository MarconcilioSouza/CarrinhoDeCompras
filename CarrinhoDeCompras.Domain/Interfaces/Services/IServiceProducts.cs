using CarrinhoDeCompras.Domain.Entidades;
using System.Collections.Generic;

namespace CarrinhoDeCompras.Domain.Interfaces.Services
{
    public interface IServiceProducts : IServiceBase<Products>
    {
        IEnumerable<Products> BuscarPorNome(string nome);
    }
}
