using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register_Data
{
   public class Family
    {
        [Key]
        public int FamilyId { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Estate> Estates { get; set; }
        public virtual ICollection<Person> Persons { get; set; }
        public virtual ICollection<Car> Cars { get; set; }

    }
}
