using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment5
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static SplashScreenForm splashScreen;
        public static StartForm startForm;
        public static SelectForm selectForm;
        public static ProductForm productForm;
        public static OrderForm orderForm;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            splashScreen = new SplashScreenForm();
            startForm = new StartForm();
            selectForm = new SelectForm();
            productForm = new ProductForm();
            orderForm = new OrderForm();
            Application.Run(splashScreen);
        }
    }
}
