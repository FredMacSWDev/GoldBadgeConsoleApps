using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Claims.Repository
{
    public enum ClaimType
    {
        Car, Home, Theft
    }
    public class Claim
    {
        public int ClaimID { get; set; }
        public ClaimType ClaimType { get; set; }
        public string Description { get; set; }
        public decimal ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public System.Data.DataColumnCollection Columns { get; }
        public bool IsValid
        {
            get
            {
                TimeSpan validClaims = DateOfClaim - DateOfIncident;
                if (validClaims.Days <= 30)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public string CurrencySymbol { get; set; }
      

        public Claim() { }
        public Claim(int claimID, ClaimType claimType, string description, decimal claimAmount, DateTime dateOfIncident, DateTime dateOfClaim)
        {
            ClaimID = claimID;
            ClaimType = claimType;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;            
        }       
    }      
}
        
        


