namespace CleanArquitectureRentCars.Domain.Vehiculos
{
    /// <summary>
    /// Representa una cantidad de dinero junto con su tipo de moneda.
    /// </summary>
    public record Moneda(decimal Monto, TipoMoneda TipoMoneda)
    {
        /// <summary>
        /// Sobrecarga del operador de suma para sumar dos instancias de Moneda.
        /// </summary>
        /// <param name="primero">La primera moneda a sumar.</param>
        /// <param name="segundo">La segunda moneda a sumar.</param>
        /// <returns>Una nueva instancia de Moneda que representa la suma de las dos monedas.</returns>
        /// <exception cref="ArgumentException">Se lanza si las monedas tienen diferentes tipos de moneda.</exception>
        public static Moneda operator +(Moneda primero, Moneda segundo)
        {
            if (primero.TipoMoneda != segundo.TipoMoneda)
            {
                throw new ArgumentException("El tipo de moneda debe ser el mismo");
            }

            return new Moneda(primero.Monto + segundo.Monto, primero.TipoMoneda);
        }

        /// <summary>
        /// Crea una nueva instancia de Moneda con un monto de cero y un tipo de moneda en blanco.
        /// </summary>
        /// <returns>Una nueva instancia de Moneda con un monto de cero y un tipo de moneda en blanco.</returns>
        public static Moneda Cero() => new Moneda(0, TipoMoneda.EnBlanco);

        /// <summary>
        /// Crea una nueva instancia de Moneda con un monto de cero y el tipo de moneda especificado.
        /// </summary>
        /// <param name="tipoMoneda">El tipo de moneda para la nueva instancia de Moneda.</param>
        /// <returns>Una nueva instancia de Moneda con un monto de cero y el tipo de moneda especificado.</returns>
        public static Moneda Cero(TipoMoneda tipoMoneda) => new Moneda(0, tipoMoneda);

        /// <summary>
        /// Verifica si la moneda actual tiene un monto de cero.
        /// </summary>
        /// <returns>True si la moneda actual tiene un monto de cero, de lo contrario, false.</returns>
        public bool IsCero() => this == Cero(TipoMoneda.EnBlanco);
    }
}
