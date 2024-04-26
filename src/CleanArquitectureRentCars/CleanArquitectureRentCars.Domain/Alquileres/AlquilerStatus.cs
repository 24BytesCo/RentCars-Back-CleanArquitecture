namespace CleanArquitectureRentCars.Domain.Alquileres
{
    /// <summary>
    /// Enumera los posibles estados de un alquiler.
    /// </summary>
    public enum AlquilerStatus
    {
        /// <summary>
        /// Indica que el alquiler está reservado pero aún no ha sido confirmado.
        /// </summary>
        Reservado = 1,

        /// <summary>
        /// Indica que el alquiler ha sido confirmado y está activo.
        /// </summary>
        Confirmado = 2,

        /// <summary>
        /// Indica que el alquiler ha sido rechazado.
        /// </summary>
        Rechazado = 3,

        /// <summary>
        /// Indica que el alquiler ha sido cancelado antes de su inicio.
        /// </summary>
        Cancelado = 4,

        /// <summary>
        /// Indica que el alquiler ha sido completado y ya no está activo.
        /// </summary>
        Completado = 5
    }
}
