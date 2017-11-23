using CarrinhoDeCompras.Application.Interfaces;
using CarrinhoDeCompras.Domain.Entidades;
using CarrinhoDeCompras.Domain.Interfaces.Services;

namespace CarrinhoDeCompras.Application.Services
{
    public class AppServiceCustomerDemographics : AppServiceBase<CustomerDemographics>, IAppServiceCustomerDemographics
    {
        private readonly IServiceCustomerDemographics _repositorio;
        public AppServiceCustomerDemographics(IServiceCustomerDemographics repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
