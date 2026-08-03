using System.Text;
using GitExtensions.Extensibility;
using GitExtensions.Extensibility.Git;
using GitUI;

namespace GitCommands;

public sealed class GitCommandRunner : IGitCommandRunner
{
    private readonly IExecutable _gitExecutable;
    private readonly Func<Encoding> _defaultEncoding;

    public GitCommandRunner(IExecutable gitExecutable, Func<Encoding> defaultEncoding)
    {
        _gitExecutable = gitExecutable;
        _defaultEncoding = defaultEncoding;
    }

    public IProcess RunDetached(
        CancellationToken cancellationToken,
        ArgumentString arguments = default,
        bool createWindow = false,
        bool redirectInput = false,
        bool redirectOutput = false,
        Encoding? outputEncoding = null,
        bool throwOnErrorExit = true)
    {
        if (outputEncoding is null && redirectOutput)
        {
            outputEncoding = _defaultEncoding();
        }

        bool shouldCreateWindow = createWindow || IsDiffOrMergeToolCommand(arguments);

        return _gitExecutable.Start(arguments, shouldCreateWindow, redirectInput, redirectOutput, outputEncoding, useShellExecute: false, throwOnErrorExit, cancellationToken);
    }

    public void RunDetached(
        ArgumentString arguments = default,
        bool createWindow = false,
        bool redirectInput = false,
        bool redirectOutput = false,
        Encoding? outputEncoding = null)
    {
        ThreadHelper.FileAndForget(async () =>
            {
                System.Diagnostics.Debug.WriteLine($"git {arguments}");
                using IProcess process = RunDetached(CancellationToken.None, arguments, createWindow, redirectInput, redirectOutput, outputEncoding);
                await process.WaitForExitAsync();
            });
    }

    private static bool IsDiffOrMergeToolCommand(ArgumentString arguments)
    {
        string argumentString = arguments;
        ReadOnlySpan<char> trimmedArguments = argumentString.AsSpan().TrimStart();

        return trimmedArguments.StartsWith("difftool", StringComparison.Ordinal)
            || trimmedArguments.StartsWith("mergetool", StringComparison.Ordinal);
    }
}
