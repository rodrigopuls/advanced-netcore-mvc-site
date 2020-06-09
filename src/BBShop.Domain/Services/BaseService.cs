using BBShop.Domain.Common;
using BBShop.Domain.Interfaces;
using BBShop.Domain.Notifications;
using FluentValidation;
using FluentValidation.Results;

namespace BBShop.Domain.Services
{
    public abstract class BaseService
    {
        private readonly INotificator _notificator;

        protected BaseService(INotificator notificator)
        {
            _notificator = notificator;
        }


        protected void Notificar(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Notificar(error.ErrorMessage);
            }
        }

        protected void Notificar(string mensagem)
        {
            _notificator.Handle(new Notification(mensagem));
        }

        protected bool ExecutarValidacao<TValidation, TEntity>(TValidation validacao, TEntity entidade) where TValidation : AbstractValidator<TEntity> where TEntity : Entity
        {
            var validator = validacao.Validate(entidade);

            if (validator.IsValid) return true;

            Notificar(validator);

            return false;
        }

    }
}
