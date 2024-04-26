
using CleanArquitectureRentCars.Domain.Abstractions;

namespace CleanArquitectureRentCars.Domain.Users.Events
{
    public sealed record UserCreateDomainEvent(Guid UserId): IDomainEvent
    {
        
    }
}