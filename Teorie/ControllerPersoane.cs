using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie
{
    internal class ControllerPersoane
    {
        //creare de lista
        private List<Persoana> listapersoane;

        public ControllerPersoane()  //constructor
        {
            this.listapersoane = new List<Persoana>();  //adaugare persoana in lista
            this.load();
        }

        //metoda load
        public void load()
        {
            //creare obiect
            Persoana persoana1 = new Persoana("Marius", "Cosmin", 36, "inginer", true, 1);
            Persoana persoana2 = new Persoana("Florin", "Cristian", 41, "tester", false, 1);
            Persoana persoana3 = new Persoana("Maria", "Ioana", 29, "asistenta", false, 0);
            Persoana persoana4 = new Persoana("Monica", "Elena", 50, "manager", false, 0);
            Persoana persoana5 = new Persoana("Ionut", "Andrei", 31, "doctor", true, 1);

            //adaugat persoana in lista
            this.listapersoane.Add(persoana1);
            this.listapersoane.Add(persoana2);
            this.listapersoane.Add(persoana3);
            this.listapersoane.Add(persoana4);
            this.listapersoane.Add(persoana5);
        }

        //afisarea
        public void afisare()
        {
            for (int i = 0; i < listapersoane.Count; i++)
            {
                Console.WriteLine(listapersoane[i].descriere());
            }
        }

        //todo:stergerea dupa nume
        public void stergere(string nume)
        {

        }

        //todo:functie ce primeste ca parametru numele persoanei si returneaza obiectul cu numele introdus 
        public Persoana findByName(string nume)
        {
            for(int i = 0; i < listapersoane.Count; i++)
            {
                if (listapersoane[i].getNume().Equals(nume))//
                {
                   
                    return listapersoane[i];
                }
            }    
            return null;
        }   //metoda de tip persoana pentru ca returnez o persoana.


        //todo:functie ce returneqaza persoana cu varsta cea mai inaintata
        public Persoana sorteazaVarstaInaintata()
        {
            Persoana maxima = listapersoane[0];
            for (int i = 0; i < listapersoane.Count; i++)
            {

                if (listapersoane[i].getvarsta() > maxima.getvarsta())
                {
                    maxima = listapersoane[i];
                }
            }
            return  maxima;
        }

        public Persoana sorteazaVarstaMinima()
        {
            Persoana minima = listapersoane[0];
            for (int i = 0; i < listapersoane.Count; i++)
            {
                if(listapersoane[i].getvarsta() < minima.getvarsta())
                    minima = listapersoane[i];
            }
            return minima;
        }
    }
    
}
