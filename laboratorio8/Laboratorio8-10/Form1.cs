namespace Laboratorio8_10
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
            Label labelPalabras = new Label { Text = "Ingrese las palabras separadas por comas:", Location = new System.Drawing.Point(10, 10), AutoSize = true };
            TextBox textBoxPalabras = new TextBox { Name = "textBoxPalabras", Location = new System.Drawing.Point(10, 40), Width = 350 };

            Label labelLetra = new Label { Text = "Ingrese la letra deseada:", Location = new System.Drawing.Point(10, 70), AutoSize = true };
            TextBox textBoxLetra = new TextBox { Name = "textBoxLetra", Location = new System.Drawing.Point(10, 100), Width = 50 };

            Button buttonBuscarPorLetra = new Button { Text = "Buscar por Letra", Location = new System.Drawing.Point(10, 130), AutoSize = true };
            buttonBuscarPorLetra.Click += ButtonBuscarPorLetra_Click;

            ListBox listBoxPalabrasLetra = new ListBox { Name = "listBoxPalabrasLetra", Location = new System.Drawing.Point(10, 160), Width = 350, Height = 100 };

            Controls.Add(labelPalabras);
            Controls.Add(textBoxPalabras);
            Controls.Add(labelLetra);
            Controls.Add(textBoxLetra);
            Controls.Add(buttonBuscarPorLetra);
            Controls.Add(listBoxPalabrasLetra);
        }

        private void ButtonBuscarPorLetra_Click(object sender, EventArgs e)
        {
            string[] palabrasInput = Controls["textBoxPalabras"].Text.Split(',');
            char letraDeseada = ((TextBox)Controls["textBoxLetra"]).Text.Trim().ToLower()[0];

            HashSet<string> palabras = new HashSet<string>();

            foreach (string palabra in palabrasInput)
            {
                palabras.Add(palabra.Trim());
            }

            HashSet<string> palabrasConLetraDeseada = FiltrarPalabrasPorLetra(palabras, letraDeseada);

            ListBox listBoxPalabrasLetra = (ListBox)Controls["listBoxPalabrasLetra"];
            listBoxPalabrasLetra.Items.Clear();
            foreach (string palabra in palabrasConLetraDeseada)
            {
                listBoxPalabrasLetra.Items.Add(palabra);
            }
        }

        // Función 
        private HashSet<string> FiltrarPalabrasPorLetra(HashSet<string> palabras, char letraDeseada)
        {
            HashSet<string> palabrasFiltradas = new HashSet<string>();

            foreach (string palabra in palabras)
            {
                if (palabra.ToLower().Contains(letraDeseada))
                {
                    palabrasFiltradas.Add(palabra);
                }
            }

            return palabrasFiltradas;
        }
    }
}