using System;

namespace tip_donusumleri{
    class Program{
        static void Main(string[] args){
            // Bilinçsiz Dönüşüm 
            Console.WriteLine("*****Bilinçsiz Dönüşümler*****");
            byte a = 5; 
            sbyte sb = 30;
            short c= 10;

            int d=a+sb+c;
            Console.WriteLine("D:"+d);

            long h = d;
            Console.WriteLine("H:"+h);

            string e = "Emre";
            char f='A';
            object deneme1= e+d+f; 
            Console.WriteLine(deneme1);

            // Bilinçli Dönüşümler 
            Console.WriteLine("*****Bilinçli Dönüşümler*****");

            int x = 4;
            byte y= (byte)x;
            Console.WriteLine("Y:"+y);
            
            float z= 10.3f;
            byte t = (byte)z;
            Console.WriteLine("T:"+t);

            // ToString
            Console.WriteLine("*****ToString*****");
            int xx = 12;
            string str1 = xx.ToString();
            Console.WriteLine("xx artık String srt1:"+str1);

             string str2 = 25.26f.ToString();
            Console.WriteLine("25.26f artık String srt2:"+str2);

            //System Convert 
            Console.WriteLine("*****System Convert*****");
            string s1="10",s2="25";

            int sayi1= Convert.ToInt32(s1);
            double sayi2 = Convert.ToDouble(s2);

            Console.WriteLine(sayi1+sayi2);

            ParseMethod();
        }
        public static void ParseMethod(){
            string metin1="10";
            string metin2="10,25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);
            
            Console.WriteLine("Rakam1:"+rakam1);
            Console.WriteLine("Double1:"+double1);


        }
    }
}