using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Employee
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public byte[] ImageData { get; set; }
        public string Details { get; set; }
    }
}
