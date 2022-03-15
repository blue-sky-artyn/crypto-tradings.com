using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for WebApiRequestModel
/// </summary>
public class WebApiRequestModel
{
    public WebApiRequestModel()
    {
        RequestTimeOut = 0;
        DataToSend = new List<ParameterModel>();
        RequestHeaders = new List<ParameterModel>();
    }
    public string RequestUri { get; set; }
    public string RequestMethod { get; set; }
    public string RequestContentType { get; set; }
    public List<ParameterModel> DataToSend { get; set; }
    public List<ParameterModel> RequestHeaders { get; set; }

    /// <summary>
    /// value is like 'application/json' OR 'application/xml' OR other acceptable results MIME types
    /// </summary>
    public string Accept { get; set; }
    public int RequestTimeOut { get; set; }
}