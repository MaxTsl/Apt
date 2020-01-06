using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test3.Models
{
    public class User:IdentityUser
    {
        //[Key]
        //public IKey Id { get; set; }
        //public string UserName { get; set; }
        //public string Email { get; set; }
        //public string PhoneNumber { get; set; }

        //[Column(TypeName = ("nvarchar(150)"))]
        //public string FullName { get; set; }
        [Column(TypeName = ("int"))]
        public int OrgId { get; set; }
    }
}
