using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsRepositorys
{
    public enum ClaimType { Car = 1, Home, Theft }
    public class Claim
    {

        public int ClaimID { get; set; }
        public ClaimType Type { get; set; }

        public string Description { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }

        public bool IsValid
        {
            get
            {
                TimeSpan diff = DateOfClaim.Subtract(DateOfIncident);
                if (diff.Days <= 30)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Claim() { }

        public Claim(int claimID, ClaimType type, string desc, double amount, DateTime incident, DateTime claim)
        {
            ClaimID = claimID;
            Type = type;
            Description = desc;
            ClaimAmount = amount;
            DateOfIncident = incident;
            DateOfClaim = claim;
        }
    }
}