using System.Diagnostics;

namespace UmbracoDev.Web.HostedServices;

public class TailwindHostedService : IHostedService
{
    private Process? _process;

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _process = Process.Start(new ProcessStartInfo
        {
            FileName = "powershell.exe",
            Arguments = "-Command \"npm run build:css\"",
            WorkingDirectory = Directory.GetCurrentDirectory(),
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        });

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _process?.Kill(true);
        return Task.CompletedTask;
    }
}
