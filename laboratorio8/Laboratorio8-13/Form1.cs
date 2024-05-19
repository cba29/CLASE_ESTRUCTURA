namespace Laboratorio8_13
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

            Button buttonBuscarDuplicados = new Button { Text = "Buscar Duplicados", Location = new System.Drawing.Point(10, 70), AutoSize = true };
            buttonBuscarDuplicados.Click += ButtonBuscarDuplicados_Click;

            ListBox listBoxNumerosDuplicados = new ListBox { Name = "listBoxNumerosDuplicados", Location = new System.Drawing.Point(10, 100), Width = 350, Height = 150 };

          
            Controls.Add(labelNumeros);
            Controls.Add(textBoxNumeros);
            Controls.Add(buttonBuscarDuplicados);
            Controls.Add(listBoxNumerosDuplicados);
        }

        private void ButtonBuscarDuplicados_Click(object sender, EventArgs e)
        {
            string[] numerosInput = Controls["textBoxNumeros"].Text.Split(',');
            HashSet<int> numeros = new HashSet<int>();
            HashSet<int> numerosDuplicados = new HashSet<int>();

            foreach (string numero in numerosInput)
            {
                if (int.TryParse(numero.Trim(), out int num))
                {
                    if (!numeros.Add(num))
                    {
                        numerosDuplicados.Add(num);
                    }
                }
            }

            ListBox listBoxNumerosDuplicados = (ListBox)Controls["listBoxNumerosDuplicados"];
            listBoxNumerosDuplicados.Items.Clear();
            foreach (int numero in numerosDuplicados)
            {
                listBoxNumerosDuplicados.Items.Add(numero);
            }
        }
    }
}