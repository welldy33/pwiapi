
using pwiapi.Models;
using System.Collections.Generic;

namespace pwiapi.Data
{
    public interface ILineRepo
    {
        IEnumerable<Line> GetLines();
        Line GetLineByNo(string lineNo);
    }
}
