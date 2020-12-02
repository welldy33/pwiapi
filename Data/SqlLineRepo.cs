
using System.Collections.Generic;
using System.Linq;
using pwiapi.Models;

namespace pwiapi.Data
{
    public class SqlLineRepo : ILineRepo
    {
        private readonly LineContext _context;

        public SqlLineRepo(LineContext context)
        {
            _context = context;
        }

        public Line GetLineByNo(string lineNo)
        {
            return _context.CMN_LINE.FirstOrDefault(p => p.LINE_NO == lineNo);
        }

        public IEnumerable<Line> GetLines()
        {
            return _context.CMN_LINE.ToList();
        }
    }
}
