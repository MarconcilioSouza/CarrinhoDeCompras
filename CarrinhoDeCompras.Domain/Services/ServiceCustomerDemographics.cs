using CarrinhoDeCompras.Domain.Entidades;
using CarrinhoDeCompras.Domain.Interfaces.Repositorios;
using CarrinhoDeCompras.Domain.Interfaces.Services;

namespace CarrinhoDeCompras.Domain.Services
{
    public class ServiceCustomerDemographics : ServiceBase<CustomerDemographics>, IServiceCustomerDemographics
    {
        private readonly IRepositorioCustomerDemographics _repositorio;
        public ServiceCustomerDemographics(IRepositorioCustomerDemographics repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
