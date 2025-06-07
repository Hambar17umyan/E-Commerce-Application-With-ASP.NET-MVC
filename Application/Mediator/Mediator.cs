namespace Application.Mediator;

using System.Reflection;

/// <summary>
/// Mediator class that implements the IMediator interface.
/// </summary>
public class Mediator : IMediator
{
    private readonly IServiceProvider _serviceProvider;

    public Mediator(IServiceProvider serviceProvider)
    {
        this._serviceProvider = serviceProvider;
    }

    /// <summary>
    /// Sends a request to the appropriate handler and returns the response.
    /// </summary>
    /// <typeparam name="TResponse"></typeparam>
    /// <param name="request"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    public async Task<TResponse> Send<TResponse>(IRequest<TResponse> request)
    {
        var handlerType = typeof(IRequestHandler<,>)
            .MakeGenericType(request.GetType(), typeof(TResponse));

        dynamic handler = this._serviceProvider.GetService(handlerType)!;

        if (handler == null)
            throw new InvalidOperationException($"Handler not found for {request.GetType().Name}");

        return await handler.HandleAsync((dynamic)request);
    }
}
