namespace Atc.Kepware.Configuration.CLI.Commands.Settings;

public class TagsSearchCommandSettings : ChannelAndDeviceCommandBaseSettings
{
    [CommandOption("-q|--query <QUERY>")]
    [Description("Query")]
    public string Query { get; init; } = string.Empty;

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (string.IsNullOrEmpty(Query))
        {
            return ValidationResult.Error("--query is not set.");
        }

        return ValidationResult.Success();
    }
}