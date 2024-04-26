namespace CleanArquitectureRentCars.Domain.Abstractions
{
    /// <summary>
    /// Define las operaciones que pueden realizarse en una unidad de trabajo.
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Guarda los cambios realizados en la unidad de trabajo de forma asincrónica.
        /// </summary>
        /// <param name="cancellationToken">El token de cancelación opcional.</param>
        /// <returns>Una tarea que representa la operación asincrónica. El resultado es el número de entidades afectadas.</returns>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
