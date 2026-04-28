using System;
using Shoko.Abstractions.Plugin;

namespace Shoko.Plugin.OfflineImporter;

/// <summary>
/// Plugin responsible for importing releases based on file names.
/// </summary>
public class Plugin : IPlugin
{
    /// <inheritdoc/>
    public Guid ID { get; private init; } = new("72a6ff39-2bff-534c-9216-d03cd38e7346");

    /// <inheritdoc/>
    public string Name { get; private init; } = "Offline Importer";

    /// <inheritdoc/>
    public string Description { get; private init; } = """
        Plugin responsible for importing releases based on file names.
    """;
}
