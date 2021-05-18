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
        public string ClaimType { get; set; }
        public string Description { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public System.Data.DataColumnCollection Columns { get; }
        public bool IsValid
        {
            get
            {
                int expiryDate = 30;
                if ((expiryDate - DateTime.DateOfIncident).TotalDays <= 30)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {

            }
        }

        public Claim() { }
        public Claim(int claimID, string claimType, string description, double claimAmount, DateTime dateOfIncident, DateTime dateOfClaim, bool isValid)
        {
            ClaimID = claimID;
            ClaimType = claimType;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;
        }
    }
}
