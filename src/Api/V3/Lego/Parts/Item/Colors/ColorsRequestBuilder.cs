// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.Rebrickable.OpenApiClient.Api.V3.Lego.Parts.Item.Colors.Item;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.Rebrickable.OpenApiClient.Api.V3.Lego.Parts.Item.Colors
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v3\lego\parts\{part_num}\colors
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ColorsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The EmptyPathSegment property</summary>
        public global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Lego.Parts.Item.Colors.EmptyPathSegmentRequestBuilder EmptyPathSegment
        {
            get => new global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Lego.Parts.Item.Colors.EmptyPathSegmentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Soenneker.Rebrickable.OpenApiClient.api.v3.lego.parts.item.colors.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Lego.Parts.Item.Colors.Item.WithColor_ItemRequestBuilder"/></returns>
        public global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Lego.Parts.Item.Colors.Item.WithColor_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("color_id", position);
                return new global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Lego.Parts.Item.Colors.Item.WithColor_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Lego.Parts.Item.Colors.ColorsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ColorsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v3/lego/parts/{part_num}/colors", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Lego.Parts.Item.Colors.ColorsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ColorsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v3/lego/parts/{part_num}/colors", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
