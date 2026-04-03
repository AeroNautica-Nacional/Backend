using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroMexic.Application.DTOs
{
    public partial class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string EmailConfirmed { get; set; } = string.Empty;
        public string PasswordConfirmed { get; set; } = string.Empty;
        public int Role_Id { get; set; }
        public DateTime DateCreate { get; set; }
        public string CreateBy { get; set; }
        public DateTime DateUpdate { get; set; }
        public string UpdateBy { get; set; }
        public bool Active { get; set; }
        public DateTime DateDelete { get; set; }
        public string DeleteBy { get; set; }
    }
}
