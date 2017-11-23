using CarrinhoDeCompras.Domain.Entidades;
using CarrinhoDeCompras.Domain.Interfaces.Repositorios;
using System.Collections.Generic;
using System.Linq;

namespace CarrinhoDeCompras.Infra.Data.EF.Repositorios
{
    public class RepositorioOrders : RepositorioBase<Orders>, IRepositorioOrders
    {        
    }
}
