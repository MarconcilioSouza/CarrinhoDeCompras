using CarrinhoDeCompras.Domain.Entidades;
using CarrinhoDeCompras.Domain.Interfaces.Repositorios;
using CarrinhoDeCompras.Domain.Interfaces.Services;

namespace CarrinhoDeCompras.Domain.Services
{
    public class ServiceOrderDetails : ServiceBase<OrderDetails>, IServiceOrderDetails
    {
        private readonly IRepositorioOrderDetails _repositorio;
        public ServiceOrderDetails(IRepositorioOrderDetails repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}