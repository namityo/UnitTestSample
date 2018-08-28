using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOC.Security.Impl
{
    public class Authorization : IAuthorization
    {
        public string GetAccessToken()
        {
            var path = Path.Combine(
                System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                "toc.accesskey");
            return GetAccessToken(path.ToString());
        }

        public string GetAccessToken(string path)
        {
            using (var reader = new StreamReader(path))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
