using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreatDays_FamiljRegister.Models
{
    public class PersonModel
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int FamilyId { get; set; }

        public List<BankAssetModel> BankAssets { get; set; }
    }
}