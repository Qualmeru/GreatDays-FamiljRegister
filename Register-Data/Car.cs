using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Register_Data
{
   public class Car
    {
        [Key]
        public int CarId { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string RegistratioNnumber { get; set; }
        public int FamilyId { get; set; }

        [ForeignKey("FamilyId")]
        public virtual Family Family { get; set; }

    }
}
