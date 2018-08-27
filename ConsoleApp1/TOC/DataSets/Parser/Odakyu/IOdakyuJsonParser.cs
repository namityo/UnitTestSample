using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOC.DataSets.Odakyu.RailwayFare;

namespace TOC.DataSets.Parser.Odakyu
{
    interface IOdakyuJsonParser
    {
        IEnumerable<RailwayFare> ParseRailwayFare(string json);
    }
}
