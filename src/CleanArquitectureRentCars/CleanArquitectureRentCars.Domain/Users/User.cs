using CleanArquitectureRentCars.Domain.Abstractions;
using System;

namespace CleanArquitectureRentCars.Domain.Users
{
    /// <summary>
    /// Representa un usuario.
    /// </summary>
    public sealed class User : Entity
    {
        private User
        (
            Guid id,
            Nombre nombre,
            Apellido apellido,
            Email email
        ) : base(id)
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
        }

        /// <summary>
        /// Obtiene o establece el nombre del usuario.
        /// </summary>
        public Nombre? Nombre { get; private set; }

        /// <summary>
        /// Obtiene o establece el apellido del usuario.
        /// </summary>
        public Apellido? Apellido { get; private set; }

        /// <summary>
        /// Obtiene o establece el correo electrónico del usuario.
        /// </summary>
        public Email? Email { get; private set; }

        /// <summary>
        /// Crea una nueva instancia de User.
        /// </summary>
        /// <param name="nombre">El nombre del usuario.</param>
        /// <param name="apellido">El apellido del usuario.</param>
        /// <param name="email">El correo electrónico del usuario.</param>
        /// <returns>Una nueva instancia de User.</returns>
        public static User Create(
            Nombre nombre,
            Apellido apellido,
            Email email
        )
        {
            return new User(Guid.NewGuid(), nombre, apellido, email);
        }
    }
}
