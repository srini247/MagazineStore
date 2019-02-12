using System.Collections.Generic;

namespace MagazineStore.Model
{
     class Categories 
    {   
        public List<string> Data { get; set; }
        public string Token { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
    }
}
