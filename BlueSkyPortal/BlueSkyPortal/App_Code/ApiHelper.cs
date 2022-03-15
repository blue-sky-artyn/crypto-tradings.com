using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

/// <summary>
/// Summary description for ApiHelper
/// </summary>
public class ApiHelper
{
    public ApiHelper()
    {
        //
        // TODO: Add constructor logic here
        //
    }


    public static string ExecuteWebApiRequest(WebApiRequestModel requestModel)
    {
        List<ParameterModel> responseHeaders = new List<ParameterModel>();
        return ExecuteWebApiRequest(requestModel, out responseHeaders);
    }

    public static string ExecuteWebApiRequest(WebApiRequestModel requestModel, out List<ParameterModel> responseHeaders)
    {
        string result = "";
        responseHeaders = new List<ParameterModel>();

        if (requestModel.RequestTimeOut == 0)
        {
            requestModel.RequestTimeOut = 600000;
        }
        var request = HttpWebRequest.Create(requestModel.RequestUri) as HttpWebRequest;
        request.Timeout = requestModel.RequestTimeOut;
        request.Method = requestModel.RequestMethod;
        //request.ContentType = "application/json; charset=utf-8";
        request.ContentType = requestModel.RequestContentType;
        //GlobalProxySelection.Select = proxyObject;
        //WebRequest.DefaultWebProxy = proxyObject;
        //request.Proxy = proxyObject;
        // this part of code dont need for some requestMethods and therefore won't work for them

        if (!string.IsNullOrEmpty(requestModel.Accept))
        {
            request.Accept = requestModel.Accept;
        }

        if (requestModel.RequestHeaders != null && requestModel.RequestHeaders.Count > 0)
        {
            foreach (var headerItem in requestModel.RequestHeaders)
            {
                request.Headers.Add(headerItem.Name, headerItem.Value.ToString());
            }
        }

        if (requestModel.RequestMethod.ToLower() == "post" || requestModel.RequestMethod.ToLower() == "put")
        {
            try
            {
                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    string data = "";
                    if (requestModel.RequestContentType.ToLower().StartsWith("application/json"))
                    {
                        data = DataTypeStringifier.JsonStringifier(requestModel.DataToSend);
                    }
                    else if (requestModel.RequestContentType.ToLower().StartsWith("application/x-www-form-urlencoded"))
                    {
                        data = DataTypeStringifier.FormDataStringifier(requestModel.DataToSend);
                    }

                    streamWriter.Write(data);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }
            catch (Exception ex) { }
        }


        var response = request.GetResponse();
        using (var streamReader = new StreamReader(response.GetResponseStream()))
        {
            result = streamReader.ReadToEnd();
        }

        if (response.Headers != null && response.Headers.Count > 0)
        {
            foreach (var headerItemName in response.Headers.AllKeys)
            {
                responseHeaders.Add(new ParameterModel
                {
                    Name = headerItemName,
                    Value = response.Headers[headerItemName]
                });
            }
        }

        return result;
    }
}