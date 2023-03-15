using BABank.Abstract;
using BABank.Concrete;
using BABank.Enum;

namespace BABank
{
    public class Numarator : INumarator
    {
        public Numarator()
        {
            BireyselSiraSayaci = 1000;
            GiseSiraSayaci = 2000;
            VipSiraSayaci = 3000;
        }
        private int _BireyselSiraSayaci;
        private int _GiseSiraSayaci;
        private int _VipSiraSayaci;
        public int VipSiraSayaci
        {
            get { return _VipSiraSayaci; }
            set
            {
                if (value >= 3000 && value < 4000)
                {
                    _VipSiraSayaci = value;
                }
            }
        }
        public Numarator()
        {

        }
        public int BireyselSiraSayaci
        {
            get { return _BireyselSiraSayaci; }
            set
            {
                if (value > 999 && value < 2000)
                {
                    _BireyselSiraSayaci = value;
                }
            }
        }
        public int GiseSiraSayaci
        {
            get { return _GiseSiraSayaci; }
            set
            {
                if (value >= 2000 && value < 3000)
                {
                    _GiseSiraSayaci = value;
                }
            }
        }
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public event NumaraHaberTipi NumaraUrettim;

        public void NumaraUret(object sender)
        {
            if (Banka.MesaiMi)
            {
                IMusteri musteri = sender as IMusteri;
                bool Vipmi = Banka.DbMusteri.VipMi(musteri.TCNo);
                INumara numara = null;
                if (Vipmi)
                {
                    numara = new VipNumarasi();
                    numara.SiraNumarasi = VipSiraSayaci;
                    VipSiraSayaci++;
                }
                else if(musteri.islemTipi == IslemTipi.Bireysel)
                {
                    numara = new BireyselNumara();
                    numara.SiraNumarasi = BireyselSiraSayaci;
                    BireyselSiraSayaci++;
                }
                else if(musteri.islemTipi == IslemTipi.Gise)
                {
                    numara = new GiseNumarasi();
                    numara.SiraNumarasi = GiseSiraSayaci;
                    GiseSiraSayaci++;
                }
                musteri.Numara = numara;
                NumaraUrettim(numara);
            }
            else
            {
                //HATA!
            }
        }
    }
}