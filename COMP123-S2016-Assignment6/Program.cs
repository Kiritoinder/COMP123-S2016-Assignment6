using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_Assignment6
{
   public static class Program
    {
        public static SplashScrene SplashScrene;
        public static Form1 FirstForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FirstForm = new Form1();
            SplashScrene = new SplashScrene();

            Application.Run(SplashScrene);
        }
    }
}
