[![](https://img.shields.io/nuget/v/soenneker.rebrickable.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.rebrickable.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.rebrickable.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.rebrickable.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.rebrickable.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.rebrickable.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.rebrickable.openapiclient/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.rebrickable.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Rebrickable.OpenApiClient

Generated request builders for Rebrickable LEGO sets, parts, colors, minifigures, elements, themes, and user collections.

## Installation

```bash
dotnet add package Soenneker.Rebrickable.OpenApiClient
```

## Usage

```csharp
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Rebrickable.OpenApiClient;

using var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Add("Authorization", $"key {apiKey}");

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient)
{
    BaseUrl = "https://rebrickable.com"
};

var client = new RebrickableOpenApiClient(adapter);
await using Stream colors = await client.Api.V3.Lego.Colors.GetAsync(
    cancellationToken: cancellationToken);
```

Rebrickable requires the literal `key ` prefix in the `Authorization` header. The generated operations return raw response streams because that is how the source schema describes their payloads; callers own and must dispose those streams.

List endpoints are paginated. Use the `page` and `page_size` query parameters or deserialize the response's `next` value rather than assuming the first stream contains every result.
