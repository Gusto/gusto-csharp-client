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

    public interface ITaxRequirements
    {

        /// <summary>
        /// Get State Tax Requirements
        /// 
        /// <remarks>
        /// Get all tax requirements for a given state.<br/>
        /// <br/>
        /// ### Metadata Examples<br/>
        /// <br/>
        /// ```json select<br/>
        /// {<br/>
        ///   &quot;type&quot;: &quot;select&quot;,<br/>
        ///   &quot;options&quot;: [<br/>
        ///     { &quot;label&quot;: &quot;Semiweekly&quot;,  value: &quot;Semi-weekly&quot; },<br/>
        ///     { &quot;label&quot;: &quot;Monthly&quot;,  value: &quot;Monthly&quot; },<br/>
        ///     { &quot;label&quot;: &quot;Quarterly&quot;,  value: &quot;Quarterly&quot; },<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// ```json radio<br/>
        /// {<br/>
        ///   &quot;type&quot;: &quot;radio&quot;,<br/>
        ///   &quot;options&quot;: [<br/>
        ///     { &quot;label&quot;: &quot;No, we cannot reimburse&quot;,  value: false, short_label: &quot;Not Reimbursable&quot; },<br/>
        ///     { &quot;label&quot;: &quot;Yes, we can reimburse&quot;,  value: true, short_label: &quot;Reimbursable&quot; },<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```<br/>
        /// ```json account_number<br/>
        /// {<br/>
        ///   &quot;type&quot;: &quot;account_number&quot;,<br/>
        ///   &quot;mask&quot;: &quot;######-##&apos;,<br/>
        ///   &quot;prefix&quot;: null<br/>
        /// }<br/>
        /// ```<br/>
        /// ```json tax_rate<br/>
        /// {<br/>
        ///   &quot;type&quot;: &quot;tax_rate&quot;,<br/>
        ///   &quot;validation&quot;: {<br/>
        ///     &quot;type&quot;: &quot;min_max&quot;,<br/>
        ///     &quot;min&quot;: &quot;0.0004&quot;,<br/>
        ///     &quot;max&quot;: &quot;0.081&quot;<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// <br/>
        /// scope: `company_tax_requirements:read`<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GetV1CompaniesCompanyUuidTaxRequirementsStateResponse> GetAsync(string companyUuid, string state, bool? scheduling = null, VersionHeader? xGustoAPIVersion = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFourMinus04Minus01);

        /// <summary>
        /// Update State Tax Requirements
        /// 
        /// <remarks>
        /// Update State Tax Requirements<br/>
        /// <br/>
        /// scope: `company_tax_requirements:write`
        /// </remarks>
        /// </summary>
        Task<PutV1CompaniesCompanyUuidTaxRequirementsStateResponse> UpdateStateAsync(string companyUuid, string state, PutV1CompaniesCompanyUuidTaxRequirementsStateRequestBody requestBody, VersionHeader? xGustoAPIVersion = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFourMinus04Minus01);

        /// <summary>
        /// Get All Tax Requirement States
        /// 
        /// <remarks>
        /// Returns objects describing the states that have tax requirements for the company<br/>
        /// <br/>
        /// scope: `company_tax_requirements:read`
        /// </remarks>
        /// </summary>
        Task<GetV1CompaniesCompanyUuidTaxRequirementsResponse> GetAllAsync(string companyUuid, VersionHeader? xGustoAPIVersion = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFourMinus04Minus01);
    }

    public class TaxRequirements: ITaxRequirements
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

        public TaxRequirements(ISpeakeasyHttpClient client, Func<GustoEmbedded.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<GetV1CompaniesCompanyUuidTaxRequirementsStateResponse> GetAsync(string companyUuid, string state, bool? scheduling = null, VersionHeader? xGustoAPIVersion = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFourMinus04Minus01)
        {
            var request = new GetV1CompaniesCompanyUuidTaxRequirementsStateRequest()
            {
                CompanyUuid = companyUuid,
                State = state,
                Scheduling = scheduling,
                XGustoAPIVersion = xGustoAPIVersion,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/v1/companies/{company_uuid}/tax_requirements/{state}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext(baseUrl, "get-v1-companies-company_uuid-tax_requirements-state", new List<string> {  }, _securitySource);

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
                    var obj = ResponseBodyDeserializer.Deserialize<TaxRequirementsState>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new GetV1CompaniesCompanyUuidTaxRequirementsStateResponse()
                    {
                        HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        }
                    };
                    response.TaxRequirementsState = obj;
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

        public async Task<PutV1CompaniesCompanyUuidTaxRequirementsStateResponse> UpdateStateAsync(string companyUuid, string state, PutV1CompaniesCompanyUuidTaxRequirementsStateRequestBody requestBody, VersionHeader? xGustoAPIVersion = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFourMinus04Minus01)
        {
            var request = new PutV1CompaniesCompanyUuidTaxRequirementsStateRequest()
            {
                CompanyUuid = companyUuid,
                State = state,
                RequestBody = requestBody,
                XGustoAPIVersion = xGustoAPIVersion,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/v1/companies/{company_uuid}/tax_requirements/{state}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);

            var serializedBody = RequestBodySerializer.Serialize(request, "RequestBody", "json", false, false);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext(baseUrl, "put-v1-companies-company_uuid-tax_requirements-state", new List<string> {  }, _securitySource);

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
                return new PutV1CompaniesCompanyUuidTaxRequirementsStateResponse()
                {
                    HttpMeta = new Models.Components.HTTPMetadata()
                    {
                        Response = httpResponse,
                        Request = httpRequest
                    }
                };
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

        public async Task<GetV1CompaniesCompanyUuidTaxRequirementsResponse> GetAllAsync(string companyUuid, VersionHeader? xGustoAPIVersion = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFourMinus04Minus01)
        {
            var request = new GetV1CompaniesCompanyUuidTaxRequirementsRequest()
            {
                CompanyUuid = companyUuid,
                XGustoAPIVersion = xGustoAPIVersion,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/v1/companies/{company_uuid}/tax_requirements", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext(baseUrl, "get-v1-companies-company_uuid-tax_requirements", new List<string> {  }, _securitySource);

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
                    var obj = ResponseBodyDeserializer.Deserialize<List<ResponseBody>>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new GetV1CompaniesCompanyUuidTaxRequirementsResponse()
                    {
                        HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        }
                    };
                    response.ResponseBodies = obj;
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
    }
}