namespace Laboratorio8_5
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
            Label labelConjunto1 = new Label { Text = "Ingrese el primer conjunto de números separados por comas:", Location = new System.Drawing.Point(10, 10), AutoSize = true };
            TextBox textBoxConjunto1 = new TextBox { Name = "textBoxConjunto1", Location = new System.Drawing.Point(10, 40), Width = 350 };

            Label labelConjunto2 = new Label { Text = "Ingrese el segundo conjunto de números separados por comas:", Location = new System.Drawing.Point(10, 70), AutoSize = true };
            TextBox textBoxConjunto2 = new TextBox { Name = "textBoxConjunto2", Location = new System.Drawing.Point(10, 100), Width = 350 };

            Button buttonFiltrar = new Button { Text = "Filtrar Diferentes", Location = new System.Drawing.Point(10, 130), AutoSize = true };
            buttonFiltrar.Click += ButtonFiltrar_Click;

            ListBox listBoxNumerosDiferentes = new ListBox { Name = "listBoxNumerosDiferentes", Location = new System.Drawing.Point(10, 160), Width = 350, Height = 100 };

            Controls.Add(labelConjunto1);
            Controls.Add(textBoxConjunto1);
            Controls.Add(labelConjunto2);
            Controls.Add(textBoxConjunto2);
            Controls.Add(buttonFiltrar);
            Controls.Add(listBoxNumerosDiferentes);
        }

        private void ButtonFiltrar_Click(object sender, EventArgs e)
        {
            string[] input1 = Controls["textBoxConjunto1"].Text.Split(',');
            string[] input2 = Controls["textBoxConjunto2"].Text.Split(',');

            HashSet<int> conjunto1 = new HashSet<int>();
            HashSet<int> conjunto2 = new HashSet<int>();

            foreach (string num in input1)
            {
                if (int.TryParse(num.Trim(), out int numero))
                {
                    conjunto1.Add(numero);
                }
            }

            foreach (string num in input2)
            {
                if (int.TryParse(num.Trim(), out int numero))
                {
                    conjunto2.Add(numero);
                }
            }

            HashSet<int> numerosDiferentes = FiltrarNumerosDiferentes(conjunto1, conjunto2);

            ListBox listBoxNumerosDiferentes = (ListBox)Controls["listBoxNumerosDiferentes"];
            listBoxNumerosDiferentes.Items.Clear();
            foreach (int numero in numerosDiferentes)
            {
                listBoxNumerosDiferentes.Items.Add(numero);
            }
        }

        // Función que filtra los números
        private HashSet<int> FiltrarNumerosDiferentes(HashSet<int> conjunto1, HashSet<int> conjunto2)
        {
            return new HashSet<int>(conjunto1.Except(conjunto2));
        }
    }
}