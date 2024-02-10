using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables();

            Vatandas vatandas1 = new Vatandas();

            int result1 = Sum(3,5);

            Person person1 = new Person();
            person1.FirstName = "Esra";
            person1.LastName = "KILIÇ";
            person1.DateOfBirthyear = 2003;
            person1.ID = 123;

            //Arrays
            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Elvan";
            ogrenciler[1] = "Ezgi";
            ogrenciler[2] = "Ceren";

            ogrenciler = new string[4];
            ogrenciler[3] = "Emira";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] {"Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır"};

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "Eren";

            foreach(string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yenisehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yenisehirler1.Add("Adana 1");
            foreach(var sehir in yenisehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new ForeignManager());
            pttManager.GiveMask(person1);
        }

        
        static void SayHello(string name = "isimsiz")
        {
            Console.WriteLine("Hello" + name);
        }

        private static void Variables()
        {
            string message = "Merhaba";
            double amount = 10000; //db den gelir
            int number = 100;
            bool isLogin = false;

            string name = "Esra";
            string surname = "Kılıç";
            int birthyear = 2003;
            long ID = 12345678910;

            Console.WriteLine(amount * 1.18);
            Console.ReadLine();
        }

        public class Vatandas
        {
            public string name { get; set; }
            public string surname { get; set; }
            public int birthyear { get; set; }
            public long ID { get; set; }
        }

        static int Sum(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine( "Addition:" + result );
            return result;
        }

    }

}