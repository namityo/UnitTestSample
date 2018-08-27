using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TOC.Client.Impl
{
    class TocDataClient : ITocDataClient
    {
        public string GetOdakyuFare(string accessToken)
        {
            using (var client = new WebClient())
            {
                var url = $"https://api-tokyochallenge.odpt.org/api/v4/odpt:RailwayFare?odpt:operator=odpt.Operator:Odakyu&acl:consumerKey={accessToken}";
                return client.DownloadString(url);
            }
        }
    }
}
