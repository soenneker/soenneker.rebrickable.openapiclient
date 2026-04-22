using Soenneker.Tests.HostedUnit;

namespace Soenneker.Rebrickable.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class RebrickableOpenApiClientTests : HostedUnitTest
{
    public RebrickableOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
