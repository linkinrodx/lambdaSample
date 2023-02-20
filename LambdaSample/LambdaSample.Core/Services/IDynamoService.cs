using LambdaSample.Core.Models;

namespace LambdaSample.Core.Services
{
    public interface IDynamoService
    {
        Task<bool> CreateAsync(Parent parent);

        Task<Parent?> GetAsync(Guid id);
    }
}
