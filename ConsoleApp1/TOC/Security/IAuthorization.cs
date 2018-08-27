using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOC.Security
{
    interface IAuthorization
    {
        /// <summary>
        /// デフォルトパスからアクセストークンを取得します
        /// </summary>
        /// <returns>アクセストークン</returns>
        string GetAccessToken();

        /// <summary>
        /// アクセストークンを取得します
        /// </summary>
        /// <param name="path">パス名</param>
        /// <returns>アクセストークン</returns>
        string GetAccessToken(string path);
    }
}
