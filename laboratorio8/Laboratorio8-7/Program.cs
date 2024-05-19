namespace Laboratorio8_7
{
    using System;
    using System.Windows.Forms;

    namespace Anagramas
    {
        static class Program
        {
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }
}