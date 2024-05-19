namespace Laboratorio8_7
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
            Label labelPalabras = new Label { Text = "Ingrese las palabras separadas por comas:", Location = new System.Drawing.Point(10, 10), AutoSize = true };
            TextBox textBoxPalabras = new TextBox { Name = "textBoxPalabras", Location = new System.Drawing.Point(10, 40), Width = 350 };

            Button buttonBuscarAnagramas = new Button { Text = "Buscar Anagramas", Location = new System.Drawing.Point(10, 70), AutoSize = true };
            buttonBuscarAnagramas.Click += ButtonBuscarAnagramas_Click;

            ListBox listBoxAnagramas = new ListBox { Name = "listBoxAnagramas", Location = new System.Drawing.Point(10, 100), Width = 350, Height = 150 };

            // Añadir controles al formulario
            Controls.Add(labelPalabras);
            Controls.Add(textBoxPalabras);
            Controls.Add(buttonBuscarAnagramas);
            Controls.Add(listBoxAnagramas);
        }

        private void ButtonBuscarAnagramas_Click(object sender, EventArgs e)
        {
            string[] palabrasInput = Controls["textBoxPalabras"].Text.Split(',');

            HashSet<string> palabras = new HashSet<string>();

            foreach (string palabra in palabrasInput)
            {
                palabras.Add(palabra.Trim());
            }

            HashSet<string> anagramas = EncontrarAnagramas(palabras);

            ListBox listBoxAnagramas = (ListBox)Controls["listBoxAnagramas"];
            listBoxAnagramas.Items.Clear();
            foreach (string anagrama in anagramas)
            {
                listBoxAnagramas.Items.Add(anagrama);
            }
        }

        // Función que encuentra los anagramas en un conjunto de palabras
        private HashSet<string> EncontrarAnagramas(HashSet<string> palabras)
        {
            HashSet<string> anagramas = new HashSet<string>();

            foreach (string palabra1 in palabras)
            {
                foreach (string palabra2 in palabras)
                {
                    if (palabra1 != palabra2 && SonAnagramas(palabra1, palabra2))
                    {
                        anagramas.Add(palabra1);
                        anagramas.Add(palabra2);
                    }
                }
            }

            return anagramas;
        }

        // Función que verifica si dos palabras son anagramas
        private bool SonAnagramas(string palabra1, string palabra2)
        {
            if (palabra1.Length != palabra2.Length)
                return false;

            char[] chars1 = palabra1.ToCharArray();
            char[] chars2 = palabra2.ToCharArray();

            Array.Sort(chars1);
            Array.Sort(chars2);

            string sorted1 = new string(chars1);
            string sorted2 = new string(chars2);

            return sorted1 == sorted2;
        }
    }
}