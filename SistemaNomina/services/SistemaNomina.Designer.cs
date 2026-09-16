namespace SistemaNomina
{
    partial class SistemaNomina
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private GroupBox groupBoxDatos;
        private Label lblTipoEmpleado;
        private ComboBox cmbTipoEmpleado;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblNss;
        private TextBox txtNss;
        private Label lblSalarioSemanal;
        private TextBox txtSalarioSemanal;
        private Label lblSueldoPorHora;
        private TextBox txtSueldoPorHora;
        private Label lblHorasTrabajadas;
        private TextBox txtHorasTrabajadas;
        private Label lblVentasBrutas;
        private TextBox txtVentasBrutas;
        private Label lblTarifaComision;
        private TextBox txtTarifaComision;
        private Label lblSalarioBase;
        private TextBox txtSalarioBase;
        private Button btnRegistrar;
        private Button btnActualizar;
        private DataGridView dgvEmpleados;
        private Button btnGenerarReporte;
        private TextBox txtReporte;

        private void InitializeComponent()
        {
            this.groupBoxDatos = new GroupBox();
            this.lblTipoEmpleado = new Label();
            this.cmbTipoEmpleado = new ComboBox();
            this.lblNombre = new Label();
            this.txtNombre = new TextBox();
            this.lblApellido = new Label();
            this.txtApellido = new TextBox();
            this.lblNss = new Label();
            this.txtNss = new TextBox();
            this.lblSalarioSemanal = new Label();
            this.txtSalarioSemanal = new TextBox();
            this.lblSueldoPorHora = new Label();
            this.txtSueldoPorHora = new TextBox();
            this.lblHorasTrabajadas = new Label();
            this.txtHorasTrabajadas = new TextBox();
            this.lblVentasBrutas = new Label();
            this.txtVentasBrutas = new TextBox();
            this.lblTarifaComision = new Label();
            this.txtTarifaComision = new TextBox();
            this.lblSalarioBase = new Label();
            this.txtSalarioBase = new TextBox();
            this.btnRegistrar = new Button();
            this.btnActualizar = new Button();
            this.dgvEmpleados = new DataGridView();
            this.btnGenerarReporte = new Button();
            this.txtReporte = new TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.groupBoxDatos.SuspendLayout();
            this.SuspendLayout();

            // groupBoxDatos
            this.groupBoxDatos.Text = "Datos del empleado";
            this.groupBoxDatos.Location = new Point(12, 12);
            this.groupBoxDatos.Size = new Size(860, 420);
            this.groupBoxDatos.Controls.Add(this.lblTipoEmpleado);
            this.groupBoxDatos.Controls.Add(this.cmbTipoEmpleado);
            this.groupBoxDatos.Controls.Add(this.lblNombre);
            this.groupBoxDatos.Controls.Add(this.txtNombre);
            this.groupBoxDatos.Controls.Add(this.lblApellido);
            this.groupBoxDatos.Controls.Add(this.txtApellido);
            this.groupBoxDatos.Controls.Add(this.lblNss);
            this.groupBoxDatos.Controls.Add(this.txtNss);
            this.groupBoxDatos.Controls.Add(this.lblSalarioSemanal);
            this.groupBoxDatos.Controls.Add(this.txtSalarioSemanal);
            this.groupBoxDatos.Controls.Add(this.lblSueldoPorHora);
            this.groupBoxDatos.Controls.Add(this.txtSueldoPorHora);
            this.groupBoxDatos.Controls.Add(this.lblHorasTrabajadas);
            this.groupBoxDatos.Controls.Add(this.txtHorasTrabajadas);
            this.groupBoxDatos.Controls.Add(this.lblVentasBrutas);
            this.groupBoxDatos.Controls.Add(this.txtVentasBrutas);
            this.groupBoxDatos.Controls.Add(this.lblTarifaComision);
            this.groupBoxDatos.Controls.Add(this.txtTarifaComision);
            this.groupBoxDatos.Controls.Add(this.lblSalarioBase);
            this.groupBoxDatos.Controls.Add(this.txtSalarioBase);
            this.groupBoxDatos.Controls.Add(this.btnRegistrar);
            this.groupBoxDatos.Controls.Add(this.btnActualizar);

            // lblTipoEmpleado
            this.lblTipoEmpleado.Text = "Tipo de Empleado:";
            this.lblTipoEmpleado.Location = new Point(15, 28);
            this.lblTipoEmpleado.Size = new Size(130, 20);

            // cmbTipoEmpleado
            this.cmbTipoEmpleado.Location = new Point(155, 25);
            this.cmbTipoEmpleado.Size = new Size(300, 23);
            this.cmbTipoEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbTipoEmpleado.Items.AddRange(new object[] {
                "Empleado Asalariado",
                "Empleado por Horas",
                "Empleado por Comisión",
                "Empleado Asalariado por Comisión"});
            this.cmbTipoEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmbTipoEmpleado_SelectedIndexChanged);

            // lblNombre
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Location = new Point(15, 63);
            this.lblNombre.Size = new Size(130, 20);

            // txtNombre
            this.txtNombre.Location = new Point(155, 60);
            this.txtNombre.Size = new Size(300, 23);

            // lblApellido
            this.lblApellido.Text = "Apellido:";
            this.lblApellido.Location = new Point(15, 98);
            this.lblApellido.Size = new Size(130, 20);

            // txtApellido
            this.txtApellido.Location = new Point(155, 95);
            this.txtApellido.Size = new Size(300, 23);

            // lblNss
            this.lblNss.Text = "NSS:";
            this.lblNss.Location = new Point(15, 133);
            this.lblNss.Size = new Size(130, 20);

            // txtNss
            this.txtNss.Location = new Point(155, 130);
            this.txtNss.Size = new Size(300, 23);

            // lblSalarioSemanal
            this.lblSalarioSemanal.Text = "Salario Semanal:";
            this.lblSalarioSemanal.Location = new Point(15, 168);
            this.lblSalarioSemanal.Size = new Size(130, 20);

            // txtSalarioSemanal
            this.txtSalarioSemanal.Location = new Point(155, 165);
            this.txtSalarioSemanal.Size = new Size(300, 23);

            // lblSueldoPorHora
            this.lblSueldoPorHora.Text = "Sueldo por Hora:";
            this.lblSueldoPorHora.Location = new Point(15, 203);
            this.lblSueldoPorHora.Size = new Size(130, 20);

            // txtSueldoPorHora
            this.txtSueldoPorHora.Location = new Point(155, 200);
            this.txtSueldoPorHora.Size = new Size(300, 23);

            // lblHorasTrabajadas
            this.lblHorasTrabajadas.Text = "Horas Trabajadas:";
            this.lblHorasTrabajadas.Location = new Point(15, 238);
            this.lblHorasTrabajadas.Size = new Size(130, 20);

            // txtHorasTrabajadas
            this.txtHorasTrabajadas.Location = new Point(155, 235);
            this.txtHorasTrabajadas.Size = new Size(300, 23);

            // lblVentasBrutas
            this.lblVentasBrutas.Text = "Ventas Brutas:";
            this.lblVentasBrutas.Location = new Point(15, 273);
            this.lblVentasBrutas.Size = new Size(130, 20);

            // txtVentasBrutas
            this.txtVentasBrutas.Location = new Point(155, 270);
            this.txtVentasBrutas.Size = new Size(300, 23);

            // lblTarifaComision
            this.lblTarifaComision.Text = "Tarifa Comisión (ej. 0.10):";
            this.lblTarifaComision.Location = new Point(15, 308);
            this.lblTarifaComision.Size = new Size(130, 20);

            // txtTarifaComision
            this.txtTarifaComision.Location = new Point(155, 305);
            this.txtTarifaComision.Size = new Size(300, 23);

            // lblSalarioBase
            this.lblSalarioBase.Text = "Salario Base:";
            this.lblSalarioBase.Location = new Point(15, 343);
            this.lblSalarioBase.Size = new Size(130, 20);

            // txtSalarioBase
            this.txtSalarioBase.Location = new Point(155, 340);
            this.txtSalarioBase.Size = new Size(300, 23);

            // btnRegistrar
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Location = new Point(480, 25);
            this.btnRegistrar.Size = new Size(150, 35);
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);

            // btnActualizar
            this.btnActualizar.Text = "Actualizar (por NSS)";
            this.btnActualizar.Location = new Point(480, 70);
            this.btnActualizar.Size = new Size(150, 35);
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            // dgvEmpleados
            this.dgvEmpleados.Location = new Point(12, 442);
            this.dgvEmpleados.Size = new Size(860, 180);
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // btnGenerarReporte
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.Location = new Point(12, 632);
            this.btnGenerarReporte.Size = new Size(150, 35);
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);

            // txtReporte
            this.txtReporte.Location = new Point(12, 675);
            this.txtReporte.Size = new Size(860, 160);
            this.txtReporte.Multiline = true;
            this.txtReporte.ScrollBars = ScrollBars.Vertical;
            this.txtReporte.ReadOnly = true;
            this.txtReporte.Font = new Font("Consolas", 9F);

            // SistemaNomina (Form)
            this.ClientSize = new Size(884, 850);
            this.Text = "Sistema de Nómina";
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.txtReporte);
            this.Load += new System.EventHandler(this.SistemaNomina_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
