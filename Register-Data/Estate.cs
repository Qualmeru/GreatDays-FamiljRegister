using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Register_Data
{
   public class Estate
    {
        [Key]
        public int EstateId { get; set; }
        public string Address { get; set; }
        public string County { get; set; }
        public int  FamilyId { get; set; }

        [ForeignKey("FamilyId")]
        public virtual Family Family { get; set; }
    }
}
