using Common.EnumStringValues;

namespace DevOps.VersionControl.Functions.RunGitAddCommand
{
    public enum StageType : byte
    {
        [EnumStringValue(StagingConstants.AllChanges)]
        AllChanges,
        [EnumStringValue(StagingConstants.OnlyNewAndModified)]
        OnlyNewAndModified,
        [EnumStringValue(StagingConstants.OnlyModifiedAndDeleted)]
        OnlyModifiedAndDeleted
    }
}
