using Application.Commands;
using Application.Requests;
using Domain.Entities;
using Application.Responses;

namespace Application.Handlers.Sample
{
    public interface ICommandHandler<TCommand, TResponse> 
        where TCommand : ICommand
        where TResponse : IResponse
    {
        Task<TResponse> Handle(TCommand command);
    }
}