using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriTakip.EfCore
{
    public class Urun
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public int Miktar { get; set; }
        public decimal Fiyat { get; set; }
        public int BarkodNo { get; set; }
        public List<SiparisDetay> SiparisDetaylar { get; set; }

    }
}
