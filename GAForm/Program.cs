using System;
using System.Windows.Forms;
using GADB;

namespace GAForm
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form from = new Form();
            from.IControl = new KnapController();
            Application.Run(from);
        }
    }
}