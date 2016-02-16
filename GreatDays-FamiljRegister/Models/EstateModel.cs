using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreatDays_FamiljRegister.Models
{
    public class EstateModel
    {
        public int EstateId { get; set; }
        public string Address { get; set; }
        public string County { get; set; }
        public int FamilyId { get; set; }
    }
}