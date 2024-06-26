namespace Atc.Kepware.Configuration.Services;

/// <summary>
/// KepwareConfigurationClient LoggerMessages.
/// </summary>
[SuppressMessage("Design", "MA0048:File name must match type name", Justification = "OK - By Design")]
[SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "OK")]
public partial class KepwareConfigurationClient
{
    private readonly ILogger logger;

    [LoggerMessage(
        EventId = LoggingEventIdConstants.ConnectionInformationNotSet,
        Level = LogLevel.Warning,
        Message = "Connection information is not set on the client.")]
    private partial void LogConnectionInformationNotSet();

    [LoggerMessage(
        EventId = LoggingEventIdConstants.GetSucceeded,
        Level = LogLevel.Trace,
        Message = "Successfully retrieved data from pathTemplate '{pathTemplate}'.")]
    private partial void LogGetSucceeded(
        string pathTemplate);

    [LoggerMessage(
        EventId = LoggingEventIdConstants.GetNotFound,
        Level = LogLevel.Warning,
        Message = "No content found when retrieving data from pathTemplate '{pathTemplate}'.")]
    private partial void LogGetNotFound(
        string pathTemplate);

    [LoggerMessage(
        EventId = LoggingEventIdConstants.GetFailure,
        Level = LogLevel.Error,
        Message = "Failed to retrieve data from pathTemplate '{pathTemplate}': '{errorMessage}'.")]
    private partial void LogGetFailure(
        string pathTemplate,
        string errorMessage);

    [LoggerMessage(
        EventId = LoggingEventIdConstants.PostSucceeded,
        Level = LogLevel.Trace,
        Message = "Successfully posted to pathTemplate '{pathTemplate}'.")]
    private partial void LogPostSucceeded(
        string pathTemplate);

    [LoggerMessage(
        EventId = LoggingEventIdConstants.PostFailure,
        Level = LogLevel.Error,
        Message = "Failed to post to pathTemplate '{pathTemplate}': '{errorMessage}'.")]
    private partial void LogPostFailure(
        string pathTemplate,
        string errorMessage);

    [LoggerMessage(
        EventId = LoggingEventIdConstants.PutSucceeded,
        Level = LogLevel.Trace,
        Message = "Successfully put to pathTemplate '{pathTemplate}'.")]
    private partial void LogPutSucceeded(
        string pathTemplate);

    [LoggerMessage(
        EventId = LoggingEventIdConstants.PutFailure,
        Level = LogLevel.Error,
        Message = "Failed to put to pathTemplate '{pathTemplate}': '{errorMessage}'.")]
    private partial void LogPutFailure(
        string pathTemplate,
        string errorMessage);

    [LoggerMessage(
        EventId = LoggingEventIdConstants.DeleteSucceeded,
        Level = LogLevel.Trace,
        Message = "Successfully deleted for pathTemplate '{pathTemplate}'.")]
    private partial void LogDeleteSucceeded(
        string pathTemplate);

    [LoggerMessage(
        EventId = LoggingEventIdConstants.DeleteFailure,
        Level = LogLevel.Error,
        Message = "Failed to delete for pathTemplate '{pathTemplate}': '{errorMessage}'.")]
    private partial void LogDeleteFailure(
        string pathTemplate,
        string errorMessage);
}
