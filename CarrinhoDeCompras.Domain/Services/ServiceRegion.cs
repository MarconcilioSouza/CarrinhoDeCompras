using CarrinhoDeCompras.Domain.Entidades;
using CarrinhoDeCompras.Domain.Interfaces.Repositorios;
using CarrinhoDeCompras.Domain.Interfaces.Services;

namespace CarrinhoDeCompras.Domain.Services
{
    public class ServiceRegion : ServiceBase<Region>, IServiceRegion
    {
        private readonly IRepositorioRegion _repositorio;
        public ServiceRegion(IRepositorioRegion repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}