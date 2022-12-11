using System;

namespace operatorler{
    class Program{
        static void Main(string[] args){
            //Atama ve işlemli Atama
            int y=3;
            
            y+=3;   // y=y+3 anlamına gelir ve y ve 3 toplar
            Console.WriteLine(y); 
            
            y-=3;   // y=y-3 anlamına gelir ve y den 3 çıkarır 
            Console.WriteLine(y);
            
            y*=3;   // y=y*3 anlamına gelir ve y ve 3 çarpar 
            Console.WriteLine(y);
            
            y/=3;   // y=y/3 anlamına gelir ve y yi 3 böler 
            Console.WriteLine(y);

            y%=3;   // y=y%3 anlamına gelir ve y yi 3 böler ve kalanı alır 
            Console.WriteLine(y);
//////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("//////////////");
            //Mantıksal Öperatörler
            // ||,&&,!
            bool isSucess = true;
            bool isComplate = false;

            if(isSucess && isComplate){ // && ve operatörü iki değişken de sağlanıyorsa if çalışır
                Console.WriteLine("Prefect!");
            }
            if(isSucess || isComplate){ // || veya operatörü iki değişkenden herhangi biri sağlanıyorsa if çalışır
                Console.WriteLine("Great!");
            }
            if(!isComplate){ // ! değil operatörü değişkenin değilini(tersini alır) sağlanıyorsa if çalışır
                Console.WriteLine("Fine!");
            }
//////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("//////////////");
            //İlişkisel Öperatörler
            // <, >, <=, >=, ==, !=
            
            int a=2;
            int b=4;

            bool sonuc1=a>b;    // a b den büyük ise true döner
            Console.WriteLine(sonuc1);
            bool sonuc2=a<b;    // a b den küçük ise true döner  
            Console.WriteLine(sonuc2);
            bool sonuc3=a>=b;   // a b den büyük veya eşit ise true döner
            Console.WriteLine(sonuc3);
            bool sonuc4=a<=b;   // a b den küçük veya eşit ise true döner 
            Console.WriteLine(sonuc4);
            bool sonuc5=a==b;   // a b ye eşit ise true döner
            Console.WriteLine(sonuc5);
            bool sonuc6=a!=b;    // a b ye eşit değil ise true döner
            Console.WriteLine(sonuc6);
//////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("//////////////");
            // Aritmetik Öperatörler
            // /, +, -, *, %, ++,--

            int sayi1=15;
            int sayi2=5;
            int sonuc;

            sonuc=sayi1/sayi2; // / bölme operatörü sayı1 i sayı2 ye böler
            Console.WriteLine(sonuc);
            sonuc=sayi1+sayi2;// + toplama operatörü sayı1 ve sayı2 yi toplar
            Console.WriteLine(sonuc);
            sonuc=sayi1-sayi2;// - çıkarma operatoru sayı1 den sayı2 yi çıkarır
            Console.WriteLine(sonuc);
            sonuc=sayi1*sayi2;// * çarpma peratoru sayı1 ve sayı2 yi çarpar
            Console.WriteLine(sonuc);
            sonuc=sayi1%sayi2;// % modalma operatörü sayı1 i sayı2 ye böler ve kalannı verir
            Console.WriteLine(sonuc);
            sonuc=sayi1++;// % modalma operatörü sayı1 i 1 artırır
            Console.WriteLine(sonuc);
            sonuc=sayi1--;// % modalma operatörü sayı1 i 1 azaltır
            Console.WriteLine(sonuc);

        }
    }
}