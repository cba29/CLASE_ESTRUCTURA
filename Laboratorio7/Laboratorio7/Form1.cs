using System;
using System.Windows.Forms;

namespace Laboratorio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // controles
            Label labelCodigo = new Label { Text = "Código:", Location = new System.Drawing.Point(10, 10), AutoSize = true };
            TextBox textBoxCodigo = new TextBox { Name = "textBoxCodigo", Location = new System.Drawing.Point(200, 10), Width = 150 };

            Label labelNombres = new Label { Text = "Nombres:", Location = new System.Drawing.Point(10, 40), AutoSize = true };
            TextBox textBoxNombres = new TextBox { Name = "textBoxNombres", Location = new System.Drawing.Point(200, 40), Width = 150 };

            Label labelCondicionContrato = new Label { Text = "Condición de Contrato:", Location = new System.Drawing.Point(10, 70), AutoSize = true };
            ComboBox comboBoxCondicionContrato = new ComboBox { Name = "comboBoxCondicionContrato", Location = new System.Drawing.Point(200, 70), Width = 150 };
            comboBoxCondicionContrato.Items.AddRange(new string[] { "Estable", "Contratado" });

            Label labelEspecialidad = new Label { Text = "Especialidad:", Location = new System.Drawing.Point(10, 100), AutoSize = true };
            ComboBox comboBoxEspecialidad = new ComboBox { Name = "comboBoxEspecialidad", Location = new System.Drawing.Point(200, 100), Width = 150 };
            comboBoxEspecialidad.Items.AddRange(new string[] { "Estructuras", "Recursos Hídricos" });

            Label labelTipoActividad = new Label { Text = "Tipo de Actividad:", Location = new System.Drawing.Point(10, 130), AutoSize = true };
            ComboBox comboBoxTipoActividad = new ComboBox { Name = "comboBoxTipoActividad", Location = new System.Drawing.Point(200, 130), Width = 150 };
            comboBoxTipoActividad.Items.AddRange(new string[] { "Supervisión de Obras", "Supervisión de Vías" });

            Label labelTipoAfiliacion = new Label { Text = "Tipo de Afiliación:", Location = new System.Drawing.Point(10, 160), AutoSize = true };
            ComboBox comboBoxTipoAfiliacion = new ComboBox { Name = "comboBoxTipoAfiliacion", Location = new System.Drawing.Point(200, 160), Width = 150 };
            comboBoxTipoAfiliacion.Items.AddRange(new string[] { "AFP", "SNP" });

            Button buttonCalcular = new Button { Text = "Calcular", Location = new System.Drawing.Point(10, 190), AutoSize = true };
            buttonCalcular.Click += ButtonCalcular_Click;

            Controls.Add(labelCodigo);
            Controls.Add(textBoxCodigo);
            Controls.Add(labelNombres);
            Controls.Add(textBoxNombres);
            Controls.Add(labelCondicionContrato);
            Controls.Add(comboBoxCondicionContrato);
            Controls.Add(labelEspecialidad);
            Controls.Add(comboBoxEspecialidad);
            Controls.Add(labelTipoActividad);
            Controls.Add(comboBoxTipoActividad);
            Controls.Add(labelTipoAfiliacion);
            Controls.Add(comboBoxTipoAfiliacion);
            Controls.Add(buttonCalcular);
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            string codigo = Controls["textBoxCodigo"].Text;
            string nombres = Controls["textBoxNombres"].Text;
            string condicionContrato = Controls["comboBoxCondicionContrato"].Text;
            string especialidad = Controls["comboBoxEspecialidad"].Text;
            string tipoActividad = Controls["comboBoxTipoActividad"].Text;
            string tipoAfiliacion = Controls["comboBoxTipoAfiliacion"].Text;

            Arquitecto arquitecto = new Arquitecto(codigo, nombres, condicionContrato, especialidad, tipoActividad, tipoAfiliacion);

            double sueldoBase = arquitecto.CalcularSueldoBase();
            double descuento = arquitecto.CalcularDescuento();
            double sueldoNeto = arquitecto.CalcularSueldoNeto();

            MessageBox.Show($"Código: {codigo}\n" +
                            $"Nombres: {nombres}\n" +
                            $"Condición de Contrato: {condicionContrato}\n" +
                            $"Especialidad: {especialidad}\n" +
                            $"Tipo de Actividad: {tipoActividad}\n" +
                            $"Tipo de Afiliación: {tipoAfiliacion}\n" +
                            $"Sueldo Base: {sueldoBase}\n" +
                            $"Descuento: {descuento}\n" +
                            $"Sueldo Neto: {sueldoNeto}", "Información del Arquitecto");
        }
    }
}
