﻿using StudentManagementSystem.Addnewresults;
using StudentManagementSystem.Dashboards;
using StudentManagementSystem.Login;
using System;
using System.Windows.Forms;

namespace StudentManagementSystem
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
            Application.Run(new LoginForm());
        }
    }
}
