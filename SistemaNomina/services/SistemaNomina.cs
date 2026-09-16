using SistemaNomina.Modelos;
using SistemaNomina.Servicios;

namespace SistemaNomina
{
    public partial class SistemaNomina : Form
    {
        private readonly NominaService _nominaService = new();

        public SistemaNomina()
        {
            InitializeComponent();
        }

        private void SistemaNomina_Load(object sender, EventArgs e)
        {
            cmbTipoEmpleado.SelectedIndex = 0; // dispara cmbTipoEmpleado_SelectedIndexChanged
        }

        private void cmbTipoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSalarioSemanal.Visible = false;
            lblSalarioSemanal.Visible = false;
            txtSueldoPorHora.Visible = false;
            lblSueldoPorHora.Visible = false;
            txtHorasTrabajadas.Visible = false;
            lblHorasTrabajadas.Visible = false;
            txtVentasBrutas.Visible = false;
            lblVentasBrutas.Visible = false;
            txtTarifaComision.Visible = false;
            lblTarifaComision.Visible = false;
            txtSalarioBase.Visible = false;
            lblSalarioBase.Visible = false;

            switch (cmbTipoEmpleado.SelectedItem?.ToString())
            {
                case "Empleado Asalariado":
                    txtSalarioSemanal.Visible = true;
                    lblSalarioSemanal.Visible = true;
                    break;

                case "Empleado por Horas":
                    txtSueldoPorHora.Visible = true;
                    lblSueldoPorHora.Visible = true;
                    txtHorasTrabajadas.Visible = true;
                    lblHorasTrabajadas.Visible = true;
                    break;

                case "Empleado por Comisión":
                    txtVentasBrutas.Visible = true;
                    lblVentasBrutas.Visible = true;
                    txtTarifaComision.Visible = true;
                    lblTarifaComision.Visible = true;
                    break;

                case "Empleado Asalariado por Comisión":
                    txtVentasBrutas.Visible = true;
                    lblVentasBrutas.Visible = true;
                    txtTarifaComision.Visible = true;
                    lblTarifaComision.Visible = true;
                    txtSalarioBase.Visible = true;
                    lblSalarioBase.Visible = true;
                    break;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text.Trim();
                string apellido = txtApellido.Text.Trim();
                string nss = txtNss.Text.Trim();
                string tipo = cmbTipoEmpleado.SelectedItem?.ToString() ?? "";

                Empleado nuevoEmpleado = tipo switch
                {
                    "Empleado Asalariado" => new EmpleadoAsalariado(
                        nombre, apellido, nss,
                        Convert.ToDecimal(txtSalarioSemanal.Text)),

                    "Empleado por Horas" => new EmpleadoPorHoras(
                        nombre, apellido, nss,
                        Convert.ToDecimal(txtSueldoPorHora.Text),
                        Convert.ToDecimal(txtHorasTrabajadas.Text)),

                    "Empleado por Comisión" => new EmpleadoPorComision(
                        nombre, apellido, nss,
                        Convert.ToDecimal(txtVentasBrutas.Text),
                        Convert.ToDecimal(txtTarifaComision.Text)),

                    "Empleado Asalariado por Comisión" => new EmpleadoAsalariadoPorComision(
                        nombre, apellido, nss,
                        Convert.ToDecimal(txtVentasBrutas.Text),
                        Convert.ToDecimal(txtTarifaComision.Text),
                        Convert.ToDecimal(txtSalarioBase.Text)),

                    _ => throw new InvalidOperationException("Tipo de empleado no reconocido")
                };

                _nominaService.RegistrarEmpleado(nuevoEmpleado);
                ActualizarGrilla();
                LimpiarCampos();
                MessageBox.Show("Empleado registrado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Revisa que los campos numéricos tengan valores válidos.",
                    "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nss = txtNss.Text.Trim();
            Empleado empleadoEncontrado = _nominaService.BuscarPorNss(nss);

            if (empleadoEncontrado == null)
            {
                MessageBox.Show("Empleado no encontrado.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (empleadoEncontrado is EmpleadoAsalariadoPorComision asalariadoComision)
                {
                    asalariadoComision.VentasBrutas = Convert.ToDecimal(txtVentasBrutas.Text);
                    asalariadoComision.TarifaComision = Convert.ToDecimal(txtTarifaComision.Text);
                    asalariadoComision.SalarioBase = Convert.ToDecimal(txtSalarioBase.Text);
                }
                else if (empleadoEncontrado is EmpleadoPorComision comision)
                {
                    comision.VentasBrutas = Convert.ToDecimal(txtVentasBrutas.Text);
                    comision.TarifaComision = Convert.ToDecimal(txtTarifaComision.Text);
                }
                else if (empleadoEncontrado is EmpleadoPorHoras horas)
                {
                    horas.SueldoPorHora = Convert.ToDecimal(txtSueldoPorHora.Text);
                    horas.HorasTrabajadas = Convert.ToDecimal(txtHorasTrabajadas.Text);
                }
                else if (empleadoEncontrado is EmpleadoAsalariado asalariado)
                {
                    asalariado.SalarioSemanal = Convert.ToDecimal(txtSalarioSemanal.Text);
                }

                ActualizarGrilla();
                MessageBox.Show("Información actualizada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Revisa que los campos numéricos tengan valores válidos.",
                    "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            txtReporte.Text = _nominaService.GenerarReporte();
        }

        private void ActualizarGrilla()
        {
            var filas = _nominaService.Empleados.Select(emp => new
            {
                emp.Nombre,
                emp.Apellido,
                emp.Nss,
                Pago = emp.CalcularPago()
            }).ToList();

            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = filas;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtNss.Clear();
            txtSalarioSemanal.Clear();
            txtSueldoPorHora.Clear();
            txtHorasTrabajadas.Clear();
            txtVentasBrutas.Clear();
            txtTarifaComision.Clear();
            txtSalarioBase.Clear();
        }
    }
}
