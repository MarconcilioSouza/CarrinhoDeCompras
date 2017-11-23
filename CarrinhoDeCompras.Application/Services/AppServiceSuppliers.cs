using CarrinhoDeCompras.Application.Interfaces;
using CarrinhoDeCompras.Domain.Entidades;
using CarrinhoDeCompras.Domain.Interfaces.Services;

namespace CarrinhoDeCompras.Application.Services
{
    public class AppServiceSuppliers : AppServiceBase<Suppliers>, IAppServiceSuppliers
    {
        private readonly IServiceSuppliers _repositorio;
        public AppServiceSuppliers(IServiceSuppliers repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
