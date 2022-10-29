using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie
{
    internal class Animal
    {

        private string numeanimal;
        private byte sexanimal;
        private int varsataanimal;
        public string descrireanumal()
        {
            string animal = "";
            animal += numeanimal;
            animal += sexanimal;
            animal += varsataanimal;

            return animal;
        }

        public Animal()
        {
            Console.WriteLine("Constructor Animal fara parametru");
        }

        public Animal(string numeanimal, byte sexanimal, int varstaanimal)
        {
            Console.WriteLine("Constructor aniumal cu 3 parametrii");
        }

        public string getnumeanimal()
        {

            return this.numeanimal;
        }

        public byte getsexanimal()
        {
            return this.sexanimal;
        }

        public int getvarstaanimal()
        {
            return this.varsataanimal;
        }

        public void setnumeanimal(string numeanimal)
        {
            if (numeanimal.Equals("soparla") == false)
            {
                this.numeanimal = numeanimal;
            }
            else
            {
                Console.WriteLine("Nu imi place soparla");
            }
        }

        public void setsexanimal(byte sexanimal)
        {
            if (sexanimal.Equals("femela") == false)
            {
                this.sexanimal = sexanimal;
            }
            else
            {
                Console.WriteLine("Nu imi place femela");
            }
        }

        public void setvarsatanimal(int varstaanimal)
        {
            if (varstaanimal.Equals(5) == true)
            {
                this.varsataanimal = varstaanimal;
            }
            else
            {
                Console.WriteLine("animalul are" + varsataanimal + " ani ");
            }
        }

    }
}
