using _02_Claims.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Claims.Tests
{
    [TestClass]
    public class ClaimRepoTests
    {
        private Claim _claims;
        private ClaimRepository _repo;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new ClaimRepository();
            _claims = new Claim();
            _repo.AddClaim(_claims);
        }


        //[TestMethod]
        //public void AddClaim_ShouldGetCorrectBool()
        //{
        //    Claim claim = new Claim();
        //    ClaimRepository repository = new ClaimRepository();
            
        //    bool addClaim = repository.AddClaim(claim);

        //    Assert.IsTrue(addClaim);
        //}
    }
}
