namespace Laboratorio8_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Controles
            Label labelPalabras = new Label { Text = "Ingrese palabras separadas por comas:", Location = new System.Drawing.Point(10, 10), AutoSize = true };
            TextBox textBoxPalabras = new TextBox { Name = "textBoxPalabras", Location = new System.Drawing.Point(10, 40), Width = 350 };

            Label labelLetraInicial = new Label { Text = "Ingrese letra inicial:", Location = new System.Drawing.Point(10, 70), AutoSize = true };
            TextBox textBoxLetraInicial = new TextBox { Name = "textBoxLetraInicial", Location = new System.Drawing.Point(200, 70), Width = 50, MaxLength = 1 };

            Button buttonFiltrar = new Button { Text = "Filtrar Palabras", Location = new System.Drawing.Point(10, 100), AutoSize = true };
            buttonFiltrar.Click += ButtonFiltrar_Click;

            ListBox listBoxPalabrasFiltradas = new ListBox { Name = "listBoxPalabrasFiltradas", Location = new System.Drawing.Point(10, 130), Width = 350, Height = 150 };

            
            Controls.Add(labelPalabras);
            Controls.Add(textBoxPalabras);
            Controls.Add(labelLetraInicial);
            Controls.Add(textBoxLetraInicial);
            Controls.Add(buttonFiltrar);
            Controls.Add(listBoxPalabrasFiltradas);
        }

        private void ButtonFiltrar_Click(object sender, EventArgs e)
        {
            string[] input = Controls["textBoxPalabras"].Text.Split(',');
            HashSet<string> palabras = new HashSet<string>(input.Select(p => p.Trim()));

            char letraInicial;
            if (char.TryParse(Controls["textBoxLetraInicial"].Text, out letraInicial))
            {
                HashSet<string> palabrasFiltradas = FiltrarPalabrasPorLetraInicial(palabras, letraInicial);

                ListBox listBoxPalabrasFiltradas = (ListBox)Controls["listBoxPalabrasFiltradas"];
                listBoxPalabrasFiltradas.Items.Clear();
                foreach (string palabra in palabrasFiltradas)
                {
                    listBoxPalabrasFiltradas.Items.Add(palabra);
                }
            }
            else
            {
                MessageBox.Show("Ingrese una letra válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Función que filtra las palabras 
        private HashSet<string> FiltrarPalabrasPorLetraInicial(HashSet<string> palabras, char letraInicial)
        {
            HashSet<string> palabrasFiltradas = new HashSet<string>();
            foreach (string palabra in palabras)
            {
                if (palabra.StartsWith(letraInicial.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    palabrasFiltradas.Add(palabra);
                }
            }
            return palabrasFiltradas;
        }
    }
}