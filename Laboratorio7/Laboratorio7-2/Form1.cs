namespace Laboratorio7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicializaci�n y configuraci�n de los controles
            Label labelNombres = new Label { Text = "Nombres:", Location = new System.Drawing.Point(10, 10), AutoSize = true };
            TextBox textBoxNombres = new TextBox { Name = "textBoxNombres", Location = new System.Drawing.Point(200, 10), Width = 150 };

            Label labelDNI = new Label { Text = "DNI:", Location = new System.Drawing.Point(10, 40), AutoSize = true };
            TextBox textBoxDNI = new TextBox { Name = "textBoxDNI", Location = new System.Drawing.Point(200, 40), Width = 150 };

            Label labelCargo = new Label { Text = "Cargo:", Location = new System.Drawing.Point(10, 70), AutoSize = true };
            ComboBox comboBoxCargo = new ComboBox { Name = "comboBoxCargo", Location = new System.Drawing.Point(200, 70), Width = 150 };
            comboBoxCargo.Items.AddRange(new string[] { "Gerente", "Subgerente" });

            Label labelArea = new Label { Text = "�rea:", Location = new System.Drawing.Point(10, 100), AutoSize = true };
            ComboBox comboBoxArea = new ComboBox { Name = "comboBoxArea", Location = new System.Drawing.Point(200, 100), Width = 150 };
            comboBoxArea.Items.AddRange(new string[] { "Contabilidad", "Planificaci�n" });

            Label labelAniosAntiguedad = new Label { Text = "A�os de Antig�edad:", Location = new System.Drawing.Point(10, 130), AutoSize = true };
            TextBox textBoxAniosAntiguedad = new TextBox { Name = "textBoxAniosAntiguedad", Location = new System.Drawing.Point(200, 130), Width = 150 };

            Button buttonCalcular = new Button { Text = "Calcular", Location = new System.Drawing.Point(10, 160), AutoSize = true };
            buttonCalcular.Click += ButtonCalcular_Click;

            // A�adir controles al formulario
            Controls.Add(labelNombres);
            Controls.Add(textBoxNombres);
            Controls.Add(labelDNI);
            Controls.Add(textBoxDNI);
            Controls.Add(labelCargo);
            Controls.Add(comboBoxCargo);
            Controls.Add(labelArea);
            Controls.Add(comboBoxArea);
            Controls.Add(labelAniosAntiguedad);
            Controls.Add(textBoxAniosAntiguedad);
            Controls.Add(buttonCalcular);
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            string nombres = Controls["textBoxNombres"].Text;
            string dni = Controls["textBoxDNI"].Text;
            string cargo = Controls["comboBoxCargo"].Text;
            string area = Controls["comboBoxArea"].Text;
            int aniosAntiguedad = int.Parse(Controls["textBoxAniosAntiguedad"].Text);

            Jefe jefe = new Jefe(nombres, dni, cargo, area, aniosAntiguedad);

            double sueldoBase = jefe.CalcularSueldoBase();
            double movilidad = jefe.CalcularMovilidad();
            double bonificacion = jefe.CalcularBonificacion();
            double sueldoFinal = jefe.CalcularSueldoFinal();

            MessageBox.Show($"Nombres: {nombres}\n" +
                            $"DNI: {dni}\n" +
                            $"Cargo: {cargo}\n" +
                            $"�rea: {area}\n" +
                            $"A�os de Antig�edad: {aniosAntiguedad}\n" +
                            $"Sueldo Base: {sueldoBase}\n" +
                            $"Movilidad: {movilidad}\n" +
                            $"Bonificaci�n: {bonificacion}\n" +
                            $"Sueldo Final: {sueldoFinal}", "Informaci�n del Jefe");
        }
    }
}
       