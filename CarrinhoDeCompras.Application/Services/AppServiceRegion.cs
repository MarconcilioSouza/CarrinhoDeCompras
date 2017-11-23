using CarrinhoDeCompras.Application.Interfaces;
using CarrinhoDeCompras.Domain.Entidades;
using CarrinhoDeCompras.Domain.Interfaces.Services;

namespace CarrinhoDeCompras.Application.Services
{
    public class AppServiceRegion : AppServiceBase<Region>, IAppServiceRegion
    {
        private readonly IServiceRegion _repositorio;
        public AppServiceRegion(IServiceRegion repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}