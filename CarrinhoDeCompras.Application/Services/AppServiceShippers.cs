using CarrinhoDeCompras.Application.Interfaces;
using CarrinhoDeCompras.Domain.Entidades;
using CarrinhoDeCompras.Domain.Interfaces.Services;

namespace CarrinhoDeCompras.Application.Services
{
    public class AppServiceShippers : AppServiceBase<Shippers>, IAppServiceShippers
    {
        private readonly IServiceShippers _repositorio;
        public AppServiceShippers(IServiceShippers repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}