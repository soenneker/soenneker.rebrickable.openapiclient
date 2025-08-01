// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Rebrickable.OpenApiClient.Api.V3.Lego.Parts.Item;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Rebrickable.OpenApiClient.Api.V3.Lego.Parts
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v3\lego\parts
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class PartsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The EmptyPathSegment property</summary>
        public global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Lego.Parts.EmptyPathSegmentRequestBuilder EmptyPathSegment
        {
            get => new global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Lego.Parts.EmptyPathSegmentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Soenneker.Rebrickable.OpenApiClient.api.v3.lego.parts.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Lego.Parts.Item.WithPart_numItemRequestBuilder"/></returns>
        public global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Lego.Parts.Item.WithPart_numItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("part_num", position);
                return new global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Lego.Parts.Item.WithPart_numItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Lego.Parts.PartsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PartsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v3/lego/parts", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Lego.Parts.PartsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PartsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v3/lego/parts", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
