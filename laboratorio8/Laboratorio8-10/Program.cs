namespace Laboratorio8_10
{
    using System;
    using System.Windows.Forms;

    namespace PalabrasConLetraDeterminada
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