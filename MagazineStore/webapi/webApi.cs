using System.Net.Http;
using System.Threading.Tasks;
using MagazineStore.Model;

namespace MagazineStore.webapi
{
    public static class WebApi
    {
        private static readonly string baseURi = "http://magazinestore.azurewebsites.net/"; 
       

        internal static async Task<AuthToken> GetTokenAsync()
        {
            AuthToken token = null;
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(baseURi + "api/token");
                if (response.IsSuccessStatusCode)
                {
                    token = await response.Content.ReadAsAsync<AuthToken>();
                }
            }           
            return token;
        }
        internal static async Task<Categories> GetCategoriesAsync(string token)
        {
            Categories catergories = null;
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(string.Format(baseURi + "api/categories/{0}", token));
                if (response.IsSuccessStatusCode)
                {
                    catergories = await response.Content.ReadAsAsync<Categories>();
                }
            }

            return catergories;
        }
        internal static async Task<Magazines> GetMagazineAsync(string token, string category)
        {
            Magazines magazines = null;
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(string.Format(baseURi + "api/magazines/{0}/{1}" +
                    "", token, category));
                if (response.IsSuccessStatusCode)
                {
                    magazines = await response.Content.ReadAsAsync<Magazines>();
                }
            }

            return magazines;
        }
        internal static async Task<Subscribers> GetSubscribersAsync(string token)
        {
            Subscribers subscribers = null;
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(string.Format(baseURi + "api/subscribers/{0}", token));
                if (response.IsSuccessStatusCode)
                {
                    subscribers = await response.Content.ReadAsAsync<Subscribers>();
                }
            }

            return subscribers;
        }

        internal static async Task<Output> GetresultAsync(string token, PostData subscribers)
        {
            Output result = null;
            using (var client = new HttpClient())
            {
                var response = await client.PostAsJsonAsync(string.Format(baseURi + "api/answer/{0}", token), subscribers);
                if (response.IsSuccessStatusCode)
                {
                    result = await response.Content.ReadAsAsync<Output>();
                }
            }

            return result;
        }
    }
}
