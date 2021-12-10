using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamAsmaca
{
    class Program
    {
        /*
         ******çağıl
        ç -> ç****
        z -> ç****
        ğ -> ç*ğ**           
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Kelimeyi tahmin ediniz :)");
            string[] kelimeler = new string[5]
            {
             "uğur","damla", "boğaçhan", "okan", "simge"
            };
            Random rastgele = new Random();
            int rastgeleIndex = rastgele.Next(0, kelimeler.Length);
            string kelime = kelimeler[rastgeleIndex];

            string sonuc = "";
            for (int i = 0; i < kelime.Length; i++)
            {
                sonuc += "*";
                //sonuc = sonuc + "*";
            }


            Console.WriteLine(sonuc);
            char[] sonucHarfler = new char[sonuc.Length];

            for (int i = 0; i < sonucHarfler.Length; i++)
            {
                sonucHarfler[i] = sonuc[i];
            }
            int hak = kelime.Length;

            bool bildimMi = false;

            do
            {               
                Console.Write("Harf giriniz: ");
                char harf = char.Parse(Console.ReadLine());
                for (int i = 0; i <kelime.Length; i++)
                {

                    if (harf == kelime[i])
                    {
                        sonucHarfler[i] = harf;
                                             
                    }                  
                }
                
                int index = kelime.IndexOf(harf);
                if (index >= 0)
                {
                    sonucHarfler[index] = kelime[index];
                }
                else
                {
                    hak--;
                }
                sonuc = "";
                foreach (var sonucHarf in sonucHarfler)
                {

                    sonuc += sonucHarf;
                    //sonuc = sonuc + sonucHarf;

                }
                Console.WriteLine(sonuc);

                if (!sonuc.Contains("*"))
                {                   
                    bildimMi = true;
                    
                }
                //sonuc = "";
                
            }
            while (hak > 0 && !bildimMi);

            if (!bildimMi)
            {
                Console.WriteLine("Bilemediniz, tekrar deneyiniz.");
            }
            else
                Console.WriteLine("Tebrikler bildiniz.");

            Console.ReadLine();
        }
    }
}
