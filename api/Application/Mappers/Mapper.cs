using Domain.Entities;
using Application.Requests;
using Application.Responses;

namespace Application.Mappers
{
    abstract public class Mapper<TEntity, TRequest, TResponse> : IMapper<TEntity, TRequest, TResponse>
        where TEntity : IEntity
        where TRequest : IRequest
        where TResponse : IResponse
    {
        public abstract TEntity Map(TRequest request);
        public abstract TResponse ToResponse(TEntity entity);
        public IEnumerable<TResponse> ToResponse(IEnumerable<TEntity> entities)
        {
            foreach (var item in entities)
            {
                yield return ToResponse(item);
            }
        }

        public IEnumerable<TEntity> Map(IEnumerable<TRequest> requests)
        {
            foreach (var item in requests)
            {
                yield return Map(item);
            }
        }

    }
}
