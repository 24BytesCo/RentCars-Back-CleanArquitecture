namespace CleanArquitectureRentCars.Domain.Users
{
    /// <summary>
    /// Define las operaciones que pueden realizarse sobre un repositorio de usuarios.
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Obtiene un usuario por su identificador de forma asincrónica.
        /// </summary>
        /// <param name="id">El identificador único del usuario.</param>
        /// <param name="cancellationToken">El token de cancelación opcional.</param>
        /// <returns>Una tarea que representa la operación asincrónica. El resultado es el usuario encontrado.</returns>
        Task<User> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Agrega un nuevo usuario al repositorio.
        /// </summary>
        /// <param name="user">El usuario que se va a agregar.</param>
        void Add(User user);
    }
}
