using Soenneker.Rebrickable.OpenApiClient.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Rebrickable.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class RebrickableOpenApiClientTests : FixturedUnitTest
{
    private readonly IRebrickableOpenApiClient _kiota;

    public RebrickableOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _kiota = Resolve<IRebrickableOpenApiClient>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
