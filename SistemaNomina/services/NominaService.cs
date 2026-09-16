using System.Text;
using SistemaNomina.Modelos;

namespace SistemaNomina.Servicios
{
    public class NominaService
    {
        private List<Empleado> empleados = new List<Empleado>();

        public List<Empleado> Empleados => empleados;

        public void RegistrarEmpleado(Empleado empleado)
        {
            empleados.Add(empleado);
        }

        // Búsqueda por NSS (RF-3: permite ubicar al empleado para actualizarlo)
        public Empleado BuscarPorNss(string nss)
        {
            return empleados.Find(e => e.Nss == nss);
        }

        public void EliminarEmpleado(Empleado empleado)
        {
            empleados.Remove(empleado);
        }

        public decimal CalcularTotalNomina()
        {
            return empleados.Sum(e => e.CalcularPago());
        }

        // RF-4: reporte semanal con el detalle de cálculo de cada empleado
        public string GenerarReporte()
        {
            var sb = new StringBuilder();
            sb.AppendLine("=== REPORTE SEMANAL DE PAGOS ===\n");

            foreach (var empleado in empleados)
            {
                sb.AppendLine(empleado.ToString());

                if (empleado is EmpleadoAsalariadoPorComision ac)
                {
                    sb.AppendLine($"Cálculo: ({ac.VentasBrutas} × {ac.TarifaComision}) + " +
                                  $"{ac.SalarioBase} + ({ac.SalarioBase} × 0.10)");
                }
                else if (empleado is EmpleadoPorComision c)
                {
                    sb.AppendLine($"Cálculo: {c.VentasBrutas} × {c.TarifaComision}");
                }
                else if (empleado is EmpleadoPorHoras horas)
                {
                    sb.AppendLine(horas.HorasTrabajadas <= 40
                        ? $"Cálculo: {horas.SueldoPorHora} × {horas.HorasTrabajadas}"
                        : $"Cálculo: ({horas.SueldoPorHora} × 40) + " +
                          $"({horas.SueldoPorHora} × 1.5 × ({horas.HorasTrabajadas} - 40))");
                }
                else if (empleado is EmpleadoAsalariado)
                {
                    sb.AppendLine("Cálculo: salarioSemanal");
                }

                sb.AppendLine(new string('-', 40));
            }

            if (empleados.Count == 0)
                sb.AppendLine("No hay empleados registrados.");
            else
                sb.AppendLine($"\nTOTAL NÓMINA: {CalcularTotalNomina():C}");

            return sb.ToString();
        }
    }
}
