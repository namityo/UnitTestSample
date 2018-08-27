using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOC.DataSets.Adjuster
{
    interface IJsonAdjuster
    {
        /// <summary>
        /// JSON文字列の一部を調整します。
        /// </summary>
        /// <param name="json">JSON文字列</param>
        /// <returns>調整後のJSON文字列</returns>
        string Adjust(string json, IEnumerable<AdjustData> adjustDatas);
    }
}
