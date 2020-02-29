using ICAP_API.Models;
using Innova_ICAP_V2.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Innova_ICAP_V2.Controller
{
    class GalleryController
    {
        public async Task<List<GalleryModel>> GetImagesList()
        {
            var list = new List<GalleryModel>();

            var restapi = new Rest();

            try
            {
                var json = await restapi.Get(restapi.events, "");
                if (string.IsNullOrEmpty(json))
                {
                    return null;
                }
                else
                {
                    var result = JsonConvert.DeserializeObject<List<GalleryModel>>(json);

                    list = result;
                }
            }
            catch (Exception)
            {
                throw new Exception("Service Failed, try again later");
            }

            return list;
        }
    }
}
