namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotItem;

public sealed class IotItemDisableCommand : AsyncCommand<IotItemGetCommandSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<IotItemDisableCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public IotItemDisableCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<IotItemDisableCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotItemGetCommandSettings settings)
    {
        ArgumentNullException.ThrowIfNull(context);
        ArgumentNullException.ThrowIfNull(settings);

        return ExecuteInternalAsync(settings);
    }

    [SuppressMessage("Design", "MA0051:Method is too long", Justification = "OK.")]
    private async Task<int> ExecuteInternalAsync(
        IotItemGetCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        try
        {
            kepwareConfigurationClient.SetConnectionInformation(
                new Uri(settings.ServerUrl),
                settings.UserName!.Value,
                settings.Password!.Value);

            var iotAgentResult = await kepwareConfigurationClient.GetIotAgentBase(
                settings.IotAgentName,
                CancellationToken.None);

            if (!iotAgentResult.CommunicationSucceeded)
            {
                return ConsoleExitStatusCodes.Failure;
            }

            if (!iotAgentResult.HasData)
            {
                logger.LogWarning("Iot Agent does not exist!");
                return ConsoleExitStatusCodes.Success;
            }

            var iotItemResult = await kepwareConfigurationClient.GetIotAgentIotItem(
                settings.IotAgentName,
                CommandHelper.GetIotItemInternalNameFromServerTag(settings.ServerTag),
                CancellationToken.None);

            if (iotItemResult is { CommunicationSucceeded: true, HasData: false })
            {
                logger.LogWarning("Iot Agent Iot Item does not exist!");
                return ConsoleExitStatusCodes.Success;
            }

            if (!iotItemResult.Data!.Enabled)
            {
                logger.LogWarning("Iot Agent Iot Item already disabled!");
                return ConsoleExitStatusCodes.Success;
            }

            var result = await kepwareConfigurationClient.DisableIotAgentIotItem(
                settings.IotAgentName,
                iotAgentResult.Data!.ProjectId,
                CommandHelper.GetIotItemInternalNameFromServerTag(settings.ServerTag),
                CancellationToken.None);

            if (result is { CommunicationSucceeded: false, Data: false })
            {
                return ConsoleExitStatusCodes.Failure;
            }
        }
        catch (Exception ex)
        {
            logger.LogError($"{EmojisConstants.Error} {ex.GetMessage()}");
            return ConsoleExitStatusCodes.Failure;
        }

        logger.LogInformation($"{EmojisConstants.Success} Done");
        return ConsoleExitStatusCodes.Success;
    }
}