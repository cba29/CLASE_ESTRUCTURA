namespace Laboratorio8_4
{
    using System;
    using System.Windows.Forms;

    namespace NumerosComunes
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