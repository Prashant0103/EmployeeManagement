using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using RestSharp;
using Newtonsoft.Json;
public class RequestResponse
{
    public static string GetBaseURL()
    {
        return ConfigurationManager.AppSettings["baseURL"];
    }

    public static IRestResponse Post(string url, object model)
    {

        var baseURL = GetBaseURL();
        RestClient restClient = new RestClient(baseURL);
        var request = new RestRequest(url, Method.POST)
        {
            RequestFormat = DataFormat.Json
        };
        var jsonObject = JsonConvert.SerializeObject(model);
        request.AddParameter("application/json", jsonObject, ParameterType.RequestBody);
        var response = restClient.Execute(request);
        return response;
    }

    public static IRestResponse GetById(string url, int id)
    {

        var baseURL = GetBaseURL();
        RestClient restClient = new RestClient(baseURL);
        var request = new RestRequest(url, Method.GET);
        request.AddUrlSegment("id", id);

        var response = restClient.Execute(request);
        return response;
    }

    public static IRestResponse GetAll(string url)
    {

        var baseURL = GetBaseURL();
        RestClient restClient = new RestClient(baseURL);
        var request = new RestRequest(url, Method.GET);
        var response = restClient.Execute(request);
        return response;
    }

    public static IRestResponse GetEmployeePageData(string url, int pageNumber, int pageSize)
    {

        var baseURL = GetBaseURL();
        RestClient restClient = new RestClient(baseURL);
        var request = new RestRequest(url, Method.GET);
        request.AddUrlSegment("pageNumber", pageNumber);
        request.AddUrlSegment("pageSize", pageSize);

        var response = restClient.Execute(request);
        return response;
    }

    public static IRestResponse GetEmployeePageData1(string url, int id, int pageNumber, int pageSize, string sortColumn, string sortDirection)
    {

        var baseURL = GetBaseURL();
        RestClient restClient = new RestClient(baseURL);
        var request = new RestRequest(url, Method.GET);
        request.AddUrlSegment("id", id);
        request.AddUrlSegment("pageNumber", pageNumber);
        request.AddUrlSegment("pageSize", pageSize);
        request.AddQueryParameter("sortColumn", sortColumn);
        request.AddQueryParameter("sortDirection", sortDirection);
        var response = restClient.Execute(request);
        return response;
    }

    public static IRestResponse Put(string url, int id, object model)
    {

        var baseURL = GetBaseURL();
        RestClient restClient = new RestClient(baseURL);
        var request = new RestRequest(url, Method.PUT)
        {
            RequestFormat = DataFormat.Json
        };
        request.AddUrlSegment("id", id);
        var jsonObject = JsonConvert.SerializeObject(model);
        request.AddParameter("application/json", jsonObject, ParameterType.RequestBody);
        var response = restClient.Execute(request);
        return response;
    }

    public static IRestResponse Search(string url, string search)
    {
        var baseURL = GetBaseURL();
        RestClient restClient = new RestClient(baseURL);
        var request = new RestRequest(url, Method.GET);
        request.AddQueryParameter("Search", search);
        var response = restClient.Execute(request);
        return response;
    }

    public static IRestResponse Delete(string url, int id)
    {
        var baseURL = GetBaseURL();
        RestClient restClient = new RestClient(baseURL);
        var request = new RestRequest(url, Method.DELETE);
        request.AddUrlSegment("id", id);
        var response = restClient.Execute(request);
        return response;
    }
}