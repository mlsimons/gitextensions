using CommonTestUtils;
using GitCommands;
using GitCommands.Git;
using GitExtensions.Extensibility;
using GitExtensions.Extensibility.Git;
using GitExtUtils;

namespace GitCommandsTests_Git;

public sealed class CherryPickLocalChangesHelperIntegrationTests
{
    [Test]
    public void Reset_prepare_commands_should_allow_cherry_pick_when_untracked_file_would_be_overwritten()
    {
        using GitModuleTestHelper helper = new();
        GitModule module = helper.Module;

        helper.CreateRepoFile("readme.txt", "base");
        module.GitExecutable.GetOutput(@"add readme.txt");
        module.GitExecutable.GetOutput(@"commit -m ""base""");
        string initialBranch = module.GetSelectedBranch();

        module.GitExecutable.GetOutput(@"checkout -b feature");
        helper.CreateRepoFile("file.txt", "feature");
        module.GitExecutable.GetOutput(@"add file.txt");
        module.GitExecutable.GetOutput(@"commit -m ""feature""");

        module.GitExecutable.GetOutput($@"checkout {initialBranch.QuoteNE()}");

        helper.CreateRepoFile("file.txt", "local untracked");

        ObjectId featureObjectId = module.RevParse("feature");
        ArgumentString cherryPickCommand = Commands.CherryPick(featureObjectId, commit: false, string.Empty);

        ExecutionResult failedCherryPick = module.GitExecutable.Execute(cherryPickCommand, throwOnErrorExit: false);
        failedCherryPick.ExitedSuccessfully.Should().BeFalse();
        failedCherryPick.AllOutput.Should().Contain("untracked working tree files would be overwritten");

        foreach (ArgumentString prepareCommand in CherryPickLocalChangesHelper.GetPrepareWorkingTreeCommands(LocalChangesAction.Reset))
        {
            ExecutionResult prepareResult = module.GitExecutable.Execute(prepareCommand, throwOnErrorExit: false);
            prepareResult.ExitedSuccessfully.Should().BeTrue(prepareResult.AllOutput);
        }

        ExecutionResult successfulCherryPick = module.GitExecutable.Execute(cherryPickCommand, throwOnErrorExit: false);
        successfulCherryPick.ExitedSuccessfully.Should().BeTrue(successfulCherryPick.AllOutput);

        File.ReadAllText(Path.Combine(module.WorkingDir, "file.txt")).Should().Be("feature");
    }
}
