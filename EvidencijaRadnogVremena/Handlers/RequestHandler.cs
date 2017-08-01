using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleCounterNg.Handlers
{
    public class RequestHandler
    {
        public static Dictionary<string, string> get(string method, List<string> keys, HttpRequestBase request)
        {
            Dictionary<string, string> values = new Dictionary<string, string>();
            if (method == "POST")
            {
                foreach (var key in keys)
                {
                    string value = request.Form[key] != null ? request.Form[key] : "";
                    values[key] = value;
                }
            }
            else
            {
                foreach (var key in keys)
                {
                    string value = request.QueryString[key] != null ? request.QueryString[key] : "";
                    values[key] = value;
                }
            }

            return values;
        }
    }
}