# Georgios Dimopoulos – Portfolio

My personal portfolio website, built with **Blazor WebAssembly** and **MudBlazor**, and hosted on **GitHub Pages**.

**Live site:** https://georgiosdimopoulos.github.io

## Pages

| Route | Content |
|---|---|
| `/` | Short introduction and navigation |
| `/work` | Professional experience |
| `/projects` | Public GitHub projects, hackathons and summits |
| `/studies` | Education and languages |
| `/life` | Places and milestones |

## Tech stack

- .NET 10 / C#
- Blazor WebAssembly
- MudBlazor
- GitHub Actions and GitHub Pages

## How it works

The content is kept separate from the UI. Pages ask a service for data, and the service loads a static JSON file and maps it to C# records.

```
Page (Razor)  →  Service (interface)  →  HttpClient  →  wwwroot/data/*.json
                                                              ↓
Page (Razor)  ←──────────────  C# records  ←──────────  deserialization
```

- Pages depend on service interfaces, registered through dependency injection.
- Each content page shows a loading state, and an error message if its data cannot be loaded.

### Why there is no database or API

The site is fully static and visitors only read content. JSON files under version control are enough for that: no server to host, no secrets to protect, and every content change is visible in the Git history. If the site ever needs to store data, the service interfaces are the place to plug in an API.

## Project structure

```
MyPortfolio/
├── Layout/              Header, footer and page frame
├── Models/              C# records for the content
├── Pages/               One Razor page per route
├── Services/            Data loading
│   └── Interfaces/      Service contracts
└── wwwroot/
    ├── css/             Styles
    ├── data/            Content as JSON
    └── images/          Pictures
```

## Run locally

You need the [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0).

```bash
git clone https://github.com/GeorgiosDimopoulos/GeorgiosDimopoulos.github.io.git
cd GeorgiosDimopoulos.github.io
dotnet watch --project MyPortfolio
```

Then open the address shown in the terminal.

## Updating the content

Edit the matching file in `MyPortfolio/wwwroot/data/`:

| File | Content |
|---|---|
| `jobs.json` | Work experience |
| `projects.json` | GitHub projects |
| `events.json` | Hackathons and summits |
| `studies.json` | Education |
| `languages.json` | Spoken languages |
| `life.json` | Life chapters, newest first |

Property names must match the records in `MyPortfolio/Models/`.

## Deployment

Every push to `main` runs the [GitHub Actions workflow](.github/workflows/deploy.yml), which publishes the app and deploys it to GitHub Pages.
