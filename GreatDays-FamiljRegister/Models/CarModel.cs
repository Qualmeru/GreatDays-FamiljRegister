using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreatDays_FamiljRegister.Models
{
    public class CarModel
    {
        public int CarId { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string RegistratioNnumber { get; set; }
        public int FamilyId { get; set; }

    }
}