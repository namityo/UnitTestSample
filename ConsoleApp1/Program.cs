using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using Codeplex.Data;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            printOdakyuRailwayFare2();
        }

        static public void printOdakyuRailwayFare1()
        {
            using (var client = new WebClient())
            {
                var accessToken = "hogehoge";
                var str = client.DownloadString("https://api-tokyochallenge.odpt.org/api/v4/odpt:RailwayFare?odpt:operator=odpt.Operator:Odakyu&acl:consumerKey=" + accessToken);

                // JSONのKey名を使いやすいように置換する
                str = str
                    .Replace("@id", "id")
                    .Replace("@type", "type")
                    .Replace("odpt:toStation", "toStation")
                    .Replace("odpt:fromStation", "fromStation")
                    .Replace("odpt:icCardFare", "icCardFare")
                    .Replace("odpt:ticketFare", "ticketFare")
                    .Replace("odpt:childIcCardFare", "childIcCardFare")
                    .Replace("odpt:childTicketFare", "childTicketFare");

                // パース
                var json = DynamicJson.Parse(str);
                foreach (dynamic data in (object[])json)
                {
                    Console.WriteLine($"{data.toStation} -> {data.fromStation} : card[{data.icCardFare}] ticket[{data.ticketFare}]");
                }
            }
        }

        static public void printOdakyuRailwayFare2()
        {
            // アクセストークン取得
            var auth = new TOC.Security.Impl.Authorization();
            var accessToken = auth.GetAccessToken();

            // JSONの取得
            var client = new TOC.Client.Impl.TocDataClient();
            var json = client.GetOdakyuFare(accessToken);

            var parser = new TOC.DataSets.Parser.Odakyu.Impl.OdakyuJsonParser();
            var datas = parser.ParseRailwayFare(json);

            foreach (var data in datas)
            {
                Console.WriteLine($"{data.ToStation} -> {data.FromStation} : card[{data.IcCardFare}] ticket[{data.TicketFare}]");
            }
        }
    }
}
