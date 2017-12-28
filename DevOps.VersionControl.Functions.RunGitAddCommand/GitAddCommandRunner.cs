using Common.EnumStringValues;
using static DevOps.VersionControl.Functions.RunGitCommand.GitCommandRunner;

namespace DevOps.VersionControl.Functions.RunGitAddCommand
{
    public static class GitAddCommandRunner
    {
        private const string add = nameof(add);

        public static void Add(string directory, StageType stageType = StageType.AllChanges)
            => Git(directory,
                command: add,
                stageType.GetStringValue());
    }
}
