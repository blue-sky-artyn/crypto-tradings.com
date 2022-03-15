using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;

/// <summary>
/// Summary description for DataTypeStringifier
/// </summary>
public static class DataTypeStringifier
{
    public static string JsonStringifier(List<ParameterModel> dataToSend)
    {
        JObject jObject = new JObject(from c in dataToSend
                                      select new JProperty(c.Name, c.Value));
        return jObject.ToString();
    }

    public static string FormDataStringifier(List<ParameterModel> dataToSend)
    {
        var keyValueParts = dataToSend.Select(s => s.Name + "=" + s.Value.ToString()).ToList();
        var result = String.Join("&", keyValueParts);
        return result;
    }

}