using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //Naming Convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tekbrikler sepete eklendi: " +urun.Adi);
        }

        public void Ekle2(String urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Tekbrikler sepete eklendi: " + urunAdi);
        }
    }
}
