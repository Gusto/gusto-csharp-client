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

    public interface IDepartments
    {

        /// <summary>
        /// Create a department
        /// 
        /// <remarks>
        /// Create a department<br/>
        /// <br/>
        /// scope: `departments:write`
        /// </remarks>
        /// </summary>
        Task<PostDepartmentsResponse> CreateAsync(string companyUuid, PostDepartmentsRequestBody requestBody, VersionHeader? xGustoAPIVersion = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFourMinus04Minus01);

        /// <summary>
        /// Get all departments of a company
        /// 
        /// <remarks>
        /// Get all of the departments for a given company with the employees and contractors assigned to that department.<br/>
        /// <br/>
        /// scope: `departments:read`
        /// </remarks>
        /// </summary>
        Task<GetCompaniesDepartmentsResponse> GetAllAsync(string companyUuid, VersionHeader? xGustoAPIVersion = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFourMinus04Minus01);

        /// <summary>
        /// Get a department
        /// 
        /// <remarks>
        /// Get a department given the UUID<br/>
        /// <br/>
        /// scope: `departments:read`<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<GetDepartmentResponse> GetAsync(string departmentUuid, VersionHeader? xGustoAPIVersion = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFourMinus04Minus01);

        /// <summary>
        /// Update a department
        /// 
        /// <remarks>
        /// Update a department<br/>
        /// <br/>
        /// scope: `departments:write`
        /// </remarks>
        /// </summary>
        Task<PutDepartmentsResponse> UpdateAsync(string departmentUuid, PutDepartmentsRequestBody requestBody, VersionHeader? xGustoAPIVersion = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFourMinus04Minus01);

        /// <summary>
        /// Delete a department
        /// 
        /// <remarks>
        /// Delete a department. You cannot delete a department until all employees and contractors have been removed.<br/>
        /// <br/>
        /// scope: `departments:write`<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<DeleteDepartmentResponse> DeleteAsync(string departmentUuid, VersionHeader? xGustoAPIVersion = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFourMinus04Minus01);

        /// <summary>
        /// Add people to a department
        /// 
        /// <remarks>
        /// Add employees and contractors to a department<br/>
        /// <br/>
        /// scope: `departments:write`<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<PutAddPeopleToDepartmentResponse> AddPeopleAsync(string departmentUuid, PutAddPeopleToDepartmentRequestBody requestBody, VersionHeader? xGustoAPIVersion = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFourMinus04Minus01);

        /// <summary>
        /// Remove people from a department
        /// 
        /// <remarks>
        /// Remove employees and contractors from a department<br/>
        /// <br/>
        /// scope: `departments:write`<br/>
        /// 
        /// </remarks>
        /// </summary>
        Task<PutRemovePeopleFromDepartmentResponse> RemovePeopleAsync(string departmentUuid, PutRemovePeopleFromDepartmentRequestBody requestBody, VersionHeader? xGustoAPIVersion = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFourMinus04Minus01);
    }

    public class Departments: IDepartments
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.1.2";
        private const string _sdkGenVersion = "2.562.3";
        private const string _openapiDocVersion = "2024-04-01";
        private const string _userAgent = "speakeasy-sdk/csharp 0.1.2 2.562.3 2024-04-01 GustoEmbedded";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<GustoEmbedded.Models.Components.Security>? _securitySource;

        public Departments(ISpeakeasyHttpClient client, Func<GustoEmbedded.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<PostDepartmentsResponse> CreateAsync(string companyUuid, PostDepartmentsRequestBody requestBody, VersionHeader? xGustoAPIVersion = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFourMinus04Minus01)
        {
            var request = new PostDepartmentsRequest()
            {
                CompanyUuid = companyUuid,
                RequestBody = requestBody,
                XGustoAPIVersion = xGustoAPIVersion,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/v1/companies/{company_uuid}/departments", request);

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

            var hookCtx = new HookContext(baseUrl, "post-departments", new List<string> {  }, _securitySource);

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
                    var obj = ResponseBodyDeserializer.Deserialize<Department>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new PostDepartmentsResponse()
                    {
                        HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        }
                    };
                    response.Department = obj;
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

        public async Task<GetCompaniesDepartmentsResponse> GetAllAsync(string companyUuid, VersionHeader? xGustoAPIVersion = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFourMinus04Minus01)
        {
            var request = new GetCompaniesDepartmentsRequest()
            {
                CompanyUuid = companyUuid,
                XGustoAPIVersion = xGustoAPIVersion,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/v1/companies/{company_uuid}/departments", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext(baseUrl, "get-companies-departments", new List<string> {  }, _securitySource);

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
                    var obj = ResponseBodyDeserializer.Deserialize<List<Department>>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new GetCompaniesDepartmentsResponse()
                    {
                        HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        }
                    };
                    response.DepartmentList = obj;
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

        public async Task<GetDepartmentResponse> GetAsync(string departmentUuid, VersionHeader? xGustoAPIVersion = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFourMinus04Minus01)
        {
            var request = new GetDepartmentRequest()
            {
                DepartmentUuid = departmentUuid,
                XGustoAPIVersion = xGustoAPIVersion,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/v1/departments/{department_uuid}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext(baseUrl, "get-department", new List<string> {  }, _securitySource);

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
                    var obj = ResponseBodyDeserializer.Deserialize<Department>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new GetDepartmentResponse()
                    {
                        HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        }
                    };
                    response.Department = obj;
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

        public async Task<PutDepartmentsResponse> UpdateAsync(string departmentUuid, PutDepartmentsRequestBody requestBody, VersionHeader? xGustoAPIVersion = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFourMinus04Minus01)
        {
            var request = new PutDepartmentsRequest()
            {
                DepartmentUuid = departmentUuid,
                RequestBody = requestBody,
                XGustoAPIVersion = xGustoAPIVersion,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/v1/departments/{department_uuid}", request);

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

            var hookCtx = new HookContext(baseUrl, "put-departments", new List<string> {  }, _securitySource);

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
                    var obj = ResponseBodyDeserializer.Deserialize<Department>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new PutDepartmentsResponse()
                    {
                        HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        }
                    };
                    response.Department = obj;
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

        public async Task<DeleteDepartmentResponse> DeleteAsync(string departmentUuid, VersionHeader? xGustoAPIVersion = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFourMinus04Minus01)
        {
            var request = new DeleteDepartmentRequest()
            {
                DepartmentUuid = departmentUuid,
                XGustoAPIVersion = xGustoAPIVersion,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/v1/departments/{department_uuid}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext(baseUrl, "delete-department", new List<string> {  }, _securitySource);

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
            if(responseStatusCode == 204)
            {                
                return new DeleteDepartmentResponse()
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

        public async Task<PutAddPeopleToDepartmentResponse> AddPeopleAsync(string departmentUuid, PutAddPeopleToDepartmentRequestBody requestBody, VersionHeader? xGustoAPIVersion = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFourMinus04Minus01)
        {
            var request = new PutAddPeopleToDepartmentRequest()
            {
                DepartmentUuid = departmentUuid,
                RequestBody = requestBody,
                XGustoAPIVersion = xGustoAPIVersion,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/v1/departments/{department_uuid}/add", request);

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

            var hookCtx = new HookContext(baseUrl, "put-add-people-to-department", new List<string> {  }, _securitySource);

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
                    var obj = ResponseBodyDeserializer.Deserialize<Department>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new PutAddPeopleToDepartmentResponse()
                    {
                        HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        }
                    };
                    response.Department = obj;
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

        public async Task<PutRemovePeopleFromDepartmentResponse> RemovePeopleAsync(string departmentUuid, PutRemovePeopleFromDepartmentRequestBody requestBody, VersionHeader? xGustoAPIVersion = GustoEmbedded.Models.Components.VersionHeader.TwoThousandAndTwentyFourMinus04Minus01)
        {
            var request = new PutRemovePeopleFromDepartmentRequest()
            {
                DepartmentUuid = departmentUuid,
                RequestBody = requestBody,
                XGustoAPIVersion = xGustoAPIVersion,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/v1/departments/{department_uuid}/remove", request);

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

            var hookCtx = new HookContext(baseUrl, "put-remove-people-from-department", new List<string> {  }, _securitySource);

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
                    var obj = ResponseBodyDeserializer.Deserialize<Department>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    var response = new PutRemovePeopleFromDepartmentResponse()
                    {
                        HttpMeta = new Models.Components.HTTPMetadata()
                        {
                            Response = httpResponse,
                            Request = httpRequest
                        }
                    };
                    response.Department = obj;
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