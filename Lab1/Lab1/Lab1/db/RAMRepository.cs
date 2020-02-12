using Lab1.dao;
using Lab1Code.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.db
{
    class RAMRepository
    {
        public static List<RAMDao> findAll()
        {
            List<RAMDao> rAMs = new List<RAMDao>();
            rAMs.Add(new RAMDao (RAMTypes.SMOLLE, 100));
            rAMs.Add(new RAMDao(RAMTypes.BIG, 100));
            return rAMs;
        }
    }
}
