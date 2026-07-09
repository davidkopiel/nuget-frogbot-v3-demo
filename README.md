# nuget-frogbot-v3-demo

A multi-package demo repo, set up to be scanned by [JFrog Frogbot v3](https://docs.jfrog.com/security/docs/frogbot-v3):

- `src/NugetFrogbotV3Demo/` — the original .NET console app and its NuGet dependencies
- `src/PaymentsService/`, `src/InventoryService/` — additional .NET solutions, to demo scanning a repo with multiple `.sln` files
- `package.json` at the repo root — an npm package alongside the .NET solutions, to demo multi-ecosystem scanning in the same repo

## Run

```bash
# .NET
dotnet run --project src/NugetFrogbotV3Demo

# npm
npm install
npm start
```

## Frogbot

See [.github/workflows/frogbot.yml](.github/workflows/frogbot.yml). It scans pull requests targeting `main` and runs a full repository scan on push/schedule/dispatch.

Required repository secrets:

| Secret | Description |
| --- | --- |
| `JF_URL` | JFrog platform URL |
| `JF_ACCESS_TOKEN` | JFrog access token (OIDC recommended) |

`JF_GIT_TOKEN` uses the built-in `GITHUB_TOKEN` and needs no manual setup..