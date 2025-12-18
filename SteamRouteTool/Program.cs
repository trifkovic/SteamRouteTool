using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SteamRouteTool
{
    static class Program
    {
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        [STAThread]
        static void Main()
        {
            // Allocate a console to see errors/output
            AllocConsole();
            Console.WriteLine("SteamRouteTool starting...");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Application.Run(new Main());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex);
                Console.WriteLine("Press Enter to exit...");
                Console.ReadLine();
            }
        }
    }
}
