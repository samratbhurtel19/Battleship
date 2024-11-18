// Title: Main Program
// Name: Samrat Jayanta Bhurtel
// Student ID: 100949545
// Date: 13th November 2024
// Description: The main entry point for the application. It shows the splash screen and then opens the main form.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineCraft
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show the splash screen
            using (splashScreen splashScreen = new splashScreen())
            {
                splashScreen.ShowDialog(); // Show as a modal dialog
            }

            // Show the main form
            Application.Run(new mainFrm());
        }
    }
}
