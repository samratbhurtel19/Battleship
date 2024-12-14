// Name : Samrat Jayanta Bhurtel
// Student ID : 100949545
// Date : 2024/12/13
// title : utility.cs
// Purpose: This file contains the utility class that contains methods that can be used to add a StatusStrip and MenuStrip to the form.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public static class utility
    {
        /// <summary>
        /// This method adds a StatusStrip to the form and updates the time every second.
        /// Rather than adding toolbar to each form, I tried to create a utility class that 
        /// can be used to add a StatusStrip to the form. This StatusStrip will display the 
        /// current time and update every second.
        /// </summary>
        /// <param name="form"></param>
        /// Reference for both method:https://www.c-sharpcorner.com/blogs/create-menustrip-dynamically-in-c-sharp1#:~:text=To%20add%20a%20MenuStrip%20Dynamically,instance%20of%20the%20MenuStrip%20Class.&text=A%20MenuStrip%20is%20nothing%20with,we%20use%20the%20ToolStripMenuItem%20class.
        public static void AddStatusStrip(Form form)
        {
            // Create StatusStrip
            StatusStrip statusStrip = new StatusStrip();

            // Add Time Label
            ToolStripStatusLabel timeLabel = new ToolStripStatusLabel();
            timeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");

            // Add Time Label to StatusStrip
            statusStrip.Items.Add(timeLabel);

            // Add StatusStrip to the Form
            form.Controls.Add(statusStrip);

            // Update time every second
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += (s, e) =>
            {
                timeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
            };
            timer.Start();
        }
        /// <summary>
        /// This method adds a MenuStrip to the form with a 'File' menu that contains an 'Exit' option.
        /// The 'Exit' option will close the current form and show the main form if allowExitToMain is true, 
        /// otherwise it will exit the application completely.
        /// </summary>
        /// <param name="currentForm"></param>
        /// <param name="allowExitToMain"></param>
        public static void AddMenuStrip(Form currentForm, bool allowExitToMain = true)
        {
            // Create MenuStrip
            MenuStrip menuStrip = new MenuStrip();

            // Create 'File' Menu
            ToolStripMenuItem fileMenu = new ToolStripMenuItem("File");

            // Add 'Exit' Option
            ToolStripMenuItem exitMenuItem = new ToolStripMenuItem("Exit");
            exitMenuItem.Click += (s, e) =>
            {
                if (allowExitToMain)
                {
                    // Navigate to Main Form
                    frmMain mainForm = new frmMain();
                    mainForm.Show();
                    currentForm.Hide(); // Hide current form
                }
                else
                {
                    Application.Exit(); // Exit the application completely
                }
            };

            // Add items to 'File' Menu
            fileMenu.DropDownItems.Add(exitMenuItem);

            // Add 'File' Menu to MenuStrip
            menuStrip.Items.Add(fileMenu);

            // Add MenuStrip to the Form
            currentForm.MainMenuStrip = menuStrip;
            currentForm.Controls.Add(menuStrip);
        }
    }
}
