using System.Runtime.Versioning;
using Avalonia;
using Avalonia.Web;
using Avalonia.ReactiveUI;
using AvaloniaApplication9;

[assembly: SupportedOSPlatform("browser")]

internal partial class Program
{
    private static void Main(string[] args) => BuildAvaloniaApp();

    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>();
}