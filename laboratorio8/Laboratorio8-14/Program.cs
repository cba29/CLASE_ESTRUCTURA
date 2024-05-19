namespace Laboratorio8_14
{
    using System;
    using System.Windows.Forms;

    namespace NumerosNoDuplicados
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