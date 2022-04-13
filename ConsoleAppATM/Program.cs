using System;

namespace ConsoleAppATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 5000;
            int secim;
            int para_cek_yatır = 0;
            

            

            menu:
            Console.Write("Bakiyeniz :" + bakiye + "\n");



            Console.WriteLine("1) Para Çekme\n" +
                              "2) Para yatırma\n" +
                              "3) Bakiye Sorgulama\n" +
                              "4) Kart İade\n");
            Console.WriteLine("\nLütfen Yapmak istediğiniz işlemi seçiniz: \n");
            secim = Convert.ToInt32(Console.ReadLine());
            
            switch (secim)
            {
                case 1:
                    Console.Clear();
                    Console.Write("Çekmek istediğiniz tutarı giriniz ...\n");
                    para_cek_yatır = Convert.ToInt32(Console.ReadLine());

                    if(para_cek_yatır > bakiye)
                    {
                        Console.WriteLine("Bakiyeniz Yetersiz..");
                        Environment.Exit(0);
                    }
                    else
                    {
                        bakiye = bakiye - para_cek_yatır;
                        Console.WriteLine("{0} TL para çektiniz..\n"+ para_cek_yatır);
                        Console.WriteLine("Mevcut bakiyeniz :"+ bakiye);
                        Environment.Exit(0);
                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("Yatırmak istediğiniz tutarı giriniz ...");
                    para_cek_yatır = Convert.ToInt32(Console.ReadLine());

                         bakiye = bakiye + para_cek_yatır;
                    Console.WriteLine(para_cek_yatır +"TL para yatırdınız..\n" + para_cek_yatır);
                    Console.WriteLine("Mevcut bakiyeniz :" + bakiye);
                    Environment.Exit(0);
                    break;

                case 3:

                    Console.Clear();
                    Console.WriteLine("Mevcut bakiyeniz: {0} TL", bakiye);
                    Environment.Exit(0);
                    break;


                case 4:

                    Console.Clear();
                    Console.WriteLine("Kartınız iade ediiyor..");
                    Environment.Exit(0);
                    break;

            }

            goto menu;
               





        }
    }
}
