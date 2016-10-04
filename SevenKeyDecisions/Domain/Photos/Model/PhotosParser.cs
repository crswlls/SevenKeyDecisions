using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SevenKeyDecisions.Core
{
    public class PhotosParser
    {
        public List<PhotoInfo> ParsePhotos(string json)
        {
            var photoInfos = new List<PhotoInfo>();
            var jtoken = JToken.Parse(json);
            
            foreach (var photoInfo in jtoken.Take(20))
            {
                var pinfo = JsonConvert.DeserializeObject<PhotoInfo>(photoInfo.ToString());
                photoInfos.Add(pinfo);
            }
            
            return photoInfos;
        }
    }
}