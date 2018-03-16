using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            //1ci sualin cavabi---parametri metoda oturmeyin 3 ylu var: const fields, Constructor vasitesiynen, asagidaki usul da var, ancaq Meliim, ele bu Constructor deyilki?
            var obj = new StaticsOfEarth();
            obj.DetailsOfEarth();
            //2ci usul
            var bjo = new EvinSahesi(25, 54);
            bjo.Sahe();

            Futbolcu xususiyyetler = new Futbolcu("Leonel", "Messi", 29);
            


        }
    }
     
    public class StaticsOfEarth
    {
        //usul 1 ||
        public const float HerketSureti = 9.8f;
        public const float AtmosferTezyiqi = 760.0127f;

        public void DetailsOfEarth()
        {
            Console.WriteLine("Yerin gunesh etrafinda firlanma sureti {0} m/s, ve atmosfer tezyiqi {1} mm cive stunudur", HerketSureti, AtmosferTezyiqi);
        }
    }
    public class EvinSahesi
    {
        //usul 2 ||  
        public readonly int En = 25;
        public readonly int Uzunlug = 54;

       public EvinSahesi(int en, int uzunlug)
        {
            En = en; Uzunlug= uzunlug;
        }
       public void Sahe()
        {
            Console.WriteLine("Bizim Evin Sahesi : "+(En*Uzunlug));
        }
    }
    public class Futbolcu
    {
        //usul 3 ||
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Futbolcu (string name, string surname, int age)
        {
            name = name;
            surname = surname;
            age = age;
        }
        public string name
        {
            get { return name; }
            set { name = value; }
        }
        public string surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public int agr
        {
            get { return Age; }
            set { Age = value; }
        }
    }
}
