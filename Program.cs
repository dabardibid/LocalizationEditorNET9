using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LocalizationEditorNET9
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
#pragma warning disable WFO5001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
            Application.SetColorMode(SystemColorMode.Dark);
#pragma warning restore WFO5001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
            Application.Run(new MainFrame());
        }
    }
}
