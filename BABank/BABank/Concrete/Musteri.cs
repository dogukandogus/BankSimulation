using BABank.Abstract;
using BABank.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABank.Concrete
{
    public class Musteri : IMusteri
    {
        public string TCNo { get; set; }
        public IslemTipi islemTipi { get; set; }
        public INumara Numara { get; set; }

        public event HaberTipi NumaratorBenGeldim;
        public event HaberTipi GiseBenGeldim;

        public void KontrolEt(INumara numara)
        {
            if(numara == Numara)
            {
                GiseBenGeldim(this);
            }
        }

        public void NumaraAl()
        {
            if(TCNo != null)
            {
                NumaratorBenGeldim(this);
            }
        }
    }
}
