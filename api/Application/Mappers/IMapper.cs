using Domain.Entities;
using Application.Requests;
using Application.Responses;

namespace Application.Mappers
{
    public interface IMapper<TEntity, TRequest, TResponse> 
        where TEntity : IEntity
        where TRequest : IRequest
        where TResponse : IResponse
    {
        TEntity Map(TRequest request);
        TResponse ToResponse(TEntity entity);
        IEnumerable<TResponse> ToResponse(IEnumerable<TEntity> entity);

    }
}
