using CarrinhoDeCompras.Domain.Entidades;
using CarrinhoDeCompras.Domain.Interfaces.Repositorios;
using CarrinhoDeCompras.Domain.Interfaces.Services;

namespace CarrinhoDeCompras.Domain.Services
{
    public class ServiceShippers : ServiceBase<Shippers>, IServiceShippers
    {
        private readonly IRepositorioShippers _repositorio;
        public ServiceShippers(IRepositorioShippers repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}