using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriTakip.EfCore
{
    public class SiparisDetay
    {
        public int Id { get; set; }
       
        public decimal ToplamFiyat { get; set; }
        public decimal BirimFiyat { get; set; }
        public int Miktar { get; set; }
        public int SiparisId { get; set; }
        public Siparis Siparis { get; set; }
        public int UrunId { get; set; }
        public Urun Urun { get; set; }

    }
}
