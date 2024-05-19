namespace Laboratorio8_8
{
    using System;
    using System.Windows.Forms;

    namespace Palindromos
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