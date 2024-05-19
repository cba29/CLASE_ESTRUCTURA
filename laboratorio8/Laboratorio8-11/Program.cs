namespace Laboratorio8_11
{
    using System;
    using System.Windows.Forms;

    namespace NumerosOrdenadosMenorAMayor
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