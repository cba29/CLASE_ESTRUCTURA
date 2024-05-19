namespace laboratorio8
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

            Button buttonFiltrar = new Button { Text = "Filtrar Primos", Location = new System.Drawing.Point(10, 70), AutoSize = true };
            buttonFiltrar.Click += ButtonFiltrar_Click;

            ListBox listBoxPrimos = new ListBox { Name = "listBoxPrimos", Location = new System.Drawing.Point(10, 100), Width = 350, Height = 150 };

            
            Controls.Add(labelNumeros);
            Controls.Add(textBoxNumeros);
            Controls.Add(buttonFiltrar);
            Controls.Add(listBoxPrimos);
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

            HashSet<int> primos = FiltrarNumerosPrimos(numeros);

            ListBox listBoxPrimos = (ListBox)Controls["listBoxPrimos"];
            listBoxPrimos.Items.Clear();
            foreach (int primo in primos)
            {
                listBoxPrimos.Items.Add(primo);
            }
        }

        // Función de primos
        private bool EsPrimo(int numero)
        {
            if (numero <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }

        // Función de filtro
        private HashSet<int> FiltrarNumerosPrimos(HashSet<int> numeros)
        {
            HashSet<int> primos = new HashSet<int>();
            foreach (int numero in numeros)
            {
                if (EsPrimo(numero))
                {
                    primos.Add(numero);
                }
            }
            return primos;
        }
    }
}