[![](https://img.shields.io/nuget/v/soenneker.attributes.publicopenapiendpoint.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.attributes.publicopenapiendpoint/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.attributes.publicopenapiendpoint/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.attributes.publicopenapiendpoint/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.attributes.publicopenapiendpoint.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.attributes.publicopenapiendpoint/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.attributes.publicopenapiendpoint/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.attributes.publicopenapiendpoint/actions/workflows/codeql.yml)

# Soenneker.Attributes.PublicOpenApiEndpoint

A marker attribute for identifying controllers or actions that belong in a public OpenAPI document.

## Installation

```bash
dotnet add package Soenneker.Attributes.PublicOpenApiEndpoint
```

## Usage

Mark an entire controller:

```csharp
using Microsoft.AspNetCore.Mvc;
using Soenneker.Attributes.PublicOpenApiEndpoint;

[ApiController]
[Route("api/status")]
[PublicSwaggerEndpoint]
public sealed class StatusController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok(new { status = "available" });
}
```

Or apply `[PublicSwaggerEndpoint]` to individual action methods.

## Important behavior

- The public type is named `PublicSwaggerEndpointAttribute`; C# permits the shorter `[PublicSwaggerEndpoint]` syntax.
- It can be placed on classes or methods and is inherited by default.
- This package supplies metadata only. Installing or applying it does not configure ASP.NET Core, expose an endpoint anonymously, or filter an OpenAPI document by itself.
- Your OpenAPI document or operation filter must explicitly look for this attribute.
- Treat it as documentation-selection metadata, not an authorization control. Configure authentication and authorization separately.
