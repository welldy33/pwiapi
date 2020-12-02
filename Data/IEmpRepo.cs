using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pwiapi.Models;

namespace pwiapi.Data
{
    public interface IEmpRepo
    {
        IEnumerable<Emp> GetEmps();
        Emp GetEmpById(string nik); 
    }
}
