using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace modelBinding.Models
{
    public class Marksheet
    {
        public Student student { get; set; }
        public Assessment assessment { get; set; }

        public decimal totalMark { 
            get {
                return assessment.asp + assessment.mobile + assessment.advanceNetwork + assessment.isad;
                 }
        }
    }
}