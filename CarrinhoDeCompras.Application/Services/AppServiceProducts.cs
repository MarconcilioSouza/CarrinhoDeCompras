using System.Collections.Generic;
using CarrinhoDeCompras.Domain.Entidades;
using CarrinhoDeCompras.Domain.Interfaces.Services;
using CarrinhoDeCompras.Application.Interfaces;

namespace CarrinhoDeCompras.Application.Services
{
    public class AppServiceProducts : AppServiceBase<Products>, IAppServiceProducts
    {
        private readonly IServiceProducts _repositorio;
        public AppServiceProducts(IServiceProducts repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }

        public IEnumerable<Products> BuscarPorNome(string nome)
        {
            return _repositorio.BuscarPorNome(nome);
        }
    }
}