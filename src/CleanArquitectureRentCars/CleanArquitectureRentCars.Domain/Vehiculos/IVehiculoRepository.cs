namespace CleanArquitectureRentCars.Domain.Vehiculos
{
    /// <summary>
    /// Define las operaciones que pueden realizarse sobre un repositorio de vehículos.
    /// </summary>
    public interface IVehiculoRepository
    {
        /// <summary>
        /// Obtiene un vehículo por su identificador de forma asincrónica.
        /// </summary>
        /// <param name="id">El identificador único del vehículo.</param>
        /// <param name="cancellationToken">El token de cancelación opcional.</param>
        /// <returns>Una tarea que representa la operación asincrónica. El resultado es el vehículo encontrado.</returns>
        Task<Vehiculo> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
