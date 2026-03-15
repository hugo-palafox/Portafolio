using Portafolio.Data;
using Portafolio.Models;

namespace Portafolio.Services;

public sealed class ProjectService
{
    public IReadOnlyList<Project> GetAllProjects() =>
        SeedData.Projects
            .OrderBy(project => project.SortOrder)
            .ToList();

    public IReadOnlyList<Project> GetFeaturedProjects() =>
        SeedData.Projects
            .Where(project => project.Featured)
            .OrderBy(project => project.SortOrder)
            .ToList();

    public Project? GetBySlug(string? slug) =>
        SeedData.Projects.FirstOrDefault(project =>
            project.Slug.Equals(slug ?? string.Empty, StringComparison.OrdinalIgnoreCase));
}
