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
            PrintOdakyuRailwayFare();
        }

        static public void PrintOdakyuRailwayFare()
        {
            // アクセストークン取得
            var auth = new TOC.Security.Impl.Authorization();
            var accessToken = auth.GetAccessToken();

            // JSONの取得
            var client = new TOC.Client.Impl.TocDataClient();
            var json = client.GetOdakyuFare(accessToken);

            var parser = new TOC.DataSets.Parser.Odakyu.Impl.OdakyuJsonParser();
            var datas = parser.ParseRailwayFare(json);
            
            var selectDatas = from data in datas
                              //where data.FromStation.Contains("Shinjuku")
                              //where data.ToStation.Contains("Noborito")
                              select data;

            foreach (var data in selectDatas)
            {
                Console.WriteLine(String.Format("{0} -> {1} : card[{2}] ticket[{3}]", data.FromStation, data.ToStation, data.IcCardFare, data.TicketFare));
            }
        }
    }
}
