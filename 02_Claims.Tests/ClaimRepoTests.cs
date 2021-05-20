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
        public Claim _claims;
        public ClaimRepository _repo;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new ClaimRepository();
            Claim claimOne = new Claim(1, ClaimType.Car, "Car accident on 465.", 400.00M, new DateTime(2018, 04, 25), new DateTime(2018, 04, 27));
            _repo.AddClaim(_claims);
        }


        [TestMethod]
        public void AddClaim_ShouldGetCorrectBool()
        {
            Claim claim = new Claim();
            int previous = _repo.GetClaims().Count;
            _repo.AddClaim(claim);
            int current = _repo.GetClaims().Count;
            Assert.IsTrue(current == previous + 1);
        }
    }
}
