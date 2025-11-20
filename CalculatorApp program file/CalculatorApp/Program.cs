using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show Splash Screen (Form2)
            Form2 splash = new Form2();
            splash.Show();
            Application.DoEvents(); // Render the splash screen
            System.Threading.Thread.Sleep(3000); // Show it for 3 seconds
            splash.Close();

            // Start Main Form (Form1)
            Application.Run(new Form1());
        }
    }
}
