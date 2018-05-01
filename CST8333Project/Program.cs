using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace $safeprojectname$
{
    /// <summary>
    /// Program.cs
    /// Created by Jennifer Aube
    /// Modified on: March 20, 2018
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FileOpener file = new FileOpener();
            List<ProjectPieces> list = new List<ProjectPieces>();
            list = file.openFile(); //gets the list created after opening and reading the file
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new MainWindow(list)); //sends list to main window for database to user
            
        }

    }
}
