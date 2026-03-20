namespace Portafolio.Models;

public sealed class Project
{
    public string Id { get; init; } = string.Empty;
    public string Slug { get; init; } = string.Empty;
    public string Title { get; init; } = string.Empty;
    public string Category { get; init; } = string.Empty;
    public string ShortSummary { get; init; } = string.Empty;
    public string Problem { get; init; } = string.Empty;
    public string ArchitectureSummary { get; init; } = string.Empty;
    public string Role { get; init; } = string.Empty;
    public string TechnicalChallenges { get; init; } = string.Empty;
    public IReadOnlyList<string> TechStack { get; init; } = Array.Empty<string>();
    public string Outcome { get; init; } = string.Empty;
    public IReadOnlyList<string> Tags { get; init; } = Array.Empty<string>();
    public string HeroImage { get; init; } = string.Empty;
    public string MediaSectionTitle { get; init; } = "Media";
    public IReadOnlyList<ProjectMediaBlock> MediaBlocks { get; init; } = Array.Empty<ProjectMediaBlock>();
    public IReadOnlyList<string> GalleryImages { get; init; } = Array.Empty<string>();
    public bool Featured { get; init; }
    public int SortOrder { get; init; }
}

public sealed class ProjectMediaBlock
{
    public string Title { get; init; } = string.Empty;
    public string ImagePath { get; init; } = string.Empty;
    public string Caption { get; init; } = string.Empty;
}
