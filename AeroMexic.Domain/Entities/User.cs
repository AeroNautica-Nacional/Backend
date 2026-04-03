using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroMexic.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Rule_Id { get; set; }
        public DateTime DateCreate { get; set; }
        public string CreateFor { get; set; }
        public DateTime DateUpdate { get; set; }
        public string UpdateFor { get; set; }
        public bool Active { get; set; }
        public DateTime DateDelete { get; set; }
        public string DeleteFor { get; set; }
    }
}
