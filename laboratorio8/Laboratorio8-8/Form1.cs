namespace Laboratorio8_8
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
            Label labelPalabras = new Label { Text = "Ingrese las palabras separadas por comas:", Location = new System.Drawing.Point(10, 10), AutoSize = true };
            TextBox textBoxPalabras = new TextBox { Name = "textBoxPalabras", Location = new System.Drawing.Point(10, 40), Width = 350 };

            Button buttonBuscarPalindromos = new Button { Text = "Buscar Palíndromos", Location = new System.Drawing.Point(10, 70), AutoSize = true };
            buttonBuscarPalindromos.Click += ButtonBuscarPalindromos_Click;

            ListBox listBoxPalindromos = new ListBox { Name = "listBoxPalindromos", Location = new System.Drawing.Point(10, 100), Width = 350, Height = 150 };

            Controls.Add(labelPalabras);
            Controls.Add(textBoxPalabras);
            Controls.Add(buttonBuscarPalindromos);
            Controls.Add(listBoxPalindromos);
        }

        private void ButtonBuscarPalindromos_Click(object sender, EventArgs e)
        {
            string[] palabrasInput = Controls["textBoxPalabras"].Text.Split(',');

            HashSet<string> palabras = new HashSet<string>();

            foreach (string palabra in palabrasInput)
            {
                palabras.Add(palabra.Trim());
            }

            HashSet<string> palindromos = EncontrarPalindromos(palabras);

            ListBox listBoxPalindromos = (ListBox)Controls["listBoxPalindromos"];
            listBoxPalindromos.Items.Clear();
            foreach (string palindromo in palindromos)
            {
                listBoxPalindromos.Items.Add(palindromo);
            }
        }

        // Función que encuentra los palíndromos
        private HashSet<string> EncontrarPalindromos(HashSet<string> palabras)
        {
            HashSet<string> palindromos = new HashSet<string>();

            foreach (string palabra in palabras)
            {
                if (EsPalindromo(palabra))
                {
                    palindromos.Add(palabra);
                }
            }

            return palindromos;
        }

        // Función si es palíndromo
        private bool EsPalindromo(string palabra)
        {
            int longitud = palabra.Length;
            for (int i = 0; i < longitud / 2; i++)
            {
                if (palabra[i] != palabra[longitud - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}