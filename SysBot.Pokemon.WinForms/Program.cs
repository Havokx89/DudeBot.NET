using PKHeX.Core;
using SysBot.Pokemon.Z3;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace SysBot.Pokemon.WinForms;

static class Program
{
    static Program()
    {
        var cmd = Environment.GetCommandLineArgs();
        var cfg = Array.Find(cmd, z => z.EndsWith(".json"));
        if (cfg != null)
            ConfigPath = cmd[0];

        PokeTradeBotSWSH.SeedChecker = new Z3SeedSearchHandler<PK8>();
    }
    public static readonly string WorkingDirectory = Environment.CurrentDirectory = Path.GetDirectoryName(Environment.ProcessPath)!;
    public static string ConfigPath { get; private set; } = Path.Combine(WorkingDirectory, "config.json");

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
#if NETCOREAPP
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
#endif


        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Main());
    }
}

