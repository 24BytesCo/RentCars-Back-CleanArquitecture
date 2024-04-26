
using CleanArquitectureRentCars.Domain.Abstractions;

namespace CleanArquitectureRentCars.Domain.Alquileres
{
    public sealed class Alquiler : Entity
    {
        public Alquiler(Guid id) : base(id)
        {}

        public AlquilerStatus Status { get;  private set; }
        

    }
}