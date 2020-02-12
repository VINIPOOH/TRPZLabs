using Lab1.dao;
using Lab1Code.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.db
{
    class CPURepository
    {
        public static List<CPUDao> findAll()
        {
            List<CPUDao> cPUs = new List<CPUDao>();
            cPUs.Add(new CPUDao(CPUTypes.SMOLLE, 200));
            cPUs.Add(new CPUDao(CPUTypes.BIG, 300));
            return cPUs;
        }
    }
}
