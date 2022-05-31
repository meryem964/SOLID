using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1=new Kurs();
            kurs1.KursAdı = "C#";
            kurs1.Egitmen = "engin demirog";
            kurs1.IzlenmeOranı = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "java";
            kurs2.Egitmen = "kerem varış";
            kurs2.IzlenmeOranı = 64;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "python";
            kurs3.Egitmen = "berkay bilgin";
            kurs3.IzlenmeOranı = 80;



            Kurs kurs4 = new Kurs();
            kurs4.KursAdı = "C++";
            kurs4.Egitmen = "murathan kurtboğan";
            kurs4.IzlenmeOranı = 100;


            Console.WriteLine(kurs1.KursAdı + ":" + kurs1.Egitmen);


            Kurs[] kurslar = new Kurs[]
            { 
            
            kurs1, kurs2, kurs3 , kurs4
            
            };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdı +":" + kurs.Egitmen);
            }

        }
    }

    class Kurs
    {
        public string KursAdı { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }


    }
}
