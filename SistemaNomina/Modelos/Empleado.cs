namespace SistemaNomina.Modelos
{
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nss { get; set; }

        protected Empleado(string nombre, string apellido, string nss)
        {
            Nombre = nombre;
            Apellido = apellido;
            Nss = nss;
        }

        // Cada tipo de empleado calcula su pago de forma distinta (RF-2)
        public abstract decimal CalcularPago();

        public override string ToString()
        {
            return $"Nombre: {Nombre} {Apellido}\nNSS: {Nss}";
        }
    }
}
