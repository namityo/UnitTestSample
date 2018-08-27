using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOC.DataSets.Adjuster.Impl
{
    class JsonAdjuster : IJsonAdjuster
    {
        public string Adjust(string json, IEnumerable<AdjustData> adjustDatas)
        {
            return adjustDatas.Aggregate(json, (result, data) => result.Replace(data.Before, data.After));
        }
    }
}
