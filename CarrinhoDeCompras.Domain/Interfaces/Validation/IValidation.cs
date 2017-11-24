using CarrinhoDeCompras.Domain.Validation;

namespace CarrinhoDeCompras.Domain.Interfaces.Validation
{
    public interface IValidation<in TEntity>
    {
        ValidationResult Valid(TEntity entity);
    }
}