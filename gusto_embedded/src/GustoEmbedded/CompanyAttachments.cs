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

    public interface ICompanyAttachments
    {

        /// <summary>
        /// Get Company Attachment Details
        /// 
        /// <remarks>
        /// Retrieve the detail of an attachment uploaded by the company.<br/>
        /// <br/>
        /// scope: `company_attachments:read`
        /// </remarks>
        /// </summary>
        Task<GetV1CompaniesAttachmentResponse> GetDetailsAsync(string companyId, string companyAttachmentUuid, VersionHeader? xGustoAPIVersion = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFourMinus04Minus01);

        /// <summary>
        /// Get List of Company Attachments
        /// 
        /// <remarks>
        /// Retrieve a list of all the attachments uploaded by the company.<br/>
        /// <br/>
        /// scope: `company_attachments:read`
        /// </remarks>
        /// </summary>
        Task<GetV1CompaniesAttachmentsResponse> GetListAsync(string companyId, VersionHeader? xGustoAPIVersion = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFourMinus04Minus01);

        /// <summary>
        /// Create Company Attachment and Upload File
        /// 
        /// <remarks>
        /// Upload a file and create a company attachment. We recommend uploading<br/>
        /// PDF files for optimal compatibility. However, the following file types are<br/>
        /// allowed: .qbb, .qbm, .gif, .jpg, .png, .pdf, .xls, .xlsx, .doc and .docx. <br/>
        /// <br/>
        /// scope: `company_attachments:write`
        /// </remarks>
        /// </summary>
        Task<PostV1CompaniesAttachmentResponse> CreateAsync(string companyId, PostV1CompaniesAttachmentRequestBody requestBody, VersionHeader? xGustoAPIVersion = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFourMinus04Minus01);
    }

    public class CompanyAttachments: ICompanyAttachments
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.1.4";
        private const string _sdkGenVersion = "2.562.3";
        private const string _openapiDocVersion = "2024-04-01";
        private const string _userAgent = "speakeasy-sdk/csharp 0.1.4 2.562.3 2024-04-01 GustoEmbedded";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<GustoEmbedded.Models.Components.Security>? _securitySource;

        public CompanyAttachments(ISpeakeasyHttpClient client, Func<GustoEmbedded.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<GetV1CompaniesAttachmentResponse> GetDetailsAsync(string companyId, string companyAttachmentUuid, VersionHeader? xGustoAPIVersion = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFourMinus04Minus01)
        {
            var request = new GetV1CompaniesAttachmentRequest()
            {
                CompanyId = companyId,
                CompanyAttachmentUuid = companyAttachmentUuid,
                XGustoAPIVersion = xGustoAPIVersion,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/v1/companies/{company_id}/attachments/{company_attachment_uuid}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext(baseUrl, "get-v1-companies-attachment", new List<string> {  }, _securitySource);

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
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<Models.Components.CompanyAttachment>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new GetV1CompaniesAttachmentResponse()
                    {
                        HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        }
                    };
                    response.CompanyAttachment = obj;
                    return response;
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

        public async Task<GetV1CompaniesAttachmentsResponse> GetListAsync(string companyId, VersionHeader? xGustoAPIVersion = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFourMinus04Minus01)
        {
            var request = new GetV1CompaniesAttachmentsRequest()
            {
                CompanyId = companyId,
                XGustoAPIVersion = xGustoAPIVersion,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/v1/companies/{company_id}/attachments", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext(baseUrl, "get-v1-companies-attachments", new List<string> {  }, _securitySource);

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
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<List<Models.Components.CompanyAttachment>>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new GetV1CompaniesAttachmentsResponse()
                    {
                        HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        }
                    };
                    response.CompanyAttachmentList = obj;
                    return response;
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

        public async Task<PostV1CompaniesAttachmentResponse> CreateAsync(string companyId, PostV1CompaniesAttachmentRequestBody requestBody, VersionHeader? xGustoAPIVersion = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFourMinus04Minus01)
        {
            var request = new PostV1CompaniesAttachmentRequest()
            {
                CompanyId = companyId,
                RequestBody = requestBody,
                XGustoAPIVersion = xGustoAPIVersion,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/v1/companies/{company_id}/attachments", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);

            var serializedBody = RequestBodySerializer.Serialize(request, "RequestBody", "multipart", false, false);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext(baseUrl, "post-v1-companies-attachment", new List<string> {  }, _securitySource);

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
                    var obj = ResponseBodyDeserializer.Deserialize<Models.Components.CompanyAttachment>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new PostV1CompaniesAttachmentResponse()
                    {
                        HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        }
                    };
                    response.CompanyAttachment = obj;
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