using FluentValidation;
using MediatR;

namespace AeroMexic.Application.Behaviors
{
    public class ValidationBehavior<TRequest, TResponse>
        : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;
        public readonly RequestHandlerDelegate<TResponse> _next;

        public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators, RequestHandlerDelegate<TResponse> next)
        {
            _validators = validators;
            _next = next;
        }

        public Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var validationResults = _validators.Select(v => v.Validate(request)).ToList();
            var failures = validationResults.SelectMany(r => r.Errors).ToList();

            if (failures.Any())
            {
                _validators.FirstOrDefault()?.Validate(request);
            }

            return _next();
        }
    }
}
