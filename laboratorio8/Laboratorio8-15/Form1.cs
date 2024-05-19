namespace Laboratorio8_15
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

            Button buttonBuscarPrimos = new Button { Text = "Buscar Números Primos", Location = new System.Drawing.Point(10, 70), AutoSize = true };
            buttonBuscarPrimos.Click += ButtonBuscarPrimos_Click;

            ListBox listBoxNumerosPrimos = new ListBox { Name = "listBoxNumerosPrimos", Location = new System.Drawing.Point(10, 100), Width = 350, Height = 150 };

            Controls.Add(labelNumeros);
            Controls.Add(textBoxNumeros);
            Controls.Add(buttonBuscarPrimos);
            Controls.Add(listBoxNumerosPrimos);
        }

        private void ButtonBuscarPrimos_Click(object sender, EventArgs e)
        {
            string[] numerosInput = Controls["textBoxNumeros"].Text.Split(',');
            List<int> numerosPrimos = new List<int>();

            foreach (string numero in numerosInput)
            {
                if (int.TryParse(numero.Trim(), out int num))
                {
                    if (EsPrimo(num))
                    {
                        numerosPrimos.Add(num);
                    }
                }
            }

            numerosPrimos.Sort();

            ListBox listBoxNumerosPrimos = (ListBox)Controls["listBoxNumerosPrimos"];
            listBoxNumerosPrimos.Items.Clear();
            foreach (int primo in numerosPrimos)
            {
                listBoxNumerosPrimos.Items.Add(primo);
            }
        }

        // Función primo
        private bool EsPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            for (int i = 2; i * i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}