namespace CleanArquitectureRentCars.Domain.Abstractions
{
    /// <summary>
    /// Representa un error en el sistema.
    /// </summary>
    public record Error(string Code, string Name)
    {
        /// <summary>
        /// Representa un error sin información.
        /// </summary>
        public static Error None = new(string.Empty, string.Empty);

        /// <summary>
        /// Representa un error relacionado con un valor nulo.
        /// </summary>
        public static Error NullValue = new("Error.NullValue", "Un valor null fue ingresado");
    }
}
