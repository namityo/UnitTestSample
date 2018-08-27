using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOC.DataSets.Parser
{
    interface IJsonParser
    {
        /// <summary>
        /// JSON文字列をパースします
        /// </summary>
        /// <param name="json">JSON文字列</param>
        /// <returns>JSONにアクセスするインスタンス</returns>
        dynamic Parse(string json);
    }
}
