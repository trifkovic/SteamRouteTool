using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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
                File.WriteAllText("SteamRouteTool_Error.txt", ex.ToString());
                Console.WriteLine("Exception written to SteamRouteTool_Error.txt");
            }
            finally
            {
                Console.WriteLine("Press Enter to exit...");
                Console.ReadLine();
            }
        }
    }
}
