using BABank.Concrete;
using BABank.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABank.Abstract
{
    public interface IMusteri
    {
        //NumaratorBenGeldim
        //GiseBenGeldim
        event HaberTipi NumaratorBenGeldim; //Numaratorbengeldim eventini HaberTipi isimli delege temsil ediyor.
        event HaberTipi GiseBenGeldim;  //bağlama yapılmadı henüz. Nesne olusunca baglanacak! 
        string TCNo { get; set; }
        IslemTipi islemTipi { get; set; }
        INumara Numara { get; set; }
        void NumaraAl();
        void KontrolEt(INumara numara);

    }
}
