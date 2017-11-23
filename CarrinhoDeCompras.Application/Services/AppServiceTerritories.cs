using CarrinhoDeCompras.Application.Interfaces;
using CarrinhoDeCompras.Domain.Entidades;
using CarrinhoDeCompras.Domain.Interfaces.Services;

namespace CarrinhoDeCompras.Application.Services
{
    public class AppServiceTerritories : AppServiceBase<Territories>, IAppServiceTerritories
    {
        private readonly IServiceTerritories _repositorio;
        public AppServiceTerritories(IServiceTerritories repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
