using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriTakip.EfCore
{
    public class Siparis
    {
        public int Id { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public int? MusteriId { get; set; }
        public Musteri Musteri { get; set; }
        public List<SiparisDetay> SiparisDetay { get; set; }


    }
}
