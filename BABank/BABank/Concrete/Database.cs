using BABank.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABank.Concrete
{
    class Database : IMusteriDataBaseYoneticisi
    {
        public Database()
        {
            MusteriTc = new List<string>() { "1111", "2222", "3333", "4444", "5555" };
        }
        public List<string> MusteriTc { get; set; }
        public bool VipMi(string Tc)
        {
            return MusteriTc.Contains(Tc);
        }
    }
}
