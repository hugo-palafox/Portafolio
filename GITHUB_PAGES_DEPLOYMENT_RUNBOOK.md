# GitHub Pages Deployment Runbook (Portafolio)

## Overview: What Was Done

This repository is configured to deploy automatically to GitHub Pages using GitHub Actions.

Implemented items:
- Added deployment workflow at `.github/workflows/deploy-github-pages.yml`.
- Configured workflow to:
  - Build and publish Blazor WebAssembly (`dotnet publish -c Release`).
  - Keep `<base href="/" />` for root-domain routing.
  - Copy root `CNAME` into published output.
  - Copy `index.html` to `404.html` for SPA deep-link fallback.
  - Deploy using official GitHub Pages actions.
- Enabled GitHub Pages in repository settings with source set to `GitHub Actions`.
- Deployed successfully to:
  - `https://hugodavidpalafox.com/`

---

## Files Involved

- Workflow:
  - `.github/workflows/deploy-github-pages.yml`
- Documentation:
  - `README.md`

---

## One-Time Setup (Per Repository)

1. Push workflow file to default branch (`main`).
2. In GitHub: `Settings > Pages`
   - Set `Build and deployment > Source` to `GitHub Actions`.
3. In GitHub: `Settings > Actions > General`
   - Set `Workflow permissions` to `Read and write permissions`.
4. Save settings.

---

## Standard Deploy Process (Repeatable)

1. Make code/content changes locally.
2. Commit and push to `main`.

```bash
git add .
git commit -m "your message"
git push origin main
```

3. Open GitHub `Actions` tab.
4. Wait for workflow **Build & Deploy** to complete.
5. Validate site:
   - `https://hugodavidpalafox.com/`

If needed, manually trigger:
- `Actions > Build & Deploy > Run workflow`.

---

## Troubleshooting

### Error: `Failed to create deployment (status: 404)`

Cause:
- GitHub Pages is not fully enabled for Actions yet, or permissions are insufficient.

Fix:
1. Confirm `Settings > Pages > Source = GitHub Actions`.
2. Confirm `Settings > Actions > General > Workflow permissions = Read and write`.
3. Re-run workflow.
4. If still failing, reset Pages source once:
   - switch to `Deploy from a branch`, save;
   - switch back to `GitHub Actions`, save;
   - re-run workflow.

### App loads but routes fail on refresh/deep links

Cause:
- Missing SPA fallback.

Fix:
- Ensure workflow copies `index.html` to `404.html`.

### CSS/assets load incorrectly on Pages

Cause:
- Incorrect base path.

Fix:
- For root domain/custom domain, keep:
  - `<base href="/">`
- For project site (`/<repo>/`):
  - set `<base href="/<repo>/">` during deployment.

---

## Changing Hosting Target Later

If moving from root domain/custom domain to project URL (`/<repo>/`):

1. Update deployment base path:
   - from `/` to `/<repo>/`
2. Commit and push.
3. Re-run workflow.

---

## Operational Notes

- Node 20 deprecation warnings in GitHub Actions are currently warnings, not deployment blockers.
- Keep workflow action versions current when GitHub publishes Node 24-compatible updates.
