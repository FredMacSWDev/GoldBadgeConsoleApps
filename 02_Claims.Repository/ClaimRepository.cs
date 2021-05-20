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

        public Claim WorkClaim()
        {
            return _claims.Dequeue();
        }

        public Claim NextClaimInQueue()
        {
            return _claims.Peek();
        }
    }
}
