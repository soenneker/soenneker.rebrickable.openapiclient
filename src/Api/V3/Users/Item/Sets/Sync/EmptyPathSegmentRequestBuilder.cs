// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.Rebrickable.OpenApiClient.Api.V3.Users.Item.Sets.Sync
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v3\users\{user_token}\sets\sync\
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class EmptyPathSegmentRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Users.Item.Sets.Sync.EmptyPathSegmentRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EmptyPathSegmentRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v3/users/{user_token}/sets/sync/", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Users.Item.Sets.Sync.EmptyPathSegmentRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EmptyPathSegmentRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v3/users/{user_token}/sets/sync/", rawUrl)
        {
        }
        /// <summary>
        /// Synchronise a user&apos;s Sets to the POSTed list.### Set List logicThis is used to completely replace the user&apos;s Sets with those in the supplied list.It will remove any Sets in Rebrickable that are not found in the supplied list.It will attempt to keep any current Rebrickable Sets in their existing Set Lists, and will add any new Setsfound into the Default Set List for Imports in the user&apos;s settings.### Single SetWhen adding a single Set, returns the successfully created Set (status 201) or details for why the Set could notbe added.### Multiple SetsTo add multiple Sets, POST a JSON list of them (using a Content-Type header of &apos;application/json&apos;).e.g:`[{&quot;set_num&quot;:&quot;8043-1&quot;, &quot;quantity&quot;: 1}, {&quot;set_num&quot;:&quot;8110-1&quot;, &quot;quantity&quot;: 2, &quot;include_spares&quot;: &quot;False&quot;}]`Returns a list of successfully added Sets. If the Set is unrecognised, it will be skipped.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Users.Item.Sets.Sync.PostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task PostAsync(global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Users.Item.Sets.Sync.PostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Synchronise a user&apos;s Sets to the POSTed list.### Set List logicThis is used to completely replace the user&apos;s Sets with those in the supplied list.It will remove any Sets in Rebrickable that are not found in the supplied list.It will attempt to keep any current Rebrickable Sets in their existing Set Lists, and will add any new Setsfound into the Default Set List for Imports in the user&apos;s settings.### Single SetWhen adding a single Set, returns the successfully created Set (status 201) or details for why the Set could notbe added.### Multiple SetsTo add multiple Sets, POST a JSON list of them (using a Content-Type header of &apos;application/json&apos;).e.g:`[{&quot;set_num&quot;:&quot;8043-1&quot;, &quot;quantity&quot;: 1}, {&quot;set_num&quot;:&quot;8110-1&quot;, &quot;quantity&quot;: 2, &quot;include_spares&quot;: &quot;False&quot;}]`Returns a list of successfully added Sets. If the Set is unrecognised, it will be skipped.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Users.Item.Sets.Sync.PostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Users.Item.Sets.Sync.PostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/octet-stream");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/x-www-form-urlencoded", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Users.Item.Sets.Sync.EmptyPathSegmentRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Users.Item.Sets.Sync.EmptyPathSegmentRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.Rebrickable.OpenApiClient.Api.V3.Users.Item.Sets.Sync.EmptyPathSegmentRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class EmptyPathSegmentRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
