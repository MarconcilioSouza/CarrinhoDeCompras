using CarrinhoDeCompras.Domain.Entidades;
using CarrinhoDeCompras.Domain.Interfaces.Repositorios;

namespace CarrinhoDeCompras.Infra.Data.EF.Repositorios
{
    public class RepositorioCategories : RepositorioBase<Categories>, IRepositorioCategories
    {
    }
}
