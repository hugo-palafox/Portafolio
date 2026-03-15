namespace Portafolio.Models;

public sealed class HomeContent
{
    public string Name { get; init; } = string.Empty;
    public string Headline { get; init; } = string.Empty;
    public string Subheadline { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public IReadOnlyList<CapabilityPillar> Pillars { get; init; } = Array.Empty<CapabilityPillar>();
    public IReadOnlyList<Metric> Metrics { get; init; } = Array.Empty<Metric>();
}
