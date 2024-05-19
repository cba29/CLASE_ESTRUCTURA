namespace Laboratorio8_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //controles
            Label labelNumeros = new Label { Text = "Ingrese los números separados por comas:", Location = new System.Drawing.Point(10, 10), AutoSize = true };
            TextBox textBoxNumeros = new TextBox { Name = "textBoxNumeros", Location = new System.Drawing.Point(10, 40), Width = 350 };

            Button buttonOrdenarNumeros = new Button { Text = "Ordenar Números", Location = new System.Drawing.Point(10, 70), AutoSize = true };
            buttonOrdenarNumeros.Click += ButtonOrdenarNumeros_Click;

            ListBox listBoxNumerosOrdenados = new ListBox { Name = "listBoxNumerosOrdenados", Location = new System.Drawing.Point(10, 100), Width = 350, Height = 150 };

       
            Controls.Add(labelNumeros);
            Controls.Add(textBoxNumeros);
            Controls.Add(buttonOrdenarNumeros);
            Controls.Add(listBoxNumerosOrdenados);
        }

        private void ButtonOrdenarNumeros_Click(object sender, EventArgs e)
        {
            string[] numerosInput = Controls["textBoxNumeros"].Text.Split(',');
            List<int> numeros = new List<int>();

            foreach (string numero in numerosInput)
            {
                if (int.TryParse(numero.Trim(), out int num))
                {
                    numeros.Add(num);
                }
            }

            List<int> numerosOrdenados = OrdenarNumerosDeMenorAMayor(numeros);

            ListBox listBoxNumerosOrdenados = (ListBox)Controls["listBoxNumerosOrdenados"];
            listBoxNumerosOrdenados.Items.Clear();
            foreach (int numero in numerosOrdenados)
            {
                listBoxNumerosOrdenados.Items.Add(numero);
            }
        }

        // Función menor a mayor
        private List<int> OrdenarNumerosDeMenorAMayor(List<int> numeros)
        {
            numeros.Sort();
            return numeros;
        }
    }
}