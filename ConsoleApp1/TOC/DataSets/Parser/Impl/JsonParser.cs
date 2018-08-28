using Codeplex.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOC.DataSets.Parser.Impl
{
    public class JsonParser : IJsonParser
    {
        public dynamic Parse(string json)
        {
            return DynamicJson.Parse(json);
        }
    }
}
