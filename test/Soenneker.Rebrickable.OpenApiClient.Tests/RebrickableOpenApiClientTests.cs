using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Rebrickable.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class RebrickableOpenApiClientTests : FixturedUnitTest
{
    public RebrickableOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
