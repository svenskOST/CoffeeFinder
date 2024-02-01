using System;
using System.Windows.Forms;

namespace CoffeeFinder
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            if (OperatingSystem.IsWindowsVersionAtLeast(6,1))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            else
            {
                Console.WriteLine("This application requires Windows 6.1 or later to run.");
            }
        }
    }
}
