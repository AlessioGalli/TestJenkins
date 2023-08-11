using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestJenkins
{
    public class Program
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

        public string FaiSomma(string a, string b)
        {
            if(!Int32.TryParse(a, out int intA) || !Int32.TryParse(b, out int intB)){
                return "-1-1-1";
            }
            else
            {
                return intA + intB + "";
            }
        }
    }
}
