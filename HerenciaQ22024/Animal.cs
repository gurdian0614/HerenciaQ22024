
namespace HerenciaQ22024
{
    public class Animal
    {
        /// <summary>
        /// Nombre del Animal
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Color del Animal
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Tamaño del Animal
        /// </summary>
        public string Tamano { get; set; }

        /// <summary>
        /// Familia del Animal
        /// </summary>
        public Familia Familia { get; set; }

        // Constructor
        public Animal()
        {
            Familia = new Familia();
        }

    }
}
