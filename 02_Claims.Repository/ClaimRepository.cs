using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Claims.Repository
{
    public class ClaimRepository
    {
        private readonly Queue<Claim> _claims = new Queue<Claim>();
        public Queue<Claim> GetClaims()
        {
            return _claims;
        }

        public void AddClaim(Claim newClaim)
        {
            _claims.Enqueue(newClaim);
        }

        public void CloseOutClaim()
        {
            _claims.Dequeue();
        }

        public void IsValid(Claim claim)
        {
            
            if ()
            {

            }
            else
            {

            }
                
        }
    }
}
