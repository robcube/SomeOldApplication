using SomeOldApplication.PyUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeOldApplication
{
    class Program
    {
        /// <summary>
        /// junk code to get DLLs to build in your bin folder
        /// </summary>
        private void AssemblyReferenceFix()
        {
            var t = typeof(PyUtility.PyUtility);
            t = typeof(Email);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
