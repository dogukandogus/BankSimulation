using BABank.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABank.Concrete
{
    public delegate void HaberTipi(object sender);
    public delegate void NumaraHaberTipi(INumara numara);
    /*
     * 1-Delege tanımlanır. >> public delegate void HaberTipi(object sender)
     * 2-Event tanımlanır. >> event HaberTipi NumaratorBenGeldim
     * 3-Eventi metoda bagla >> musteri.NumaratorBenGeldim += banka.Numarator.NumaraUret;
     * 4-Numara üret(object sender) metodu onu temsik eden delegenin parametresiyle tanımlamalısın
     * 5-NumaratorBenGeldim(this);
     
     */
    public class Banka : IBank
    {
        public Banka()
        {
            Giseler = new List<IGise>(); // listenin kullanılabilmesi için instance alınması gerekiyor
            MesaiMi = false;
        }
        public List<IGise> Giseler { get; set; }
        public IKuyruk Kuyruk { get; set; }
        public INumarator Numarator { get; set; }
        public ISayac Sayac { get; set; }

        public static bool MesaiMi { get; set; }
        public static IMusteriDataBaseYoneticisi DbMusteri = new Database();

        public void MesaiBaslat(int giseSayisi)
        {
            Kuyruk = new Kuyruk();
            Sayac = new Sayac();
            Numarator = new Numarator();
            for (int i = 0; i < giseSayisi; i++)
            {
                IGise gise = new Gise();
                //Sayac Benim Bitti

                gise.KuyrukBenMusaitim += Kuyruk.GiseyeNumaraGonder;
                gise.SayacIsimBitti += Sayac.GisedenIsiBitenNumaraAl;
                Giseler.Add(gise);
            }
            Numarator.NumaraUrettim += Kuyruk.NumaratordenNumaraAl;
            MesaiMi = true;

        }

        public void MesaiBitir()
        {
            MesaiMi = false;
        }
    }
}
