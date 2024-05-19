namespace Laboratorio8_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicialización y configuración de los controles
            Label labelNumeros = new Label { Text = "Ingrese los números separados por comas:", Location = new System.Drawing.Point(10, 10), AutoSize = true };
            TextBox textBoxNumeros = new TextBox { Name = "textBoxNumeros", Location = new System.Drawing.Point(10, 40), Width = 350 };

            Button buttonBuscarNoDuplicados = new Button { Text = "Buscar No Duplicados", Location = new System.Drawing.Point(10, 70), AutoSize = true };
            buttonBuscarNoDuplicados.Click += ButtonBuscarNoDuplicados_Click;

            ListBox listBoxNumerosNoDuplicados = new ListBox { Name = "listBoxNumerosNoDuplicados", Location = new System.Drawing.Point(10, 100), Width = 350, Height = 150 };

            // Añadir controles al formulario
            Controls.Add(labelNumeros);
            Controls.Add(textBoxNumeros);
            Controls.Add(buttonBuscarNoDuplicados);
            Controls.Add(listBoxNumerosNoDuplicados);
        }

        private void ButtonBuscarNoDuplicados_Click(object sender, EventArgs e)
        {
            string[] numerosInput = Controls["textBoxNumeros"].Text.Split(',');
            HashSet<int> numeros = new HashSet<int>();
            HashSet<int> numerosNoDuplicados = new HashSet<int>();

            foreach (string numero in numerosInput)
            {
                if (int.TryParse(numero.Trim(), out int num))
                {
                    if (!numeros.Add(num))
                    {
                        numerosNoDuplicados.Remove(num);
                    }
                    else
                    {
                        numerosNoDuplicados.Add(num);
                    }
                }
            }

            ListBox listBoxNumerosNoDuplicados = (ListBox)Controls["listBoxNumerosNoDuplicados"];
            listBoxNumerosNoDuplicados.Items.Clear();
            foreach (int numero in numerosNoDuplicados)
            {
                listBoxNumerosNoDuplicados.Items.Add(numero);
            }
        }
    }
}
