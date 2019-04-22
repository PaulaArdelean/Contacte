using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Contacte.Models.Entities
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string CNP { get; set; }
        public string PhoneNumber { get; set; }
        public string UserId { get; set; }
        public string Address { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
