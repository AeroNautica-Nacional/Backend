using AeroMexic.Domain.Share;
using MediatR;
using Microsoft.Extensions.Logging;

namespace AeroMexic.Application.Behaviors
{

    public class LoggingBehavior<TRequest, TResponse>
        : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
        where TResponse : Result
    {
        private readonly ILogger<LoggingBehavior<TRequest, TResponse>> _logger;

        public LoggingBehavior(ILogger<LoggingBehavior<TRequest, TResponse>> logger)
        {
            _logger = logger;
        }

        public Task<TResponse> Handle(
            TRequest request, 
            RequestHandlerDelegate<TResponse> next, 
            CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling {typeof(TRequest).Name} with content: {@Request}", typeof(TRequest).Name, request);
            
            var response = next();

            _logger.LogInformation("Handled {typeof(TRequest).Name} with response: {@Response}", typeof(TRequest).Name, response);
            
            return response;
        }
    }
}
