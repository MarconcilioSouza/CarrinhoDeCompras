using CarrinhoDeCompras.Domain.Entidades;
using CarrinhoDeCompras.Domain.Interfaces.Repositorios;
using CarrinhoDeCompras.Domain.Interfaces.Services;

namespace CarrinhoDeCompras.Domain.Services
{
    public class ServiceCustomers : ServiceBase<Customers>, IServiceCustomers
    {
        private readonly IRepositorioCustomers _repositorio;
        public ServiceCustomers(IRepositorioCustomers repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
