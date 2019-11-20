﻿using PlesnaSkola.WinUI.Clanovi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlesnaSkola.WinUI
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

            var loginForm = new frmLogin();
            if(loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmMain());
            }

        }
    }
}
