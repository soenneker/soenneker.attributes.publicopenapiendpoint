using System;

namespace Soenneker.Attributes.PublicOpenApiEndpoint;

/// <summary>
/// For decorating controller endpoints that should be publicly accessible to see within OpenApi generation
/// </summary>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
public class PublicSwaggerEndpointAttribute : Attribute
{
}