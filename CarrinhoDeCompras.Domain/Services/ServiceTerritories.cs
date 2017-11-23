using CarrinhoDeCompras.Domain.Entidades;
using CarrinhoDeCompras.Domain.Interfaces.Repositorios;
using CarrinhoDeCompras.Domain.Interfaces.Services;

namespace CarrinhoDeCompras.Domain.Services
{
    public class ServiceTerritories : ServiceBase<Territories>, IServiceTerritories
    {
        private readonly IRepositorioTerritories _repositorio;
        public ServiceTerritories(IRepositorioTerritories repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
