using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Urodziny
    {
        private string miejsceUr; //deklaracja pola
        public Urodziny() { } //konstruktor domyślny

        //konstruktor parametryczny
        public Urodziny(string miejsceUr)
        {
            this.miejsceUr = miejsceUr;
        }

        //metoda na ustawienie miejsca urodzin
        public void UstawMiejsceUr(string miejsceUr)
        {
            this.miejsceUr = miejsceUr;
        }

        //metoda na pobranie miejsca urodzenia
        public string PobierzMiejsceUr()
        {
            return miejsceUr;
        }
    }
}
