using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonathanCw2.Shared
{
    public class Project
    {
        [Key]
        public Guid Id { get; set; }
        public string ProjectName { get; set; }
        public string CProject { get; set; }
        public int ProjectId { get; set; }
    }
}
