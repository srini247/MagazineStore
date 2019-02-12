using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazineStore.Model
{
    class Magazines
    {
        public List<catergory> Data { get; set; }
        public string Token { get; set; }
        public bool success { get; set; }
        public string Message { get; set; }
    }

    class catergory
    {
        public int id { get; set; }
        public string name { get; set; }
        public string category { get; set; }

    }
}
