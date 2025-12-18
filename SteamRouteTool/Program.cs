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
            }
            finally
            {
                Console.WriteLine("Press Enter to exit...");
                Console.ReadLine();  // <-- keep console open
            }
        }
    }
}
