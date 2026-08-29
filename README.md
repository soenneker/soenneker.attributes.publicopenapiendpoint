[![](https://img.shields.io/nuget/v/soenneker.attributes.publicopenapiendpoint.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.attributes.publicopenapiendpoint/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.attributes.publicopenapiendpoint/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.attributes.publicopenapiendpoint/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.attributes.publicopenapiendpoint.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.attributes.publicopenapiendpoint/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.attributes.publicopenapiendpoint/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.attributes.publicopenapiendpoint/actions/workflows/codeql.yml)

# Soenneker.Attributes.PublicOpenApiEndpoint

For decorating controller endpoints that should be publicly accessible to see within OpenApi generation.

## Install

```bash
dotnet add package Soenneker.Attributes.PublicOpenApiEndpoint
```

## Quick start

```csharp
using Soenneker.Attributes.PublicOpenApiEndpoint;

[PublicSwaggerEndpoint]
public void HandleRequest()
{
    // This method now carries the marker metadata.
}
```

For decorating controller endpoints that should be publicly accessible to see within OpenApi generation.

## What you get

- `PublicSwaggerEndpointAttribute` — For decorating controller endpoints that should be publicly accessible to see within OpenApi generation.
