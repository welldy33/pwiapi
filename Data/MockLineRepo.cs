
using System.Collections.Generic;
using pwiapi.Models;

namespace pwiapi.Data
{
    public class MockLineRepo : ILineRepo
    {
        public void CreateLine(Line ln)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteLine(Line ln)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Building> Getbuildings()
        {
            throw new System.NotImplementedException();
        }

        public Line GetLineByNo(string lineNo)
        {
            return new Line { LINE_NO = "TEST", LINE_NM = "LINENAME", AREA_NO = "T1", ADD_USER = "USR", ADD_TIME = "234234" };
        }

        public IEnumerable<Line> GetLines()
        {
            var lines = new List<Line> {
              new Line { LINE_NO = "TEST", LINE_NM = "LINENAME", AREA_NO = "T1", ADD_USER = "USR", ADD_TIME = "234234" },
              new Line { LINE_NO = "TEST2", LINE_NM = "LINENAME2", AREA_NO = "T2", ADD_USER = "USR2", ADD_TIME = "234234" },
              new Line { LINE_NO = "TEST3", LINE_NM = "LINENAME3", AREA_NO = "T3", ADD_USER = "USR3", ADD_TIME = "234234" },
              new Line { LINE_NO = "TEST4", LINE_NM = "LINENAME4", AREA_NO = "T4", ADD_USER = "USR4", ADD_TIME = "234234" }
            };
            return lines;
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateLine(Line ln)
        {
            throw new System.NotImplementedException();
        }
    }
}
