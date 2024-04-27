using CleanArquitectureRentCars.Domain.Abstractions;

namespace CleanArquitectureRentCars.Domain.Vehiculos
{
    /// <summary>
    /// Representa un vehículo.
    /// </summary>
    public sealed class Vehiculo : Entity
    {

        /// <summary>
        /// Crea una nueva instancia de Vehiculo.
        /// </summary>
        /// <param name="id">El identificador único del vehículo.</param>
        /// <param name="modelo">El modelo del vehículo.</param>
        /// <param name="vin">El número de identificación del vehículo (VIN).</param>
        /// <param name="alquilerPrecio">El precio de alquiler del vehículo.</param>
        /// <param name="mantenimientoPrecio">El precio de mantenimiento del vehículo.</param>
        /// <param name="ultimoAlquilerFecha">La fecha del último alquiler del vehículo.</param>
        /// <param name="accesorios">La lista de accesorios asociados al vehículo.</param>
        /// <param name="direccion">La dirección asociada al vehículo.</param>
        public Vehiculo(
            Guid id,
            Modelo modelo,
            Vin vin,
            Moneda alquilerPrecio,
            Moneda mantenimientoPrecio,
            DateTime ultimoAlquilerFecha,
            List<Accesorio> accesorios,
            Direccion direccion
            ) : base(id)
        {
            Modelo = modelo;
            Vin = vin;
            AlquilerPrecio = alquilerPrecio;
            MantenimientoPrecio = mantenimientoPrecio;
            UltimoAlquilerFecha = ultimoAlquilerFecha;
            Accesorios = accesorios;
            Direccion = direccion;
        }

        /// <summary>
        /// Obtiene o establece el modelo del vehículo.
        /// </summary>
        public Modelo? Modelo { get; private set; }

        /// <summary>
        /// Obtiene o establece el número de identificación del vehículo (VIN).
        /// </summary>
        public Vin? Vin { get; private set; }

        /// <summary>
        /// Obtiene o establece la dirección asociada al vehículo.
        /// </summary>
        public Direccion? Direccion { get; private set; }

        /// <summary>
        /// Obtiene o establece el precio de alquiler del vehículo.
        /// </summary>
        public Moneda? AlquilerPrecio { get; private set; }

        /// <summary>
        /// Obtiene o establece el precio de mantenimiento del vehículo.
        /// </summary>
        public Moneda? MantenimientoPrecio { get; private set; }

        /// <summary>
        /// Obtiene o establece la fecha del último alquiler del vehículo.
        /// </summary>
        public DateTime? UltimoAlquilerFecha { get; internal set; }

        /// <summary>
        /// Obtiene la lista de accesorios asociados al vehículo.
        /// </summary>
        public List<Accesorio> Accesorios { get; private set; } = new();

    }
}


