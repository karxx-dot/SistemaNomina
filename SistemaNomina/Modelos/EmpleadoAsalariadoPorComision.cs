namespace SistemaNomina.Modelos
{
    public class EmpleadoAsalariadoPorComision : EmpleadoPorComision
    {
        public decimal SalarioBase { get; set; }

        public EmpleadoAsalariadoPorComision(string nombre, string apellido, string nss,
            decimal ventasBrutas, decimal tarifaComision, decimal salarioBase)
            : base(nombre, apellido, nss, ventasBrutas, tarifaComision)
        {
            SalarioBase = salarioBase;
        }

        public override decimal CalcularPago()
        {
            decimal comision = base.CalcularPago(); // ventasBrutas * tarifaComision
            return comision + SalarioBase + (SalarioBase * 0.10m);
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"\nTipo: Empleado Asalariado por Comisión" +
                   $"\nSalario Base: {SalarioBase:C}" +
                   $"\nPago: {CalcularPago():C}";
        }
    }
}
