using CleanArquitectureRentCars.Domain.Abstractions;
using CleanArquitectureRentCars.Domain.Vehiculos;
using System;

namespace CleanArquitectureRentCars.Domain.Alquileres
{
    /// <summary>
    /// Representa un alquiler de vehículo.
    /// </summary>
    public sealed class Alquiler : Entity
    {
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
            DateTime fechaCreacion,
            DateTime fechaConfirmacion,
            DateTime fechaDenegacion,
            DateTime fechaCompletado,
            DateTime fechaCancelacion
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
            FechaConfirmacion = fechaConfirmacion;
            FechaDenegacion = fechaDenegacion;
            FechaCompletado = fechaCompletado;
            FechaCancelacion = fechaCancelacion;
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
    }
}
