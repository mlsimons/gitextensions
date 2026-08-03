using GitCommands;
using GitCommands.Git;
using GitExtensions.Extensibility;
using GitExtensions.Extensibility.Git;

namespace GitCommandsTests_Git;

public sealed class CherryPickLocalChangesHelperTests
{
    [Test]
    public void GetPrepareWorkingTreeCommands_should_return_empty_for_dont_change()
    {
        CherryPickLocalChangesHelper.GetPrepareWorkingTreeCommands(LocalChangesAction.DontChange)
            .Should().BeEmpty();
    }

    [Test]
    public void GetPrepareWorkingTreeCommands_should_return_empty_for_stash()
    {
        CherryPickLocalChangesHelper.GetPrepareWorkingTreeCommands(LocalChangesAction.Stash)
            .Should().BeEmpty();
    }

    [Test]
    public void GetPrepareWorkingTreeCommands_should_return_reset_and_clean_for_reset()
    {
        IReadOnlyList<ArgumentString> commands = CherryPickLocalChangesHelper.GetPrepareWorkingTreeCommands(LocalChangesAction.Reset);

        commands.Should().HaveCount(2);
        commands[0].Arguments.Should().Be("reset --hard --quiet --");
        commands[1].Arguments.Should().Be("clean -d -f");
    }

    [Test]
    public void GetPrepareWorkingTreeCommands_should_return_add_all_for_merge()
    {
        CherryPickLocalChangesHelper.GetPrepareWorkingTreeCommands(LocalChangesAction.Merge)
            .Should().ContainSingle()
            .Which.Arguments.Should().Be("add -A");
    }

    [TestCase(LocalChangesAction.DontChange, true, false)]
    [TestCase(LocalChangesAction.DontChange, false, false)]
    [TestCase(LocalChangesAction.Merge, true, false)]
    [TestCase(LocalChangesAction.Reset, true, false)]
    [TestCase(LocalChangesAction.Stash, false, false)]
    [TestCase(LocalChangesAction.Stash, true, true)]
    public void ShouldStashBeforeCherryPick_should_only_stash_when_requested_and_dirty(LocalChangesAction action, bool hasUncommittedChanges, bool expected)
    {
        CherryPickLocalChangesHelper.ShouldStashBeforeCherryPick(action, hasUncommittedChanges)
            .Should().Be(expected);
    }
}
