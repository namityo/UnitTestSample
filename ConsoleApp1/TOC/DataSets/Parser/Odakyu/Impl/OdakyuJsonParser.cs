using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOC.DataSets.Adjuster;
using TOC.DataSets.Adjuster.Impl;
using TOC.DataSets.Adjuster.Odakyu;
using TOC.DataSets.Odakyu.RailwayFare;
using TOC.DataSets.Parser.Impl;

namespace TOC.DataSets.Parser.Odakyu.Impl
{
    class OdakyuJsonParser : IOdakyuJsonParser
    {
        protected IJsonParser parser = new JsonParser();

        protected IJsonAdjuster adjuster = new JsonAdjuster();

        protected AdjustDataBuilder adjustDataBuilder = new AdjustDataBuilder();

        public IEnumerable<RailwayFare> ParseRailwayFare(string json)
        {
            // JSONを解析しやすいように調整
            var adjustedJson = adjuster.Adjust(json, adjustDataBuilder.BuildRailwayFare());
            // JSONを解析
            var jsonObject = parser.Parse(adjustedJson);
            // 必要情報をオブジェクトに格納して返却
            return from dynamic o in (object[])jsonObject
                   select new RailwayFare()
                   {
                       ToStation = o.toStation,
                       FromStation = o.fromStation,
                       IcCardFare = o.icCardFare,
                       TicketFare = o.ticketFare,
                       ChildIcCardFare = o.childIcCardFare,
                       ChildTicketFare = o.childTicketFare,
                   };
        }
    }
}
