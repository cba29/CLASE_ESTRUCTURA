namespace Laboratorio8_5
{
    using System;
    using System.Windows.Forms;

    namespace NumerosDiferentes
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