using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace computer.Shared.Entities
{
    public  class MyComputer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public String Description { get; set; } = null!;

        public DateTime Date { get; set; }

        public bool IsCompleted { get; set; }
    }
}
