using CarrinhoDeCompras.Domain.Entidades;
using CarrinhoDeCompras.Domain.Interfaces.Repositorios;
using CarrinhoDeCompras.Domain.Interfaces.Services;

namespace CarrinhoDeCompras.Domain.Services
{
    public class ServiceSuppliers : ServiceBase<Suppliers>, IServiceSuppliers
    {
        private readonly IRepositorioSuppliers _repositorio;
        public ServiceSuppliers(IRepositorioSuppliers repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
