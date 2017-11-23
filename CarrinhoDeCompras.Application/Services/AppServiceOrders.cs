using CarrinhoDeCompras.Application.Interfaces;
using CarrinhoDeCompras.Domain.Entidades;
using CarrinhoDeCompras.Domain.Interfaces.Services;

namespace CarrinhoDeCompras.Application.Services
{
    public class AppServiceOrders : AppServiceBase<Orders>, IAppServiceOrders
    {
        private readonly IServiceOrders _repositorio;
        public AppServiceOrders(IServiceOrders repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}