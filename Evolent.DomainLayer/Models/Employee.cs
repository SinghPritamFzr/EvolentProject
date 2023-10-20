using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
 
namespace Evolent.DomainLayer.Models
{
    [Index("firstname", "lastname", "emailaddress", IsUnique =   true, Name  = "IX_FLE_Constraint")]
    public class Employee : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string emailaddress { get; set; }
        public int? Age { get; set; } 

    }
}
