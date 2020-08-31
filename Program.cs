using System;
using System.Windows.Forms;

namespace Raiden
{
    static class Program
    {
        static public ClientForm client_form;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            client_form = new ClientForm();
            Application.Run(client_form);
            

        }
    }
}
