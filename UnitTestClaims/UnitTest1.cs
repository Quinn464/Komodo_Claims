using ClaimsRepositorys;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestClaims
{
    [TestClass]
    public class Claim_RepoTests
    {
        [TestMethod]
        public void AddClaim_ShouldGetCorrectBool() //Create
        {
            //Arrange
            Claim claim = new Claim();
            Claim_Repo repo = new Claim_Repo();

            //Act
            bool addClaim = repo.AddClaim(claim);

            //Assert
            Assert.IsTrue(addClaim);
        }

        [TestMethod]
        public void GetClaims_ShouldReturnCorrectCollection() //Read
        {
            //Arrange
            Claim claim = new Claim();
            Claim_Repo repo = new Claim_Repo();
            repo.AddClaim(claim);

            //Act
            System.Collections.Generic.Queue<Claim> claims = repo.GetAllClaims();
            bool hasClaim = claims.Contains(claim);

            //Assert
            Assert.IsTrue(hasClaim);
        }

        [TestMethod]
        public void PeekClaim_ShouldReturnNextClaim() //Read
        {
            //Arrange
            Claim claim = new Claim();
            Claim_Repo repo = new Claim_Repo();
            repo.AddClaim(claim);

            //Act
            Claim nextClaim = repo.PeekClaim();

            //Assert
            Assert.AreEqual(nextClaim, claim);

        }

        //Delete
        [TestMethod]
        public void DequeueClaim_ShouldReturnTrue()
        {
            //Arrange
            Claim claim = new Claim();
            Claim_Repo repo = new Claim_Repo();
            repo.AddClaim(claim);

            //Act
            bool dequeuedClaim = repo.DequeueClaim();

            //Assert
            Assert.IsTrue(dequeuedClaim);

        }
    }
}