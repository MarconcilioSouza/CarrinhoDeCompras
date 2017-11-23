using CarrinhoDeCompras.Application.Interfaces;
using CarrinhoDeCompras.Domain.Entidades;
using CarrinhoDeCompras.Domain.Interfaces.Services;

namespace CarrinhoDeCompras.Application.Services
{
    public class AppServiceEmployees : AppServiceBase<Employees>, IAppServiceEmployees
    {
        private readonly IServiceEmployees _repositorio;
        public AppServiceEmployees(IServiceEmployees repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
