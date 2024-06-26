namespace Atc.Kepware.Configuration.Contracts.Connectivity;

public sealed class TagGroup
{
    /// <summary>
    /// The tag group name.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The tag group description.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Indicates if the Tag Group was autogenerated.
    /// </summary>
    public bool AutoGenerated { get; set; }

    /// <summary>
    /// List of tags assigned on this tag group.
    /// </summary>
    public IList<Tag> Tags { get; set; } = [];

    /// <summary>
    /// List of tag groups assigned on this tag group.
    /// </summary>
    public IList<TagGroup> TagGroups { get; set; } = [];

    public override string ToString()
        => $"{nameof(Name)}: {Name}, {nameof(Description)}: {Description}, {nameof(AutoGenerated)}: {AutoGenerated}, {nameof(Tags)}.Count: {Tags?.Count}, {nameof(TagGroups)}.Count: {TagGroups?.Count}";
}