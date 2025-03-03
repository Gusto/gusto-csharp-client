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

    public interface IBankAccounts
    {

        /// <summary>
        /// Create a company bank account
        /// 
        /// <remarks>
        /// This endpoint creates a new company bank account.<br/>
        /// <br/>
        /// Upon being created, two verification deposits are automatically sent to the bank account, and the bank account&apos;s verification_status is &apos;awaiting_deposits&apos;. <br/>
        /// <br/>
        /// When the deposits are successfully transferred, the verification_status changes to &apos;ready_for_verification&apos;, at which point the verify endpoint can be used to verify the bank account.<br/>
        /// After successful verification, the bank account&apos;s verification_status is &apos;verified&apos;.<br/>
        /// <br/>
        /// scope: `company_bank_accounts:write`<br/>
        /// <br/>
        /// &gt; 🚧 Warning<br/>
        /// &gt;<br/>
        /// &gt; If a default bank account exists, it will be disabled and the new bank account will replace it as the company&apos;s default funding method.
        /// </remarks>
        /// </summary>
        Task<PostV1CompaniesCompanyIdBankAccountsResponse> CreateAsync(string companyId, PostV1CompaniesCompanyIdBankAccountsRequestBody requestBody, VersionHeader? xGustoAPIVersion = null);

        /// <summary>
        /// Get all company bank accounts
        /// 
        /// <remarks>
        /// Returns company bank accounts. Currently, we only support a single default bank account per company.<br/>
        /// <br/>
        /// scope: `company_bank_accounts:read`
        /// </remarks>
        /// </summary>
        Task<GetV1CompaniesCompanyIdBankAccountsResponse> GetAsync(string companyId, VersionHeader? xGustoAPIVersion = null);

        /// <summary>
        /// Verify a company bank account
        /// 
        /// <remarks>
        /// Verify a company bank account by confirming the two micro-deposits sent to the bank account. Note that the order of the two deposits specified in request parameters does not matter. There&apos;s a maximum of 5 verification attempts, after which we will automatically initiate a new set of micro-deposits and require the bank account to be verified with the new micro-deposits.<br/>
        /// <br/>
        /// ### Bank account verification in demo<br/>
        /// <br/>
        /// We provide the endpoint `POST &apos;/v1/companies/{company_id}/bank_accounts/{bank_account_uuid}/send_test_deposits&apos;` to facilitate bank account verification in the demo environment. This endpoint simulates the micro-deposits transfer and returns them in the response. You can call this endpoint as many times as you wish to retrieve the values of the two micro deposits.<br/>
        /// <br/>
        /// ```<br/>
        ///   POST &apos;/v1/companies/89771af8-b964-472e-8064-554dfbcb56d9/bank_accounts/ade55e57-4800-4059-9ecd-fa29cfeb6dd2/send_test_deposits&apos;<br/>
        /// <br/>
        ///   {<br/>
        ///     &quot;deposit_1&quot;: 0.02,<br/>
        ///     &quot;deposit_2&quot;: 0.42<br/>
        ///   }<br/>
        /// ```<br/>
        /// <br/>
        /// scope: `company_bank_accounts:write`
        /// </remarks>
        /// </summary>
        Task<PutV1CompaniesCompanyIdBankAccountsVerifyResponse> VerifyAsync(string bankAccountUuid, string companyId, PutV1CompaniesCompanyIdBankAccountsVerifyRequestBody requestBody, VersionHeader? xGustoAPIVersion = null);

        /// <summary>
        /// Create a bank account from a plaid processor token
        /// 
        /// <remarks>
        /// This endpoint creates a new **verified** bank account by using a plaid processor token to retrieve its information.<br/>
        /// <br/>
        /// scope: `plaid_processor:write`<br/>
        /// <br/>
        /// &gt; 📘<br/>
        /// &gt; To create a token please use the <a href="https://plaid.com/docs/api/processors/#processortokencreate">plaid api</a> and select &quot;gusto&quot; as processor.<br/>
        /// <br/>
        /// &gt; 🚧 Warning - Company Bank Accounts<br/>
        /// &gt;<br/>
        /// &gt; If a default company bank account exists, it will be disabled and the new bank account will replace it as the company&apos;s default funding method.
        /// </remarks>
        /// </summary>
        Task<PostV1PlaidProcessorTokenResponse> CreateFromPlaidTokenAsync(PostV1PlaidProcessorTokenRequestBody requestBody, VersionHeader? xGustoAPIVersion = null);
    }

    public class BankAccounts: IBankAccounts
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.0.10";
        private const string _sdkGenVersion = "2.536.0";
        private const string _openapiDocVersion = "2024-04-01";
        private const string _userAgent = "speakeasy-sdk/csharp 0.0.10 2.536.0 2024-04-01 GustoEmbedded";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<GustoEmbedded.Models.Components.Security>? _securitySource;

        public BankAccounts(ISpeakeasyHttpClient client, Func<GustoEmbedded.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<PostV1CompaniesCompanyIdBankAccountsResponse> CreateAsync(string companyId, PostV1CompaniesCompanyIdBankAccountsRequestBody requestBody, VersionHeader? xGustoAPIVersion = null)
        {
            var request = new PostV1CompaniesCompanyIdBankAccountsRequest()
            {
                CompanyId = companyId,
                RequestBody = requestBody,
                XGustoAPIVersion = xGustoAPIVersion,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/v1/companies/{company_id}/bank_accounts", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
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

            var hookCtx = new HookContext("post-v1-companies-company_id-bank-accounts", null, _securitySource);

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
                    var obj = ResponseBodyDeserializer.Deserialize<CompanyBankAccount>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new PostV1CompaniesCompanyIdBankAccountsResponse()
                    {
                        HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        }
                    };
                    response.CompanyBankAccount = obj;
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

        public async Task<GetV1CompaniesCompanyIdBankAccountsResponse> GetAsync(string companyId, VersionHeader? xGustoAPIVersion = null)
        {
            var request = new GetV1CompaniesCompanyIdBankAccountsRequest()
            {
                CompanyId = companyId,
                XGustoAPIVersion = xGustoAPIVersion,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/v1/companies/{company_id}/bank_accounts", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("get-v1-companies-company_id-bank-accounts", null, _securitySource);

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
                    var obj = ResponseBodyDeserializer.Deserialize<List<CompanyBankAccount>>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new GetV1CompaniesCompanyIdBankAccountsResponse()
                    {
                        HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        }
                    };
                    response.CompanyBankAccountList = obj;
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

        public async Task<PutV1CompaniesCompanyIdBankAccountsVerifyResponse> VerifyAsync(string bankAccountUuid, string companyId, PutV1CompaniesCompanyIdBankAccountsVerifyRequestBody requestBody, VersionHeader? xGustoAPIVersion = null)
        {
            var request = new PutV1CompaniesCompanyIdBankAccountsVerifyRequest()
            {
                BankAccountUuid = bankAccountUuid,
                CompanyId = companyId,
                RequestBody = requestBody,
                XGustoAPIVersion = xGustoAPIVersion,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/v1/companies/{company_id}/bank_accounts/{bank_account_uuid}/verify", request);

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

            var hookCtx = new HookContext("put-v1-companies-company_id-bank-accounts-verify", null, _securitySource);

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
                    var obj = ResponseBodyDeserializer.Deserialize<CompanyBankAccount>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new PutV1CompaniesCompanyIdBankAccountsVerifyResponse()
                    {
                        HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        }
                    };
                    response.CompanyBankAccount = obj;
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

        public async Task<PostV1PlaidProcessorTokenResponse> CreateFromPlaidTokenAsync(PostV1PlaidProcessorTokenRequestBody requestBody, VersionHeader? xGustoAPIVersion = null)
        {
            var request = new PostV1PlaidProcessorTokenRequest()
            {
                RequestBody = requestBody,
                XGustoAPIVersion = xGustoAPIVersion,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();

            var urlString = baseUrl + "/v1/plaid/processor_token";

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
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

            var hookCtx = new HookContext("post-v1-plaid-processor_token", null, _securitySource);

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
                    var obj = ResponseBodyDeserializer.Deserialize<PostV1PlaidProcessorTokenResponseBody>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new PostV1PlaidProcessorTokenResponse()
                    {
                        HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        }
                    };
                    response.OneOf = obj;
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