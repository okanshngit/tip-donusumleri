using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
           //Implicit Conversion

           byte b=2;
           sbyte sb = 5;
           short sh=30;

           int d= b+sb+sh;

           long h=d;

           float i = h;

           string e="okan";
           char soyad='s';
           object g=e+soyad+h; //Rule them all.


           //Explicit Conversion

           int x= 4;
           byte y= (byte)x; //cast etme

                ///ToString Metodu
                int xx=15;
                string yy= xx.ToString();

                // System.Convert

                string s1 = "10";
                string s2= "20";
                int sayi1,sayi2;
                int toplam;

                sayi1 = Convert.ToInt32(s1);
                sayi2 = Convert.ToInt32(s2);
                toplam = sayi1+sayi2;

                //Parse string ifadeleri dönüştürmek için kullanılır
                













        }
    }
}
