using CarrinhoDeCompras.Domain.Entidades;
using CarrinhoDeCompras.Domain.Interfaces.Repositorios;
using CarrinhoDeCompras.Infra.Data.EF.Repositorios;

namespace CarrinhoDeCompras.Infra.Data.EF.Repositorios
{
    public class RepositorioOrders : RepositorioBase<Orders>, IRepositorioOrders
    {
    }
}
