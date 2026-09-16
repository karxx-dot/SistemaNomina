namespace SistemaNomina.Modelos
{
    public class EmpleadoPorComision : Empleado
    {
        public decimal VentasBrutas { get; set; }
        public decimal TarifaComision { get; set; }

        public EmpleadoPorComision(string nombre, string apellido, string nss,
            decimal ventasBrutas, decimal tarifaComision)
            : base(nombre, apellido, nss)
        {
            VentasBrutas = ventasBrutas;
            TarifaComision = tarifaComision;
        }

        public override decimal CalcularPago()
        {
            return VentasBrutas * TarifaComision;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"\nTipo: Empleado por Comisión" +
                   $"\nVentas Brutas: {VentasBrutas:C}" +
                   $"\nTarifa Comisión: {TarifaComision:P}" +
                   $"\nPago: {CalcularPago():C}";
        }
    }
}
