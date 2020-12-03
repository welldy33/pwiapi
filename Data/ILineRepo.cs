
using pwiapi.Models;
using System.Collections.Generic;

namespace pwiapi.Data
{
    public interface ILineRepo
    {
        bool SaveChanges();
        IEnumerable<Line> GetLines();
        Line GetLineByNo(string lineNo);
        void CreateLine(Line ln);
        void UpdateLine(Line ln);
        void DeleteLine(Line ln);
    }
}
