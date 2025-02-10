//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace GustoEmbedded
{
    using GustoEmbedded.Hooks;
    using GustoEmbedded.Models.Components;
    using GustoEmbedded.Models.Errors;
    using GustoEmbedded.Models.Requests;
    using GustoEmbedded.Utils;
    using GustoEmbedded.Utils.Retries;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;

    public interface IWebhookSubscriptions
    {

        /// <summary>
        /// Create a webhook subscription
        /// 
        /// <remarks>
        /// Create a webhook subscription to receive events of the specified subscription_types whenever there is a state change.<br/>
        /// <br/>
        /// &gt; 📘 System Access Authentication<br/>
        /// &gt;<br/>
        /// &gt; This endpoint uses the <a href="https://docs.gusto.com/embedded-payroll/docs/system-access">Bearer Auth scheme with the system-level access token in the HTTP Authorization header</a>.<br/>
        /// <br/>
        /// scope: `webhook_subscriptions:write`
        /// </remarks>
        /// </summary>
        Task<PostV1WebhookSubscriptionResponse> CreateAsync(PostV1WebhookSubscriptionSecurity security, PostV1WebhookSubscriptionRequestBody requestBody, VersionHeader? xGustoAPIVersion = null);

        /// <summary>
        /// Request the webhook subscription verification_token
        /// 
        /// <remarks>
        /// Request that the webhook subscription `verification_token` be POSTed to the Subscription URL.<br/>
        /// <br/>
        /// &gt; 📘 System Access Authentication<br/>
        /// &gt;<br/>
        /// &gt; This endpoint uses the <a href="https://docs.gusto.com/embedded-payroll/docs/system-access">Bearer Auth scheme with the system-level access token in the HTTP Authorization header</a>.<br/>
        /// <br/>
        /// scope: `webhook_subscriptions:read`<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GetV1WebhookSubscriptionVerificationTokenUuidResponse> GetV1WebhookSubscriptionVerificationTokenUuidAsync(GetV1WebhookSubscriptionVerificationTokenUuidSecurity security, string webhookSubscriptionUuid, VersionHeader? xGustoAPIVersion = null);
    }

    public class WebhookSubscriptions: IWebhookSubscriptions
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.0.5";
        private const string _sdkGenVersion = "2.506.0";
        private const string _openapiDocVersion = "2024-04-01";
        private const string _userAgent = "speakeasy-sdk/csharp 0.0.5 2.506.0 2024-04-01 GustoEmbedded";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<GustoEmbedded.Models.Components.Security>? _securitySource;

        public WebhookSubscriptions(ISpeakeasyHttpClient client, Func<GustoEmbedded.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<PostV1WebhookSubscriptionResponse> CreateAsync(PostV1WebhookSubscriptionSecurity security, PostV1WebhookSubscriptionRequestBody requestBody, VersionHeader? xGustoAPIVersion = null)
        {
            var request = new PostV1WebhookSubscriptionRequest()
            {
                RequestBody = requestBody,
                XGustoAPIVersion = xGustoAPIVersion,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();

            var urlString = baseUrl + "/v1/webhook_subscriptions";

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);

            var serializedBody = RequestBodySerializer.Serialize(request, "RequestBody", "json", false, false);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            if (security == null)
            {
                throw new ArgumentNullException(nameof(security), "security cannot be null.");
            }

            httpRequest = new SecurityMetadata(() => security).Apply(httpRequest);
            var hookCtx = new HookContext("post-v1-webhook-subscription", null, () => security);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _client.SendAsync(httpRequest);
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode == 404 || _statusCode == 422 || _statusCode >= 400 && _statusCode < 500 || _statusCode >= 500 && _statusCode < 600)
                {
                    var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), httpResponse, null);
                    if (_httpResponse != null)
                    {
                        httpResponse = _httpResponse;
                    }
                }
            }
            catch (Exception error)
            {
                var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), null, error);
                if (_httpResponse != null)
                {
                    httpResponse = _httpResponse;
                }
                else
                {
                    throw;
                }
            }

            httpResponse = await this.SDKConfiguration.Hooks.AfterSuccessAsync(new AfterSuccessContext(hookCtx), httpResponse);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 201)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<WebhookSubscription>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new PostV1WebhookSubscriptionResponse()
                    {
                        HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        }
                    };
                    response.WebhookSubscription = obj;
                    return response;
                }

                throw new Models.Errors.APIException("Unknown content type received", httpRequest, httpResponse);
            }
            else if(responseStatusCode == 422)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<UnprocessableEntityErrorObject>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    throw obj!;
                }

                throw new Models.Errors.APIException("Unknown content type received", httpRequest, httpResponse);
            }
            else if(responseStatusCode == 404 || responseStatusCode >= 400 && responseStatusCode < 500)
            {
                throw new Models.Errors.APIException("API error occurred", httpRequest, httpResponse);
            }
            else if(responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new Models.Errors.APIException("API error occurred", httpRequest, httpResponse);
            }

            throw new Models.Errors.APIException("Unknown status code received", httpRequest, httpResponse);
        }

        public async Task<GetV1WebhookSubscriptionVerificationTokenUuidResponse> GetV1WebhookSubscriptionVerificationTokenUuidAsync(GetV1WebhookSubscriptionVerificationTokenUuidSecurity security, string webhookSubscriptionUuid, VersionHeader? xGustoAPIVersion = null)
        {
            var request = new GetV1WebhookSubscriptionVerificationTokenUuidRequest()
            {
                WebhookSubscriptionUuid = webhookSubscriptionUuid,
                XGustoAPIVersion = xGustoAPIVersion,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/v1/webhook_subscriptions/{webhook_subscription_uuid}/request_verification_token", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);

            if (security == null)
            {
                throw new ArgumentNullException(nameof(security), "security cannot be null.");
            }

            httpRequest = new SecurityMetadata(() => security).Apply(httpRequest);
            var hookCtx = new HookContext("get-v1-webhook-subscription-verification-token-uuid", null, () => security);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _client.SendAsync(httpRequest);
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode == 404 || _statusCode >= 400 && _statusCode < 500 || _statusCode >= 500 && _statusCode < 600)
                {
                    var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), httpResponse, null);
                    if (_httpResponse != null)
                    {
                        httpResponse = _httpResponse;
                    }
                }
            }
            catch (Exception error)
            {
                var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), null, error);
                if (_httpResponse != null)
                {
                    httpResponse = _httpResponse;
                }
                else
                {
                    throw;
                }
            }

            httpResponse = await this.SDKConfiguration.Hooks.AfterSuccessAsync(new AfterSuccessContext(hookCtx), httpResponse);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 200)
            {                
                return new GetV1WebhookSubscriptionVerificationTokenUuidResponse()
                {
                    HttpMeta = new Models.Components.HTTPMetadata()
                    {
                        Response = httpResponse,
                        Request = httpRequest
                    }
                };
            }
            else if(responseStatusCode == 404 || responseStatusCode >= 400 && responseStatusCode < 500)
            {
                throw new Models.Errors.APIException("API error occurred", httpRequest, httpResponse);
            }
            else if(responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new Models.Errors.APIException("API error occurred", httpRequest, httpResponse);
            }

            throw new Models.Errors.APIException("Unknown status code received", httpRequest, httpResponse);
        }
    }
}