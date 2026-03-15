namespace Portafolio.Models;

public sealed class SkillCategory
{
    public string Name { get; init; } = string.Empty;
    public IReadOnlyList<string> Skills { get; init; } = Array.Empty<string>();
}
