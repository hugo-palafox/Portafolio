# HANDOFF

## Project Snapshot
- Stack: Blazor WebAssembly (.NET 8), CSS-first styling in `wwwroot/css/app.css`.
- Canonical app root: repository root (`Portafolio.csproj` + `Portafolio.sln`).
- Main data source: `Data/SeedData.cs` (home content, projects, skills, nav).
- Services are read-only wrappers over seed data.

## Quick Start
- Build: `dotnet build Portafolio.sln -c Release`
- Run (dev): `dotnet run --project Portafolio.csproj`

## Key Behavior Contracts
- Home featured projects come from `ProjectService.GetFeaturedProjects()`.
- A project appears on Home only when `Featured = true` in `SeedData.Projects`.
- Route map:
  - `/` Home
  - `/about` About
  - `/projects` Projects
  - `/projects/{slug}` Project detail
  - `/skills` Skills
  - `/resume` Resume
  - `/contact` Contact

## High-Impact Files
- `Pages/Home.razor`: hero architecture snapshot + featured projects section.
- `Pages/Contact.razor`: professional inquiry form (frontend-only, submit disabled).
- `Pages/Resume.razor`: preview-and-download experience with inline PDF.
- `Layouts/MainLayout.razor` + `.css`: top nav + mobile drawer sheet.
- `wwwroot/index.html`: default SEO/share metadata (`title`, `description`, `og:*`).
- `wwwroot/css/app.css`: shared visual system and page-specific classes.

## Current UX/Content Decisions
- Mobile drawer is a left slide-over sheet with overlay, close button, and Escape close.
- Contact form is non-live by design (`Send Message (Coming soon)`), no backend hooks.
- Resume page uses iframe preview for `/assets/resume/Hugo-Palafox-Resume.pdf`.
- Share title is grounded to `Hugo Palafox | Robotics & Automation Systems Engineer`.

## Known Cleanup Item
- `DEVELOPMENT_LOG.md` contains some historical encoding artifacts from older sessions.
- Keep app code as source of truth; rely on this file + `TASK_PROGRESS.md` for fast onboarding.

## Next Practical Priorities
- Add unique media for projects currently reusing placeholder/hero images.
- Add architecture diagrams to relevant project detail pages.
- Curate final tag taxonomy for cleaner project card consistency.
