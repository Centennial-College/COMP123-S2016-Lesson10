using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_Lesson10
{
    public static class Program
    {
        public static SplashScreenForm SplashScreen;
        public static Form1 FirstForm;
        public static Form2 SecondForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FirstForm = new Form1();
            SecondForm = new Form2();
            SplashScreen = new SplashScreenForm();

            Application.Run(SplashScreen);
        }
    }
}
