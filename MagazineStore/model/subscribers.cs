using System.Collections.Generic;
namespace MagazineStore.Model
{
    class Subscribers
    {
        public List<subscriber> Data { get; set; }
        public string Token { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }

    class subscriber
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<int> MagazineIds { get; set; }
    }
}
