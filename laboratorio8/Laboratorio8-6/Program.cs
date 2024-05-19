namespace Laboratorio8_6
{
    using System;
    using System.Windows.Forms;

    namespace NumerosEnSegundoConjunto
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