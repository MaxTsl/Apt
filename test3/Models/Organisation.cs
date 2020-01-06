using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace test3.Models
{
    public class Organisation
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrgId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string OrgName { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string OrgINN { get; set; }

        [Column(TypeName = "varchar(300)")]
        public string OrgAddress { get; set; }
    }
}
