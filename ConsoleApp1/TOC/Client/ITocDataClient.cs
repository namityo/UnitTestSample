using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOC.Client
{
    interface ITocDataClient
    {
        /// <summary>
        /// 小田急線の運賃を取得します
        /// </summary>
        /// <param name="accessToken">アクセストークン</param>
        /// <returns>JSON文字列</returns>
        string GetOdakyuFare(string accessToken);
    }
}
