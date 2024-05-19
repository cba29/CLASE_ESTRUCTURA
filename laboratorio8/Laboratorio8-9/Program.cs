namespace Laboratorio8_9
{
    using System;
    using System.Windows.Forms;

    namespace PalabrasLongitudDeterminada
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