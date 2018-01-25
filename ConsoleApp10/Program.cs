using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    interface IMagazyn
    {
        bool Przyjmij(string zamowienie);
        bool Wydaj(int wydaj);

    }
    class Magazyn : IMagazyn
    {
        public override string ToString()
        {
            return zamowienie;
        }
        private string zamowienie;
        public bool Przyjmij(string zamowienie)
        {
            zamowienie = this.zamowienie;
            Console.WriteLine("Przyjęto zamówienie: {0}", zamowienie);
            return true;
        }
        public bool Wydaj(int wydaj)
        {
            return true;
        }
        public Magazyn(string zamowienie)
        {
            this.zamowienie = zamowienie;
        }
    } 
    abstract public class Bohater
    {
        private int hp;
        public string hp_ile;


        public override string ToString()
        {
            return String.Format("HP: {0}", hp);

        }
            public Bohater(int hp)
        {
            this.hp = hp;
        }
        abstract public void ZadajCios(int cios);
        
    }
    public class Elf : Bohater
    {
        public int cios;
        private string magia;
        
        public override string ToString()
        {
            return magia;
            
        }

        public Elf(int hp, string magia) : base(hp)
        {
            this.magia = magia;
        }

        public override void ZadajCios(int cios)
        {
            this.cios = cios;
            Console.WriteLine("Cios za {0} dmg", cios);
        }
       
    }

    public class Ork : Bohater
    {

        public int walka;
        public int cios=5;
        public string walka_ile;
        public override string ToString()
        {
            walka_ile = walka.ToString();
               return walka_ile;

        }
        public Ork(int hp, int walka) : base(hp)
        {
            this.walka = walka;
            
            //Console.WriteLine("Cios za {0} + {1} dmg", walka, cios);
        }
        public override void ZadajCios(int cios)
        {
            
            //Console.WriteLine("Cios za {0} + {1} dmg", walka, cios);
        }
    }
    class Pacjent
    {
        private string choroba;
        public Pacjent(string choroba)
        {
            this.choroba = choroba;
        }
        
    }
    class Przychodnia : Pacjent
    {
        private string adres;
        public Przychodnia(string choroba) : base(choroba)
        {

        }
        

    }
    enum Tydzien
    {
        Poniedziałek, Wtorek, Środa, Czwartek, Piątek, Sobota, Niedziela
    };
    class Program
    {
        static void Main(string[] args)
        {

            Queue<Magazyn> Kolejka = new Queue<Magazyn>();
            Magazyn obiekt1 = new Magazyn("Przedmiot pierwszy");
            Magazyn obiekt2 = new Magazyn("Przedmiot drugi");
            Magazyn obiekt3 = new Magazyn("Przedmiot trzeci");
            Kolejka.Enqueue(obiekt1);
            Kolejka.Enqueue(obiekt2);
            Kolejka.Enqueue(obiekt3);

            //Console.WriteLine(obiekt1.ToString());
            //Console.WriteLine(Kolejka.Dequeue.ToString());

            Console.WriteLine(Kolejka.Dequeue());
            Console.WriteLine(Kolejka.Dequeue());
            Console.WriteLine(Kolejka.Dequeue());

            /////3/////
            List<Magazyn> Lista = new List<Magazyn>();
            Lista.Add(obiekt1);
            Lista.Add(obiekt2);
            Lista.Add(obiekt3);

            /*
            foreach(Magazyn x in Lista)
            {
                Console.WriteLine(x);
            }
            */

            //////4/////

            Lista.Reverse();

            /*
            foreach(Magazyn x in Lista)
            {
                Console.WriteLine(x);
            }
            */

            List<Bohater> LisBoh = new List<Bohater>();
            Elf Elff = new Elf(120,"ogien");
            Elf Elfka = new Elf(100, "woda");
            Ork Ork = new Ork(200, 15);
            Ork Orkrzyca = new Ork(170, 17);
            LisBoh.Add(Elff);
            LisBoh.Add(Elfka);
            LisBoh.Add(Ork);
            LisBoh.Add(Orkrzyca);
            /*
           foreach (var element in LisBoh)
           {
               Console.WriteLine(element);
           }
          */
            Console.WriteLine("Przeciwnik 1: \nzywiol:" + Elff.ToString() + "\nhp:" + Elff.ToString());
           Console.WriteLine("Przeciwnik 2: \nzywiol:" + Elfka.ToString() + "\nhp:???");
           Console.WriteLine("Przeciwnik 3: \nsila ciosu:" + Ork.ToString() + "\nhp:???");
           Console.WriteLine("Przeciwnik 4: \nsila ciosu:" + Orkrzyca.ToString() + "\nhp:???");

            Pacjent p1 = new Pacjent("RAK");

            string[,] dniTygodnia = new string[2,3];
            dniTygodnia[0, 1] = ("Poniedzialek");
            dniTygodnia[0, 2] = ("Wtorek");
            dniTygodnia[0, 3] = ("Środa");
            
            foreach(var x in dniTygodnia)
            {
                Console.WriteLine(x);
            }



            Console.ReadKey();
        }
    }
}
