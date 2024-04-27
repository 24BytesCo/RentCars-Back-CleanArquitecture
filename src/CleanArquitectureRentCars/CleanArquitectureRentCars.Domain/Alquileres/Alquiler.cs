using CleanArquitectureRentCars.Domain.Abstractions;
using CleanArquitectureRentCars.Domain.Alquileres.Events;
using CleanArquitectureRentCars.Domain.Vehiculos;
using System;

namespace CleanArquitectureRentCars.Domain.Alquileres
{
    /// <summary>
    /// Representa un alquiler de vehículo.
    /// </summary>
    public sealed class Alquiler : Entity
    {
        /// <summary>
        /// Crea una nueva instancia de Alquiler.
        /// </summary>
        /// <param name="id">El identificador único del alquiler.</param>
        /// <param name="vehiculoId">El identificador del vehículo alquilado.</param>
        /// <param name="usuarioAlquilaId">El identificador del usuario que alquila el vehículo.</param>
        /// <param name="usuarioRegistraId">El identificador del usuario que registra el alquiler.</param>
        /// <param name="precioPeriodo">El precio por período del alquiler.</param>
        /// <param name="precioMantenimiento">El precio de mantenimiento del vehículo durante el alquiler.</param>
        /// <param name="precioAccesorios">El precio de los accesorios adicionales seleccionados durante el alquiler.</param>
        /// <param name="precioTotal">El precio total del alquiler.</param>
        /// <param name="status">El estado del alquiler.</param>
        /// <param name="duracionAlquiler">La duración del alquiler (rango de fechas).</param>
        /// <param name="fechaCreacion">La fecha de creación del alquiler.</param>
        private Alquiler
        (
            Guid id,
            Guid vehiculoId,
            Guid usuarioAlquilaId,
            Guid usuarioRegistraId,
            Moneda? precioPeriodo,
            Moneda? precioMantenimiento,
            Moneda? precioAccesorios,
            Moneda? precioTotal,
            AlquilerStatus status,
            RangoFechas duracionAlquiler,
            DateTime fechaCreacion
        ) : base(id)
        {
            VehiculoId = vehiculoId;
            UsuarioAlquilaId = usuarioAlquilaId;
            UsuarioRegistraId = usuarioRegistraId;
            PrecioPeriodo = precioPeriodo;
            PrecioMantenimiento = precioMantenimiento;
            PrecioAccesorios = precioAccesorios;
            PrecioTotal = precioTotal;
            Status = status;
            DuracionAlquiler = duracionAlquiler;
            FechaCreacion = fechaCreacion;

        }

        /// <summary>
        /// Obtiene el identificador del vehículo alquilado.
        /// </summary>
        public Guid VehiculoId { get; private set; }

        /// <summary>
        /// Obtiene el identificador del usuario que alquila el vehículo.
        /// </summary>
        public Guid UsuarioAlquilaId { get; private set; }

        /// <summary>
        /// Obtiene el identificador del usuario que registra el alquiler.
        /// </summary>
        public Guid UsuarioRegistraId { get; private set; }

        /// <summary>
        /// Obtiene el precio por período del alquiler.
        /// </summary>
        public Moneda? PrecioPeriodo { get; private set; }

        /// <summary>
        /// Obtiene el precio de mantenimiento del vehículo durante el alquiler.
        /// </summary>
        public Moneda? PrecioMantenimiento { get; private set; }

        /// <summary>
        /// Obtiene el precio de los accesorios adicionales seleccionados durante el alquiler.
        /// </summary>
        public Moneda? PrecioAccesorios { get; private set; }

        /// <summary>
        /// Obtiene el precio total del alquiler.
        /// </summary>
        public Moneda? PrecioTotal { get; private set; }

        /// <summary>
        /// Obtiene el estado del alquiler.
        /// </summary>
        public AlquilerStatus Status { get; private set; }

        /// <summary>
        /// Obtiene la duración del alquiler (rango de fechas).
        /// </summary>
        public RangoFechas DuracionAlquiler { get; private set; }

        /// <summary>
        /// Obtiene la fecha de creación del alquiler.
        /// </summary>
        public DateTime FechaCreacion { get; private set; }

        /// <summary>
        /// Obtiene la fecha de confirmación del alquiler.
        /// </summary>
        public DateTime FechaConfirmacion { get; private set; }

        /// <summary>
        /// Obtiene la fecha de denegación del alquiler.
        /// </summary>
        public DateTime FechaDenegacion { get; private set; }

        /// <summary>
        /// Obtiene la fecha de completado del alquiler.
        /// </summary>
        public DateTime FechaCompletado { get; private set; }

        /// <summary>
        /// Obtiene la fecha de cancelación del alquiler.
        /// </summary>
        public DateTime FechaCancelacion { get; private set; }

        //Metodos

        /// <summary>
        /// Reserva un vehículo para alquilar.
        /// </summary>
        /// <param name="vehiculoId">El identificador del vehículo a alquilar.</param>
        /// <param name="usuarioAlquila">El identificador del usuario que alquila el vehículo.</param>
        /// <param name="usuarioRegistra">El identificador del usuario que registra el alquiler.</param>
        /// <param name="precioDetalle">El detalle de precios para el alquiler.</param>
        /// <param name="duracionAlquiler">La duración del alquiler (rango de fechas).</param>
        /// <param name="fechaCreacion">La fecha de creación del alquiler.</param>
        /// <returns>Una nueva instancia de Alquiler reservado.</returns>
        public static Alquiler Reservar
        (
            Vehiculo vehiculo,
            Guid usuarioAlquila,
            Guid usuarioRegistra,
            PrecioService precioService,
            RangoFechas duracionAlquiler,
            DateTime fechaCreacion
        )
        {
            try
            {
                var precioDetalle = precioService.CalcularPrecio(vehiculo, duracionAlquiler);

                var alquiler = new Alquiler
                (
                    Guid.NewGuid(),
                    vehiculo.Id,
                    usuarioAlquila,
                    usuarioRegistra,
                    precioDetalle.PrecioPerido,
                    precioDetalle.PrecioMantenimiento,
                    precioDetalle.PrecioAccesorios,
                    precioDetalle.PrecioTotal,
                    AlquilerStatus.Reservado,
                    duracionAlquiler,
                    fechaCreacion
                );

                // Generando un evento de dominio para indicar que se ha reservado un nuevo vehículo.
                alquiler.RaiseDomainEvent(new AlquilerReservadoDomainEvent(alquiler.Id!));
                vehiculo.UltimoAlquilerFecha = fechaCreacion;

                return alquiler;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Ocurrió un error durante la ejecución.", ex);
                throw new Exception(ex.Message);
            }


        }
    
    public Result Confirmar(DateTime utcNow)
    {
        if (Status != AlquilerStatus.Reservado)
        {
            
        }

    }

    }
}
