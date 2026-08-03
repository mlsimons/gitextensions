using System.Text;
using GitCommands;
using GitExtensions.Extensibility;
using GitExtensions.Extensibility.Git;
using NSubstitute;

namespace GitCommandsTests.Git;

public class GitCommandRunnerTests
{
    private IExecutable _executable = null!;
    private IProcess _process = null!;
    private GitCommandRunner _sut = null!;

    [SetUp]
    public void Setup()
    {
        _executable = Substitute.For<IExecutable>();
        _process = Substitute.For<IProcess>();
        _executable.Start(
            Arg.Any<ArgumentString>(),
            Arg.Any<bool>(),
            Arg.Any<bool>(),
            Arg.Any<bool>(),
            Arg.Any<Encoding?>(),
            Arg.Any<bool>(),
            Arg.Any<bool>(),
            Arg.Any<CancellationToken>())
            .Returns(_process);

        _sut = new GitCommandRunner(_executable, () => Encoding.UTF8);
    }

    [Test]
    public void RunDetached_should_force_create_window_for_difftool()
    {
        _sut.RunDetached(CancellationToken.None, "difftool --no-prompt");

        _executable.Received(1).Start(
            Arg.Any<ArgumentString>(),
            true,
            false,
            false,
            Arg.Any<Encoding?>(),
            false,
            true,
            Arg.Any<CancellationToken>());
    }

    [Test]
    public void RunDetached_should_force_create_window_for_mergetool()
    {
        _sut.RunDetached(CancellationToken.None, "mergetool --no-prompt");

        _executable.Received(1).Start(
            Arg.Any<ArgumentString>(),
            true,
            false,
            false,
            Arg.Any<Encoding?>(),
            false,
            true,
            Arg.Any<CancellationToken>());
    }

    [Test]
    public void RunDetached_should_keep_create_window_default_for_other_commands()
    {
        _sut.RunDetached(CancellationToken.None, "status --short");

        _executable.Received(1).Start(
            Arg.Any<ArgumentString>(),
            false,
            false,
            false,
            Arg.Any<Encoding?>(),
            false,
            true,
            Arg.Any<CancellationToken>());
    }
}
