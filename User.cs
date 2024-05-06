using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ums_proj
{
    public class User
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Salary { get; set; }

        public User(string userId, string username, string email, string salary)
        {
            UserId = userId;
            Username = username;
            Email = email;
            Salary = salary;
        }
    }
}
