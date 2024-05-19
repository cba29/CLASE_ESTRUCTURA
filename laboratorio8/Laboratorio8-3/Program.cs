namespace Laboratorio8_3
{
    using System;
    using System.Windows.Forms;

    namespace FiltrarNumerosDivisibles
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