using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3 
{
    class Osoba : ICloneable
    {
        private int wiek; //deklaracja pola
        public Urodziny ur; //pole referencyjne

        //konstruktor domyślny (uzupełniamy o tworzenie obiektu)
        public Osoba()
        {
            ur = new Urodziny();
        }

        //konstruktor parametryczny
        public Osoba(int wiek,string miejsce) 
        {
            this.wiek = wiek;
            ur = new Urodziny();
            ur.UstawMiejsceUr(miejsce);
        }

        public void UstawWiek(int wiek) //metoda na ustawienie wieku
        {
            this.wiek = wiek;
        }

        public int PobierzWiek() //metoda na pobranie wieku
        {
            return wiek;
        }

        public Object Clone() //implementacja metody Clone
        {
            return MemberwiseClone();
        }

    }
}
