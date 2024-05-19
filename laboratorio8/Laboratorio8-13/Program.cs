namespace Laboratorio8_13
{
    using System;
    using System.Windows.Forms;

    namespace NumerosDuplicados
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