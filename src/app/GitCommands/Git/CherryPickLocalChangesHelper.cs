using GitExtensions.Extensibility;
using GitExtensions.Extensibility.Git;
using GitExtUtils;

namespace GitCommands.Git;

public static class CherryPickLocalChangesHelper
{
    public static IReadOnlyList<ArgumentString> GetPrepareWorkingTreeCommands(LocalChangesAction action)
    {
        return action switch
        {
            LocalChangesAction.Reset =>
            [
                Commands.Reset(ResetMode.Hard),
                Commands.Clean(CleanMode.OnlyNonIgnored, dryRun: false, directories: true)
            ],
            LocalChangesAction.Merge => [Commands.AddAll()],
            _ => []
        };
    }

    public static bool ShouldStashBeforeCherryPick(LocalChangesAction action, bool hasUncommittedChanges)
        => action == LocalChangesAction.Stash && hasUncommittedChanges;
}
