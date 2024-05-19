namespace Laboratorio8_9
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

            Label labelLongitud = new Label { Text = "Ingrese la longitud deseada:", Location = new System.Drawing.Point(10, 70), AutoSize = true };
            NumericUpDown numericUpDownLongitud = new NumericUpDown { Name = "numericUpDownLongitud", Location = new System.Drawing.Point(10, 100), Width = 50, Minimum = 1, Maximum = 100 };

            Button buttonBuscarPorLongitud = new Button { Text = "Buscar por Longitud", Location = new System.Drawing.Point(10, 130), AutoSize = true };
            buttonBuscarPorLongitud.Click += ButtonBuscarPorLongitud_Click;

            ListBox listBoxPalabrasLongitud = new ListBox { Name = "listBoxPalabrasLongitud", Location = new System.Drawing.Point(10, 160), Width = 350, Height = 100 };

            Controls.Add(labelPalabras);
            Controls.Add(textBoxPalabras);
            Controls.Add(labelLongitud);
            Controls.Add(numericUpDownLongitud);
            Controls.Add(buttonBuscarPorLongitud);
            Controls.Add(listBoxPalabrasLongitud);
        }

        private void ButtonBuscarPorLongitud_Click(object sender, EventArgs e)
        {
            string[] palabrasInput = Controls["textBoxPalabras"].Text.Split(',');
            int longitudDeseada = (int)((NumericUpDown)Controls["numericUpDownLongitud"]).Value;

            HashSet<string> palabras = new HashSet<string>();

            foreach (string palabra in palabrasInput)
            {
                palabras.Add(palabra.Trim());
            }

            HashSet<string> palabrasConLongitudDeseada = FiltrarPalabrasPorLongitud(palabras, longitudDeseada);

            ListBox listBoxPalabrasLongitud = (ListBox)Controls["listBoxPalabrasLongitud"];
            listBoxPalabrasLongitud.Items.Clear();
            foreach (string palabra in palabrasConLongitudDeseada)
            {
                listBoxPalabrasLongitud.Items.Add(palabra);
            }
        }

        // Función
        private HashSet<string> FiltrarPalabrasPorLongitud(HashSet<string> palabras, int longitudDeseada)
        {
            HashSet<string> palabrasFiltradas = new HashSet<string>();

            foreach (string palabra in palabras)
            {
                if (palabra.Length == longitudDeseada)
                {
                    palabrasFiltradas.Add(palabra);
                }
            }

            return palabrasFiltradas;
        }
    }
}