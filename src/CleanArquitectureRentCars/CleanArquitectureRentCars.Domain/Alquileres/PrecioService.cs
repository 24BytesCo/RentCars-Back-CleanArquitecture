using CleanArquitectureRentCars.Domain.Vehiculos;

namespace CleanArquitectureRentCars.Domain.Alquileres
{
    /// <summary>
    /// Servicio para calcular precios relacionados con alquileres.
    /// </summary>
    public class PrecioService
    {
        /// <summary>
        /// Calcula el detalle de precios para un alquiler específico.
        /// </summary>
        /// <param name="vehiculo">El vehículo que se va a alquilar.</param>
        /// <param name="rangoFecha">El rango de fechas del alquiler.</param>
        /// <returns>El detalle de precios calculado para el alquiler.</returns>
        public static PrecioDetalle CalcularPrecio(Vehiculo vehiculo, RangoFechas rangoFecha)
        {
            var tipoMoneda = vehiculo.AlquilerPrecio!.TipoMoneda;

            // Calcula el precio por período del alquiler.
            var precioPeriodo = new Moneda(rangoFecha.CantidadDias * vehiculo.AlquilerPrecio.Monto, tipoMoneda);

            // Calcula el cargo por accesorios adicionales.
            decimal adicionPorcentaje = 0;

            // Itera a través de cada accesorio asociado al vehículo
            foreach (var accesorio in vehiculo.Accesorios)
            {
                // Dependiendo del tipo de accesorio, se agrega un porcentaje adicional al precio
                adicionPorcentaje += accesorio switch
                {
                    // Si el accesorio es AppleCar o AndroidCar, se agrega un 5% al precio
                    Accesorio.AppleCar or Accesorio.AndroidCar => 0.05m,
                    // Si el accesorio es AireAcondicionado o Mapas, se agrega un 1% al precio
                    Accesorio.AireAcondicionado or Accesorio.Mapas => 0.01m,
                    // Para cualquier otro tipo de accesorio, no se agrega ningún porcentaje adicional
                    _ => 0
                };
            }

            var cargoAccesorios = Moneda.Cero(tipoMoneda);

            if (adicionPorcentaje > 0)
            {
                cargoAccesorios = new Moneda(precioPeriodo.Monto * adicionPorcentaje, tipoMoneda);
            }

            // Calcula el precio total sumando el precio por período, el precio de mantenimiento y el cargo por accesorios.
            var precioTotal = Moneda.Cero(tipoMoneda);
            precioTotal += precioPeriodo;

            if (!vehiculo.MantenimientoPrecio!.IsCero())
            {
                precioTotal += vehiculo.MantenimientoPrecio;
            }

            precioTotal += cargoAccesorios;

            // Devuelve el detalle de precios calculado.
            return new PrecioDetalle(precioPeriodo, vehiculo.MantenimientoPrecio, cargoAccesorios, precioTotal);
        }
    }
}
