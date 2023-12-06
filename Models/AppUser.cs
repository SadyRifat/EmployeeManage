using Microsoft.AspNetCore.Identity;
using EmployeeManage.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManage.Models
{
    public class AppUser : IdentityUser
    {
        public int? Pace { get; set; }
        public int? Mileage { get; set; }
        public string? ProfileImageUrl { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        [ForeignKey("Address")]
        public int? AddressId { get; set; }
        public Address? Address { get; set; }

    }
}
