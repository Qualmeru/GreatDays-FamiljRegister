using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreatDays_FamiljRegister.Models
{
    public class BankAssetModel
    {
        public int BankAssetId { get; set; }
        public decimal Asset { get; set; }
        public int PersonId { get; set; }
    }
}