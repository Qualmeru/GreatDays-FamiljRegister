using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register_Data
{
   public class BankAsset
    {
        [Key]
        public int BankAssetId { get; set; }
        public decimal Asset { get; set; }
        public int PersonId { get; set; }


        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }
       

    }
}
