using CleanArquitectureRentCars.Domain.Vehiculos;

namespace CleanArquitectureRentCars.Domain.Alquileres
{
    /// <summary>
    /// Representa los detalles de precios para un alquiler.
    /// </summary>
    public record PrecioDetalle
    (
        /// <summary>
        /// Obtiene el precio por período del alquiler.
        /// </summary>
        Moneda PrecioPerido,
        
        /// <summary>
        /// Obtiene el precio de mantenimiento del vehículo durante el alquiler.
        /// </summary>
        Moneda PrecioMantenimiento,
        
        /// <summary>
        /// Obtiene el precio de los accesorios adicionales seleccionados durante el alquiler.
        /// </summary>
        Moneda PrecioAccesorios,
        
        /// <summary>
        /// Obtiene el precio total del alquiler.
        /// </summary>
        Moneda PrecioTotal
    );
}
