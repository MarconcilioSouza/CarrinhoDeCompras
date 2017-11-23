using CarrinhoDeCompras.Domain.Entidades;
using System.Collections.Generic;

namespace CarrinhoDeCompras.Application.Interfaces
{
    public interface IAppServiceProducts : IAppServiceBase<Products>
    {
        IEnumerable<Products> BuscarPorNome(string nome);
    }
}
