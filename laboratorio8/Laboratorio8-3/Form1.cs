namespace Laboratorio8_3
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
            Label labelNumeros = new Label { Text = "Ingrese números separados por comas:", Location = new System.Drawing.Point(10, 10), AutoSize = true };
            TextBox textBoxNumeros = new TextBox { Name = "textBoxNumeros", Location = new System.Drawing.Point(10, 40), Width = 350 };

            Label labelDivisor = new Label { Text = "Ingrese el divisor:", Location = new System.Drawing.Point(10, 70), AutoSize = true };
            TextBox textBoxDivisor = new TextBox { Name = "textBoxDivisor", Location = new System.Drawing.Point(200, 70), Width = 50 };

            Button buttonFiltrar = new Button { Text = "Filtrar Números", Location = new System.Drawing.Point(10, 100), AutoSize = true };
            buttonFiltrar.Click += ButtonFiltrar_Click;

            ListBox listBoxNumerosFiltrados = new ListBox { Name = "listBoxNumerosFiltrados", Location = new System.Drawing.Point(10, 130), Width = 350, Height = 150 };

            
            Controls.Add(labelNumeros);
            Controls.Add(textBoxNumeros);
            Controls.Add(labelDivisor);
            Controls.Add(textBoxDivisor);
            Controls.Add(buttonFiltrar);
            Controls.Add(listBoxNumerosFiltrados);
        }

        private void ButtonFiltrar_Click(object sender, EventArgs e)
        {
            string[] input = Controls["textBoxNumeros"].Text.Split(',');
            HashSet<int> numeros = new HashSet<int>();

            foreach (string num in input)
            {
                if (int.TryParse(num.Trim(), out int numero))
                {
                    numeros.Add(numero);
                }
            }

            if (int.TryParse(Controls["textBoxDivisor"].Text, out int divisor) && divisor != 0)
            {
                HashSet<int> numerosFiltrados = FiltrarNumerosDivisibles(numeros, divisor);

                ListBox listBoxNumerosFiltrados = (ListBox)Controls["listBoxNumerosFiltrados"];
                listBoxNumerosFiltrados.Items.Clear();
                foreach (int numero in numerosFiltrados)
                {
                    listBoxNumerosFiltrados.Items.Add(numero);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un divisor válido (no cero).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Función que filtra los números 
        private HashSet<int> FiltrarNumerosDivisibles(HashSet<int> numeros, int divisor)
        {
            HashSet<int> numerosFiltrados = new HashSet<int>();
            foreach (int numero in numeros)
            {
                if (numero % divisor == 0)
                {
                    numerosFiltrados.Add(numero);
                }
            }
            return numerosFiltrados;
        }
    }
}