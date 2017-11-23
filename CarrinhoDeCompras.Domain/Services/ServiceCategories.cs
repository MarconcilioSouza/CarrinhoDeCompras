using CarrinhoDeCompras.Domain.Entidades;
using CarrinhoDeCompras.Domain.Interfaces.Repositorios;
using CarrinhoDeCompras.Domain.Interfaces.Services;

namespace CarrinhoDeCompras.Domain.Services
{
    public class ServiceCategories : ServiceBase<Categories>, IServiceCategories
    {
        private readonly IRepositorioCategories _repositorio;
        public ServiceCategories(IRepositorioCategories repositorio) 
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
