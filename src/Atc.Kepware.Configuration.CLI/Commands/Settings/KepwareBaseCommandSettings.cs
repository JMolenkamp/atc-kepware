namespace Atc.Kepware.Configuration.CLI.Commands.Settings;

public class KepwareBaseCommandSettings : BaseCommandSettings
{
    [CommandOption("-s|--server-url <SERVER-URL>")]
    [Description("Server Url for Kepserver configuration endpoint")]
    public string ServerUrl { get; init; } = string.Empty;

    [CommandOption("-u|--username [USERNAME]")]
    [Description("UserName for Kepware server configuration endpoint")]
    public FlagValue<string>? UserName { get; init; }

    [CommandOption("-p|--password [PASSWORD]")]
    [Description("Password for Kepware server configuration endpoint")]
    public FlagValue<string>? Password { get; init; }

    public override ValidationResult Validate()
    {
        var validationResult = base.Validate();
        if (!validationResult.Successful)
        {
            return validationResult;
        }

        if (string.IsNullOrEmpty(ServerUrl))
        {
            return ValidationResult.Error("--server-url is not set.");
        }

        if (Uri.TryCreate(ServerUrl, UriKind.Relative, out _))
        {
            return ValidationResult.Error("--server-url is invalid.");
        }

        if ((UserName is not null && UserName.IsSet && Password is not null && !Password.IsSet) ||
            (UserName is not null && !UserName.IsSet && Password is not null && Password.IsSet))
        {
            return ValidationResult.Error("Both username and password must be set.");
        }

        return ValidationResult.Success();
    }

    public static ValidationResult IsValidName(
        string parameterValue)
        => IsValidName("name", parameterValue);

    public static ValidationResult IsValidName(
        string parameterName,
        string parameterValue)
        => System.ComponentModel.DataAnnotations.KeyStringAttribute.TryIsValid(
            parameterValue,
            KepwareConfigurationClient.NameKeyStringAttribute,
            out var errorMessage)
            ? ValidationResult.Success()
            : ValidationResult.Error($"--{parameterName}: {errorMessage}");
}