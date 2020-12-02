using System.Collections.Generic;
using pwiapi.Models;

namespace pwiapi.Data
{
    public class MockEmpRepo:IEmpRepo
    {
        public Emp GetEmpById(string nik)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Emp> GetEmps() {
            throw new System.NotImplementedException();
        }
    }
}
