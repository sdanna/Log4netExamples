using System;

namespace ConsoleAppBasicConfiguration.Components
{
    public class Loan
    {
        public double LoanAmount { get; set; }
        public double PaybackAmount { get; set; }
        public DateTime? NextPaymentDue { get; set; }
        public Person LoanOfficer { get; set; }
    }
}