using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Author
    {
        public Author(int iD ,string firstName, string lastName)
        {
            Id = iD;
            FirstName = firstName;
            LastName = lastName;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
