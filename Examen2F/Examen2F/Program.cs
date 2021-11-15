using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Syncfusion.Licensing;

namespace Examen2F
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTM0MTQ3QDMxMzkyZTMzMmUzMEdtTFozWnBrQ0ZsK0N0SlVKMk55YWh6UFd2Y3dmcjd6ZEw2bWRnTXdlZGs9");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginView());
        }
    }
}
