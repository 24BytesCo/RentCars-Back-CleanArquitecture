using System;

namespace CleanArquitectureRentCars.Domain.Alquileres
{
    /// <summary>
    /// Representa un rango de fechas para un alquiler.
    /// </summary>
    public sealed record RangoFechas
    {
        private RangoFechas()
        {
        }

        /// <summary>
        /// Obtiene la fecha de inicio del rango.
        /// </summary>
        public DateOnly FechaInicio { get; init; }

        /// <summary>
        /// Obtiene la fecha de fin del rango.
        /// </summary>
        public DateOnly FechaFin { get; init; }

        /// <summary>
        /// Obtiene la cantidad de días entre la fecha de inicio y la fecha de fin del rango.
        /// </summary>
        public int CantidadDias => FechaFin.DayNumber - FechaInicio.DayNumber;

        /// <summary>
        /// Crea una nueva instancia de RangoFechas con las fechas de inicio y fin especificadas.
        /// </summary>
        /// <param name="fechaInicio">La fecha de inicio del rango.</param>
        /// <param name="fechaFin">La fecha de fin del rango.</param>
        /// <returns>Una nueva instancia de RangoFechas.</returns>
        /// <exception cref="ArgumentException">Se lanza si la fecha de fin es anterior a la fecha de inicio.</exception>
        public static RangoFechas Create(DateOnly fechaInicio, DateOnly fechaFin)
        {
            if (fechaInicio > fechaFin)
            {
                throw new ArgumentException("La fecha final es anterior a la fecha inicial de alquiler");
            }
            return new RangoFechas()
            {
                FechaInicio = fechaInicio,
                FechaFin = fechaFin
            };
        }
    }
}
