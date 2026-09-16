namespace SistemaNomina.Modelos
{
    public class EmpleadoAsalariado : Empleado
    {
        public decimal SalarioSemanal { get; set; }

        public EmpleadoAsalariado(string nombre, string apellido, string nss, decimal salarioSemanal)
            : base(nombre, apellido, nss)
        {
            SalarioSemanal = salarioSemanal;
        }

        public override decimal CalcularPago()
        {
            return SalarioSemanal;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"\nTipo: Empleado Asalariado" +
                   $"\nSalario Semanal: {SalarioSemanal:C}" +
                   $"\nPago: {CalcularPago():C}";
        }
    }
}
