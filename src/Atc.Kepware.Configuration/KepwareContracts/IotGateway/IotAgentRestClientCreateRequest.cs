namespace Atc.Kepware.Configuration.KepwareContracts.IotGateway;

internal sealed class IotAgentRestClientCreateRequest : IotAgentCreateRequestBase, IIotAgentRestClientCreateRequest
{
    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.REST_CLIENT_URL")]
    public string Url { get; set; } = string.Empty;

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.REST_CLIENT_METHOD")]
    public IotAgentPublishHttpMethodType PublishHttpMethod { get; set; } = IotAgentPublishHttpMethodType.Post;

    /// <inheritdoc />
    [Range(100, 60000)]
    [JsonPropertyName("iot_gateway.AGENTTYPES_RATE_MS")]
    public int Rate { get; set; } = 10000;

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.AGENTTYPES_PUBLISH_FORMAT")]
    public IotAgentPublishFormatType PublishFormat { get; set; } = IotAgentPublishFormatType.Narrow;

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.AGENTTYPES_MAX_EVENTS")]
    public int MaxEventsPerPublish { get; set; }

    /// <inheritdoc />
    [Range(1, 30)]
    [JsonPropertyName("iot_gateway.AGENTTYPES_TIMEOUT_S")]
    public int TransactionTimeout { get; set; } = 5;

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.AGENTTYPES_SEND_INITIAL_UPDATE")]
    public bool SendInitialUpdate { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.REST_CLIENT_HTTP_HEADER")]
    public string HttpHeaders { get; set; } = string.Empty;

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.AGENTTYPES_MESSAGE_FORMAT")]
    public IotAgentPublishMessageFormatType PublishMessageFormat { get; set; } = IotAgentPublishMessageFormatType.Advanced;

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.REST_CLIENT_PUBLISH_MEDIA_TYPE")]
    public IotAgentPublishMediaType PublishMediaType { get; set; } = IotAgentPublishMediaType.Json;

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.REST_CLIENT_USERNAME")]
    public string? UserName { get; set; }

    /// <inheritdoc />
    [JsonPropertyName("iot_gateway.REST_CLIENT_PASSWORD")]
    public string? Password { get; set; }

    /// <inheritdoc />
    public override string ToString()
        => $"{base.ToString()}, {nameof(Url)}: {Url}, {nameof(PublishHttpMethod)}: {PublishHttpMethod}, {nameof(Rate)}: {Rate}, {nameof(PublishFormat)}: {PublishFormat}, {nameof(MaxEventsPerPublish)}: {MaxEventsPerPublish}, {nameof(TransactionTimeout)}: {TransactionTimeout}, {nameof(SendInitialUpdate)}: {SendInitialUpdate}, {nameof(HttpHeaders)}: {HttpHeaders}, {nameof(PublishMessageFormat)}: {PublishMessageFormat}, {nameof(PublishMediaType)}: {PublishMediaType}, {nameof(UserName)}: {UserName}, {nameof(Password)}: {Password}";
}