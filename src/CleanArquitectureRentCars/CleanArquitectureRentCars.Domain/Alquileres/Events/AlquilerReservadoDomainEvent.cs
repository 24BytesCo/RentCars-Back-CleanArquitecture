using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArquitectureRentCars.Domain.Abstractions;

namespace CleanArquitectureRentCars.Domain.Alquileres.Events
{
    public sealed record AlquilerReservadoDomainEvent(Guid AlquilerId):IDomainEvent;
}