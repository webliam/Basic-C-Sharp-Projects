using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance
{
    using System;
    using System.Collections.Generic;

    public class CarSignUp
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public string DUI { get; set; }
        public int FullCoverageLiability { get; set; }
        public decimal Quotes { get; set; }
        public int SpeedingTickets { get; set; }
    }
}