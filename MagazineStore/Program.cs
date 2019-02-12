using System;
using System.Collections.Generic;
using System.Linq;
using MagazineStore.webapi;
using MagazineStore.Model;
using System.Threading.Tasks;

namespace magazinestore
{
    class Program
    {

        private static void Main()
        {
            RunAsync().GetAwaiter().GetResult();
        }

        private static async Task RunAsync()
        {
            try
            {
                //get authentication token
                var token = await WebApi.GetTokenAsync();

                //handle webapi failure
                if (token == null)
                {
                    Handleerror("Token");
                    return;
                }
                //get catergories
                var categories = await WebApi.GetCategoriesAsync(token?.Token);

                //handle webapi failure
                if (categories == null)
                {
                    Handleerror("categories");
                    return;
                }

                //get Magazines for all categories and add to list.
                var tasks = categories.Data.Select(async category => await WebApi.GetMagazineAsync(token?.Token, category)).ToList();
                var magazines = new List<Magazines>();

                foreach (var t in tasks)
                {

                    //handle webapi failure
                    if (t.Result == null)
                    {
                        Handleerror("magazines");
                        return;
                    }
                    magazines.Add(t.Result);

                }

                // get Subscribers
                var subscribers = await WebApi.GetSubscribersAsync(token?.Token);

                //handle webapi failure
                if (subscribers == null)
                {
                    Handleerror("subscribers");
                    return;
                }

                var users = new PostData { Subscribers = new List<string>() };

                //iterate through all subscribers
                foreach (var t in subscribers?.Data)
                {
                    var exists = true;
                    //iterate through all subscribers
                    foreach (var t1 in magazines)
                    {
                        // set exists to false if MagazineIds doesnot exist in current category
                        if (!t1.Data.Any(p => t.MagazineIds.Contains(p.id)))
                        {
                            exists = false;
                        }
                    }
                    if (exists)
                    {
                        users.Subscribers.Add(t.Id);
                    }
                }

                var result = await WebApi.GetresultAsync(token.Token, users);

                //handle webapi failure
                if (result == null)
                {
                    Handleerror("Answer");
                    return;
                }

                Console.Write(Newtonsoft.Json.JsonConvert.SerializeObject(result));
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        static void Handleerror(string calltype)
        {
            Console.WriteLine(calltype + " webapi call failed.");
            Console.ReadLine();
        }
    }
}
