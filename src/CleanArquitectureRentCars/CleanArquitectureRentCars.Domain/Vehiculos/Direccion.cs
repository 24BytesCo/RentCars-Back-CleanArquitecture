namespace CleanArquitectureRentCars.Domain.Vehiculos
{
    /// <summary>
    /// Representa una dirección postal.
    /// </summary>
    public record Direccion
    (
        /// <summary>
        /// El país de la dirección.
        /// </summary>
        string Pais,

        /// <summary>
        /// El departamento o provincia de la dirección.
        /// </summary>
        string Departamento,

        /// <summary>
        /// El municipio o ciudad de la dirección.
        /// </summary>
        string Municipio,

        /// <summary>
        /// El barrio o sector de la dirección.
        /// </summary>
        string Barrio,

        /// <summary>
        /// La nomenclatura o detalles adicionales de la dirección.
        /// </summary>
        string Nomenclatura
    );
}
