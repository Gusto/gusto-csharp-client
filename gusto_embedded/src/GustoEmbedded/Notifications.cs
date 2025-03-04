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

    public interface INotifications
    {

        /// <summary>
        /// Get a notification&apos;s details
        /// 
        /// <remarks>
        /// Upon receiving a notification webhook event, use this endpoint to fetch the notification&apos;s details. The notification details include basic suggested content that can help you build notifications in your platform.<br/>
        /// <br/>
        /// Note: partners are responsible for the delivery and any custom state management of notifications in their application. Refer to our <a href="https://docs.gusto.com/embedded-payroll/docs/partner-notifications">partner notification guide</a> for more details.<br/>
        /// <br/>
        /// If the notification UUID is not found, the response will be 404 Not Found. If the notification&apos;s supporting data is no longer valid, the response will be 422 Unprocessable Entity.<br/>
        /// <br/>
        /// scope: `notifications:read`
        /// </remarks>
        /// </summary>
        Task<GetNotificationsNotificationUuidResponse> GetDetailsAsync(string notificationUuid, VersionHeader? xGustoAPIVersion = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFour0401);
    }

    public class Notifications: INotifications
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.0.11";
        private const string _sdkGenVersion = "2.539.1";
        private const string _openapiDocVersion = "2024-04-01";
        private const string _userAgent = "speakeasy-sdk/csharp 0.0.11 2.539.1 2024-04-01 GustoEmbedded";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<GustoEmbedded.Models.Components.Security>? _securitySource;

        public Notifications(ISpeakeasyHttpClient client, Func<GustoEmbedded.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<GetNotificationsNotificationUuidResponse> GetDetailsAsync(string notificationUuid, VersionHeader? xGustoAPIVersion = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFour0401)
        {
            var request = new GetNotificationsNotificationUuidRequest()
            {
                NotificationUuid = notificationUuid,
                XGustoAPIVersion = xGustoAPIVersion,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/v1/notifications/{notification_uuid}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("get-notifications-notification_uuid", null, _securitySource);

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
            if(responseStatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<Notification>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new GetNotificationsNotificationUuidResponse()
                    {
                        HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        }
                    };
                    response.Notification = obj;
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
    }
}