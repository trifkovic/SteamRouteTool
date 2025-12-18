using System;
using System.IO;
using System.Windows.Forms;

namespace SteamRouteTool
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Application.Run(new Main());
            }
            catch (Exception ex)
            {
                // Still log errors to a file
                File.WriteAllText("SteamRouteTool_Error.txt", ex.ToString());
            }
        }
    }
}
