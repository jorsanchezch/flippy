using Domain.Entities;
using Application.Requests;

namespace Application.Mappers
{
    public interface IMapper<TEntity, TRequest> 
        where TEntity : IEntity
        where TRequest : IRequest
    {
        TEntity Map(TRequest request);
    }
}
