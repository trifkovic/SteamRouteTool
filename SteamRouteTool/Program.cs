[STAThread]
static void Main()
{
    // AllocConsole(); // REMOVE THIS
    // Console.WriteLine("SteamRouteTool starting..."); // REMOVE THIS

    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);

    try
    {
        Application.Run(new Main());
    }
    catch (Exception ex)
    {
        File.WriteAllText("SteamRouteTool_Error.txt", ex.ToString());
        // Console.WriteLine("Exception written to SteamRouteTool_Error.txt"); // REMOVE THIS
    }

    // Console.ReadLine(); // REMOVE THIS
}
