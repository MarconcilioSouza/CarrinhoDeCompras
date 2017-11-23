using CarrinhoDeCompras.Application.Interfaces;
using CarrinhoDeCompras.Domain.Entidades;
using CarrinhoDeCompras.Domain.Interfaces.Services;

namespace CarrinhoDeCompras.Application.Services
{
    public class AppServiceOrderDetails : AppServiceBase<OrderDetails>, IAppServiceOrderDetails
    {
        private readonly IServiceOrderDetails _repositorio;
        public AppServiceOrderDetails(IServiceOrderDetails repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}