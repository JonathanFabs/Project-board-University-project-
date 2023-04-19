using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonathanCw2.Shared
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string UserName{ get; set; }
        [Required]
        public string CompanyId { get; set; }
        [Required]
        public string CompanyName { get; set; }
    }
}
