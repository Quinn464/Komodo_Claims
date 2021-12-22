using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsRepositorys
{
    public class Claim_Repo
    {
        private Queue<Claim> _repo = new Queue<Claim>();


        //Create a Claim
        public bool AddClaim(Claim claim)
        {
            int startingCount = _repo.Count;
            _repo.Enqueue(claim);

            bool wasAdded = (_repo.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //Read

        //  Get All Claims
        public Queue<Claim> GetAllClaims()
        {
            return _repo;
        }

        //  Return next Claim
        public Claim PeekClaim()
        {
            if (_repo.Peek() != null)
            {
                return _repo.Peek();
            }
            return null;
        }

       
        public bool DequeueClaim()
        {
            int startingCount = _repo.Count;
            _repo.Dequeue();

            bool wasDequeued = (_repo.Count < startingCount) ? true : false;
            return wasDequeued;
        }

    }
}
