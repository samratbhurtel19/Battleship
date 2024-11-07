// Purpose: Main entry point for the application.
// Creator: Samrat Jayanta Bhurtel
// Student ID: 100949545
// Title: Program.cs
// Date: 2024/11/04


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new battleshipMainForm());
        }
    }
}
