namespace Atc.Kepware.Configuration.CLI.Commands.IotGateway.IotItem;

public sealed class RestServerIotItemCreateCommand : AsyncCommand<IotItemCreateCommandSettings>
{
    private readonly ILoggerFactory loggerFactory;
    private readonly ILogger<RestServerIotItemCreateCommand> logger;
    private readonly IKepwareConfigurationClient kepwareConfigurationClient;

    public RestServerIotItemCreateCommand(
        ILoggerFactory loggerFactory,
        IKepwareConfigurationClient kepwareConfigurationClient)
    {
        this.loggerFactory = loggerFactory;
        logger = loggerFactory.CreateLogger<RestServerIotItemCreateCommand>();
        this.kepwareConfigurationClient = kepwareConfigurationClient;
    }

    public override Task<int> ExecuteAsync(
        CommandContext context,
        IotItemCreateCommandSettings settings)
    {
        ConsoleHelper.WriteHeader();

        throw new NotImplementedException();
    }
}