using CarrinhoDeCompras.Domain.Entidades;
using CarrinhoDeCompras.Domain.Interfaces;
using CarrinhoDeCompras.Domain.Interfaces.Repositorios;

namespace CarrinhoDeCompras.Infra.Data.EF.Repositorios
{
    public class RepositorioRegion : RepositorioBase<Region>, IRepositorioRegion
    {
    }
}
