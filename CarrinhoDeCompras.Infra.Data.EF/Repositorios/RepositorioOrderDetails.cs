using CarrinhoDeCompras.Domain.Entidades;
using CarrinhoDeCompras.Domain.Interfaces.Repositorios;
using CarrinhoDeCompras.Infra.Data.EF.Repositorios;

namespace CarrinhoDeCompras.Infra.Data.EF.Repositorios
{
    public class RepositorioOrderDetails : RepositorioBase<OrderDetails>, IRepositorioOrderDetails
    {
    }
}
