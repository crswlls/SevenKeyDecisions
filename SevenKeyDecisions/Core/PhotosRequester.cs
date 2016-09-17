using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SevenKeyDecisions.Core
{
    public class PhotosRequester
    {
        public async Task<string> GetPhotoInfos()
        {
            return await new HttpClient().GetStringAsync("http://jsonplaceholder.typicode.com/photos");
        }
    }
}