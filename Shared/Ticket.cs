using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonathanCw2.Shared
{
    public class Ticket
    {
       
        [Key]public Guid Id { get; set; }
        
        public string Message { get; set; }
        public string User { get; set; }
        public string Project { get; set; }

    }
}
