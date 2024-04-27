using CleanArquitectureRentCars.Domain.Abstractions;

namespace CleanArquitectureRentCars.Domain.Alquileres
{
    /// <summary>
    /// Define errores comunes relacionados con los alquileres.
    /// </summary>
    public static class AlquilerErrors
    {
        /// <summary>
        /// Representa un error que indica que el alquiler especificado no se encontró.
        /// </summary>
        public static Error NotFound = new Error
        (
            "Alquiler.Found",
            "El alquiler con el ID especificado no fue encontrado"
        );

        /// <summary>
        /// Representa un error que indica que el alquiler está siendo tomado por dos o más clientes al mismo tiempo en la misma fecha.
        /// </summary>
        public static Error Overlap = new Error
        (
            "Alquiler.Overlap",
            "El alquiler está siendo tomado por dos o más clientes al mismo tiempo en la misma fecha."
        );

        /// <summary>
        /// Representa un error que indica que el alquiler no está reservado.
        /// </summary>
        public static Error NotReserved = new Error
        (
            "Alquiler.NotReserved",
            "El alquiler no está reservado"
        );

        /// <summary>
        /// Representa un error que indica que el alquiler no está confirmado.
        /// </summary>
        public static Error NotConfirmed = new Error
        (
            "Alquiler.NotConfirmed",
            "El alquiler no está confirmado"
        );

        /// <summary>
        /// Representa un error que indica que el alquiler ya ha comenzado.
        /// </summary>
        public static Error AlreadyStarted = new Error
        (
            "Alquiler.AlreadyStarted",
            "El alquiler ya ha comenzado"
        );

        /// <summary>
        /// Representa un error que indica que se proporcionó una fecha de alquiler inválida.
        /// </summary>
        public static Error InvalidStartDate = new Error
        (
            "Alquiler.InvalidStartDate",
            "La fecha de inicio del alquiler es inválida"
        );

        /// <summary>
        /// Representa un error que indica que se proporcionó una fecha de alquiler que se superpone con otro alquiler existente.
        /// </summary>
        public static Error OverlappingRentals = new Error
        (
            "Alquiler.OverlappingRentals",
            "El alquiler se superpone con otro alquiler existente"
        );

        /// <summary>
        /// Representa un error que indica que el usuario no tiene permiso para realizar la acción solicitada.
        /// </summary>
        public static Error AccessDenied = new Error
        (
            "Alquiler.AccessDenied",
            "Acceso denegado para realizar la acción solicitada"
        );

        /// <summary>
        /// Representa un error que indica que algunos campos obligatorios no se proporcionaron al crear o actualizar un alquiler.
        /// </summary>
        public static Error MissingFields = new Error
        (
            "Alquiler.MissingFields",
            "Faltan campos obligatorios para crear o actualizar el alquiler"
        );

        /// <summary>
        /// Representa un error que indica que se intentó crear un alquiler duplicado.
        /// </summary>
        public static Error DuplicateRental = new Error
        (
            "Alquiler.DuplicateRental",
            "Se intentó crear un alquiler duplicado"
        );

        /// <summary>
        /// Representa un error que indica un problema de comunicación con servicios externos o sistemas durante el proceso de alquiler.
        /// </summary>
        public static Error CommunicationError = new Error
        (
            "Alquiler.CommunicationError",
            "Se produjo un error de comunicación con servicios externos o sistemas"
        );
    }
}
