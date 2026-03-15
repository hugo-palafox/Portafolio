using Portafolio.Data;
using Portafolio.Models;

namespace Portafolio.Services;

public sealed class HomeContentService
{
    public HomeContent GetContent() => SeedData.Home;

    public IReadOnlyList<NavItem> GetNavigationItems() => SeedData.NavItems;
}
