<<<<<<< HEAD
# nuget-frogbot-v3-demo.
=======
#jj:wq
 nuget-frogbot-v3-demo
>>>>>>> 3735467b49f024a6d09ba3810a5959670925c086

A minimal .NET console app with a NuGet dependency, set up to be scanned by [JFrog Frogbot v3](https://docs.jfrog.com/security/docs/frogbot-v3).

## Run

```bash
dotnet run
```

## Frogbot

See [.github/workflows/frogbot.yml](.github/workflows/frogbot.yml). It scans pull requests targeting `main` and runs a full repository scan on push/schedule/dispatch.

Required repository secrets:

| Secret | Description |
| --- | --- |
| `JF_URL` | JFrog platform URL |
| `JF_ACCESS_TOKEN` | JFrog access token (OIDC recommended) |

`JF_GIT_TOKEN` uses the built-in `GITHUB_TOKEN` and needs no manual setup..