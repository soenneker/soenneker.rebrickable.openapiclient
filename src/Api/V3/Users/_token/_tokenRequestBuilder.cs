// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Rebrickable.OpenApiClient.Api.V3.Users._token
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v3\users\_token
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class _tokenRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The EmptyPathSegment property</summary>
        public global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Users._token.EmptyPathSegmentRequestBuilder EmptyPathSegment
        {
            get => new global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Users._token.EmptyPathSegmentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Users._token._tokenRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public _tokenRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v3/users/_token", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Users._token._tokenRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public _tokenRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v3/users/_token", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
