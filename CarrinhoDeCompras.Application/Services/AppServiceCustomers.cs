using CarrinhoDeCompras.Application.Interfaces;
using CarrinhoDeCompras.Domain.Entidades;
using CarrinhoDeCompras.Domain.Interfaces.Services;

namespace CarrinhoDeCompras.Application.Services
{
    public class AppServiceCustomers : AppServiceBase<Customers>, IAppServiceCustomers
    {
        private readonly IServiceCustomers _repositorio;
        public AppServiceCustomers(IServiceCustomers repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
