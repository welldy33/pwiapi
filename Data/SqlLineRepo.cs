
using System;
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

        public void CreateLine(Line ln)
        {
            if (ln == null) {
                throw new ArgumentNullException(nameof(ln));
            }
            _context.CMN_LINE.Add(ln);
        }

        public Line GetLineByNo(string lineNo)
        {
            return _context.CMN_LINE.FirstOrDefault(p => p.LINE_NO == lineNo);
        }

        public IEnumerable<Line> GetLines()
        {
            return _context.CMN_LINE.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges()>=0);
        }
    }
}
