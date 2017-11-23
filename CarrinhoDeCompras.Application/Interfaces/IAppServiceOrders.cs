using CarrinhoDeCompras.Domain.Entidades;
using System.Collections.Generic;

namespace CarrinhoDeCompras.Application.Interfaces
{
    public interface IAppServiceOrders : IAppServiceBase<Orders>
    {
        IEnumerable<Orders> GetOrdersByCustomerID(int customerID);
    }
}
