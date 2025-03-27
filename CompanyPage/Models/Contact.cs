using MongoDB.Bson;

namespace CompanyPage.Models
{
    public class Contact
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
