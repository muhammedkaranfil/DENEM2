// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine("");
            byte b    = 5;              //1 byte
            sbyte c   = 5;              //1 byte

            short s   = 5;              //2 byte
            ushort us = 5;              //2 byte

          Int16 i16   = 2;              //2 byte
          int  i      = 2;              //4 byte
          Int32 İ32   = 2;              // 4 byte
          Int64 i64   = 2;              //8 byte
          uint ui     = 2;              //4 byte
          long  l     = 4;              //8 byte
          ulong ul    = 4;              //8 byte
        
        //Reel sayılar
        float  f   = 5;               //4 byte
        double  d  = 5;               //8 byte    
        decimal de = 5;                // 16byte  
        
        char ch  = '2';             //2  byte
        string   str="muhammed";        // sınırsız
        
        bool b1  = true;
        bool b2  = false;
        
        DateTime dt = DateTime.Now;
        
        // Console.WriteLine("dt");
        object01 = "x";
        object02 = "y";
        object03 = 4;
        object04 = 4.3;
        
        //String ifadeler
        string str1 = string.Empty;
        str1  = "Muhammed Karanfil ";
        string ad = "Muhammed";
        string soyad  = "Karanfil ";
        string tamIsim =ad + " " + soyad;

        //İnteger tanımlama şeileri
        int İnteger1  = 5;
        int İnteger2  = 3;
        int İnteger3  =  İnteger1  * İnteger2;

        // boolean
        bool bool1 = 10>2;
        //değikşen dönüşümleri
        string str20 = "20";
        int int20 = 20;
        string yeniDeger = str20 + int20.ToString();
       Console.WriteLine ("yenideger");  //çıtısı 2020
        int  int21 = int20 + Convert.ToInt32(str20);
        Console.WriteLine ("int21");        //çıtısı40
        int int22 = int20 +  int.Parse(str20);  //çıtısı 40
       
        // datetime
        
        string datetime  = DateTime.Now.ToString("dd.MM.yyyy");
         Console.WriteLine ("datetime");
         //saat
         string hour  = DateTime.Now.ToString("HH.mm");
         Console.WriteLine ("hour");
            {
                
            }       
       
       
        }
    }
}



