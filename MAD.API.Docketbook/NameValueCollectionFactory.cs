using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Web;

namespace MAD.API.Docketbook
{
    public class NameValueCollectionFactory
    {
        public NameValueCollection CreateFromAnonymousObject(object obj)
        {
            var nvc = HttpUtility.ParseQueryString(string.Empty);

            Array.ForEach(
                array: obj.GetType().GetProperties(),
                action: pi =>
                {
                    var key = pi.Name;
                    var val = pi.GetValue(obj, null);

                    if (val is null)
                        return;

                    if (val is DateTime dte)
                    {
                        nvc.Add(key, dte.ToString("yyyy-MM-dd"));
                    }
                    else
                    {
                        nvc.Add(key, val.ToString());
                    }
                });

            return nvc;
        }

    }
}
