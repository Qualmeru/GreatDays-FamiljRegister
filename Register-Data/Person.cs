using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Register_Data
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int FamilyId { get; set; }

        public virtual ICollection<BankAsset> BankAssets { get; set; }

        [ForeignKey("FamilyId")]
        public virtual Family   Family { get; set; }
    }
}
