﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Epacsenur.Features.Client;
using System.Windows.Forms;
using CefSharp.WinForms;
using CefSharp;

namespace Epacsenur
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            var settings = new CefSettings();
            settings.BrowserSubprocessPath = @"x86\CefSharp.BrowserSubprocess.exe";

            Cef.Initialize(settings, performDependencyCheck: false, browserProcessHandler: null);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}