using BBShop.Domain.Entities;
using BBShop.Domain.Enum;
using BBShop.Domain.Validations.Documentos;
using FluentValidation;

namespace BBShop.Domain.Validations
{
    public class FornecedorValidation : AbstractValidator<Fornecedor>
    {
        public FornecedorValidation()
        {
            RuleFor(f => f.Nome)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido.")
                .Length(2, 100).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres.");

            When(f => f.TipoFornecedor == TipoFornecedor.PessoaFisica, () =>
            {
                RuleFor(f => f.Documento.Length).Equal(CpfValidacao.TamanhoCpf)
                    .WithMessage("O campo documento precisa ter {ComparisonValue} caracteres e for fornecido {PropertyValue}.");

                RuleFor(f => CpfValidacao.Validar(f.Documento))
                    .Equal(true)
                    .WithMessage("O documento fornecido é inválido.");
            });

            When(f => f.TipoFornecedor == TipoFornecedor.PessoaJuridica, () =>
            {
                RuleFor(f => f.Documento.Length).Equal(CnpjValidacao.TamanhoCnpj)
                    .WithMessage("O campo documento precisa ter {ComparisonValue} caracteres e for fornecido {PropertyValue}.");

                RuleFor(f => CnpjValidacao.Validar(f.Documento))
                .Equal(true)
                    .WithMessage("O documento fornecido é inválido.");
            });
        }
    }
}
