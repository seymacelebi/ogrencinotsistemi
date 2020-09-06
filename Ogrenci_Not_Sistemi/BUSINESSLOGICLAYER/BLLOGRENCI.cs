using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using FACADELAYER;

namespace BUSINESSLOGICLAYER
{
   public class BLLOGRENCI
    {
        public static int EKLE(ENTITYOGRENCI deger)
        {
            if(deger.AD!=null && deger.SOYAD!=null && deger.KULUPID!=0 && deger.FOTOGRAF!=null && deger.KULUPID!=0)
            {
                return FACADEOGRENCI.EKLE(deger);
            }
            return -1;
        }
        public static bool GUNCELLE(ENTITYOGRENCI deger)
        {
            if (deger.AD != null && deger.SOYAD != null && deger.KULUPID != 0 && deger.FOTOGRAF != null && deger.KULUPID != 0 && deger.ID != 0)
            {
                return FACADEOGRENCI.GUNCELLE(deger);
            }
            return false;
        }
        public static bool SIL(int deger)
        {
            if(deger!=0 && deger > 1)
            {
                return FACADEOGRENCI.SIL(deger);
            }
            return false;
        }
        public static List<ENTITYOGRENCI> LISTELE()
        {
            return FACADEOGRENCI.OGRENCILISTESI();
        }
    }
}
