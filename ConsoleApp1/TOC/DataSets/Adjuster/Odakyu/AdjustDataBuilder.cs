using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOC.DataSets.Adjuster.Odakyu
{
    class AdjustDataBuilder
    {
        /// <summary>
        /// RailwayFareの調整データを構築します
        /// </summary>
        /// <returns>調整データのIEnumerable</returns>
        public IEnumerable<AdjustData> BuildRailwayFare() => new AdjustData[]
            {
                new AdjustData() { Before ="odpt:toStation", After ="toStation" },
                new AdjustData() { Before ="odpt:fromStation", After ="fromStation" },
                new AdjustData() { Before ="odpt:icCardFare", After ="icCardFare" },
                new AdjustData() { Before ="odpt:ticketFare", After ="ticketFare" },
                new AdjustData() { Before ="odpt:childIcCardFare", After ="childIcCardFare" },
                new AdjustData() { Before ="odpt:childTicketFare", After ="childTicketFare" },
            };
    }
}
