using System;
using System.Net;
using System.Threading.Tasks;

namespace AppXamarin
{
    public class DataService
    {
        public async Task<string> LoadData()
        {
            var client = new WebClient();
            return await client.DownloadStringTaskAsync("https://mobiletests.getsandbox.com/ping");
        }
    }
}
