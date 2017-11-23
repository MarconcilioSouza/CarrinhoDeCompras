using CarrinhoDeCompras.Domain.Entidades;
using CarrinhoDeCompras.Domain.Interfaces.Repositorios;
using CarrinhoDeCompras.Domain.Interfaces.Services;

namespace CarrinhoDeCompras.Domain.Services
{
    public class ServiceEmployees : ServiceBase<Employees>, IServiceEmployees
    {
        private readonly IRepositorioEmployees _repositorio;
        public ServiceEmployees(IRepositorioEmployees repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
