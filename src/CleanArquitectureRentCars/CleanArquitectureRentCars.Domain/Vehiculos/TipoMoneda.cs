namespace CleanArquitectureRentCars.Domain.Vehiculos
{
    // Clase que representa un tipo de moneda
    public record TipoMoneda
    {
        // Constantes estáticas para los tipos de moneda más comunes
        public static readonly TipoMoneda Usd = new("USD");
        public static readonly TipoMoneda Eur = new("EUR");
        public static readonly TipoMoneda Cop = new("COP");
        public static readonly TipoMoneda EnBlanco = new("");

        // Constructor privado para evitar la creación de nuevas instancias fuera de la clase
        private TipoMoneda(string codigo) => Codigo = codigo;

        // Propiedad de solo lectura para el código de la moneda, donde init la hace inmutable
        public string? Codigo { get; init; }

        // Obtención de todos los tipos de moneda disponibles
        public static readonly IReadOnlyCollection<TipoMoneda> GetAll = new List<TipoMoneda>
        {
            Usd,
            Eur,
            Cop
        }.AsReadOnly();

        // Método estático para obtener un tipo de moneda por su código
        public static TipoMoneda GetByCodigo(string codigo)
        {
            var tipoMoneda = GetAll.FirstOrDefault(r => r.Codigo == codigo);
            if (tipoMoneda != null)
            {
                return tipoMoneda;
            }
            else
            {
                throw new ArgumentException("Código de moneda inválido.", nameof(codigo));
            }
        }

    }
}
