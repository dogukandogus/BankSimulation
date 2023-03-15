using BABank.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABank.Abstract
{
    public interface IGise
    {
        //KuyrukBenMüsaitim
        //SayacIsımBitti
        event HaberTipi KuyrukBenMusaitim;
        event NumaraHaberTipi SayacIsimBitti;
        INumara islemYapilanNumara { get; set; }
        void IslemYap();
        void Kontrol(object sender);
    }
}
