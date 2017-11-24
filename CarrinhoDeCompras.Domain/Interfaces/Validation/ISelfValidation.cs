using CarrinhoDeCompras.Domain.Validation;

namespace CarrinhoDeCompras.Domain.Interfaces.Validation
{
    public interface ISelfValidation
    {
        ValidationResult ValidationResult { get; }
        bool IsValid { get; }
    }
}