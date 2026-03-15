using Portafolio.Data;
using Portafolio.Models;

namespace Portafolio.Services;

public sealed class SkillService
{
    public IReadOnlyList<SkillCategory> GetSkillCategories() => SeedData.SkillCategories;
}
