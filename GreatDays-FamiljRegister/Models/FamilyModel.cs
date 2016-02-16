using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreatDays_FamiljRegister.Models
{
    public class FamilyModel
    {
        public int FamilyId { get; set; }
        public string LastName { get; set; }

       public List<EstateModel> Estates { get; set; }
        public List<PersonModel> Persons { get; set; }
        public List<CarModel> Cars { get; set; }

    }
}