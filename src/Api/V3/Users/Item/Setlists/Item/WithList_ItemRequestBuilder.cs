// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Rebrickable.OpenApiClient.Api.V3.Users.Item.Setlists.Item.Sets;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Rebrickable.OpenApiClient.Api.V3.Users.Item.Setlists.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v3\users\{user_token}\setlists\{list_id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithList_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The EmptyPathSegment property</summary>
        public global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Users.Item.Setlists.Item.EmptyPathSegmentRequestBuilder EmptyPathSegment
        {
            get => new global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Users.Item.Setlists.Item.EmptyPathSegmentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The sets property</summary>
        public global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Users.Item.Setlists.Item.Sets.SetsRequestBuilder Sets
        {
            get => new global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Users.Item.Setlists.Item.Sets.SetsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Users.Item.Setlists.Item.WithList_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithList_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v3/users/{user_token}/setlists/{list_id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Users.Item.Setlists.Item.WithList_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithList_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v3/users/{user_token}/setlists/{list_id}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
