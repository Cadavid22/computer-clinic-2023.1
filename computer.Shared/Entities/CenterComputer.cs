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
    public  class CenterComputer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]

        public String Type { get; set; } = null!;

        public String Brand { get; set; } = null!;

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public String Names { get; set; } = null!;

        public String LastName { get; set; } = null!;

        public int Phone { get; set; }

        public String Email { get; set; } = null!;

        public String Diagnosis { get; set; } = null!;

        public String Description { get; set; } = null!;

        public String State { get; set; } = null!;

        public int value { get; set; }

        public bool Completed { get; set; }
    }
}
