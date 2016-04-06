using System;
using System.Windows.Forms;

namespace InternalClient
{
    static class MainClass
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                string t = args[0].ToLower();
                if (t == "kitchen" || t == "bar")
                {
                    System.Console.WriteLine("Chosen type: " + t);
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new InternalClientWindow(t));
                }
                else
                    System.Console.WriteLine("Unknown input format");
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                InitialForm if1 = new InitialForm();
                Application.Run(if1);
                Application.Run(new InternalClientWindow(if1.type));
            }            
        }
    }
}
