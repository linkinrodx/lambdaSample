using LambdaSample.Core.Models;
using LambdaSample.Core.Models.Requests;

namespace LambdaSample.Core.Services
{
    public interface IDynamoService
    {
        Task<bool> CreateAsync(ParentRequest parent);

        Task<Parent?> GetAsync(int id);
    }
}
