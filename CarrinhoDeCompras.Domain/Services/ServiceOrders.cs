using CarrinhoDeCompras.Domain.Entidades;
using CarrinhoDeCompras.Domain.Interfaces.Repositorios;
using CarrinhoDeCompras.Domain.Interfaces.Services;

namespace CarrinhoDeCompras.Domain.Services
{
    public class ServiceOrders : ServiceBase<Orders>, IServiceOrders
    {
        private readonly IRepositorioOrders _repositorio;
        public ServiceOrders(IRepositorioOrders repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}