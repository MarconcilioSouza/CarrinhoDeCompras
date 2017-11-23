using CarrinhoDeCompras.Application.Interfaces;
using CarrinhoDeCompras.Domain.Entidades;
using CarrinhoDeCompras.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace CarrinhoDeCompras.Application.Services
{
    public class AppServiceOrders : AppServiceBase<Orders>, IAppServiceOrders
    {
        private readonly IServiceOrders _repositorio;
        public AppServiceOrders(IServiceOrders repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }

        public IEnumerable<Orders> GetOrdersByCustomerID(int customerID)
        {
            return Find(O => O.CustomerID == customerID).ToList();
        }
    }
}