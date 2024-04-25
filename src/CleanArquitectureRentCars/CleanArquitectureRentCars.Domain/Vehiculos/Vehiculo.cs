
using CleanArquitectureRentCars.Domain.Abstractions;

namespace CleanArquitectureRentCars.Domain.Vehiculos
{
    public sealed class Vehiculo(Guid id) : Entity(id)
    {
        public string? Modelo { get; private set; }
        public string? Vin { get; private set; }
        public string? Calle { get; private set; }
        public string? Municipio { get; private set; }
        public string? Departamento { get; private set; }
        public string? Pais { get; private set; }
        public decimal AlquilerPrecio { get; private set; }
        public string? AlquilerTipoMoneda { get; private set; }
        public decimal MantenimientoPrecio { get; private set; }
        public string? MantenimientoTipoMoneda { get; private set; }
        public DateTime? UltimoAlquilerFecha { get; private set; }
        public List<Accesorio> Accesorios { get; private set; } = new();

    }
}