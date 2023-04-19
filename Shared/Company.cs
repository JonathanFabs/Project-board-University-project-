using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonathanCw2.Shared
{
   
    
   public class Company
    {
  [Key]
  public Guid Id { get; set; }
        
        public string CompanyName { get; set; }
        public int CompanyId { get; set; }
    }
}
