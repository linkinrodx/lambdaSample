using LambdaSample.Middleware.Models;

namespace LambdaSample.Middleware.Services
{
    public interface ITkambioService
    {
        Task<Parent> GetExchangeRate();
    }
}
