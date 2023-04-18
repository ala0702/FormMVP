using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using formularz_mvp.presenter;
using formularz_mvp.view;
using formularz_mvp.model;

namespace formularz_mvp
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

            // Create instances of dependencies
            var view = new Form1();
            var modelList = new EmployeeList();
            var modelEmployee = new Employee();

            // Create instance of presenter
            var presenter = new MainPresenter(view, modelList, modelEmployee);

            // Run the application
            Application.Run(view);
        }
    }
}




/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using formularz_mvp.view;

namespace formularz_mvp
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
            Application.Run(new Form1());
        }
    }
}


*/