using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie
{
    internal class Persoana
    {

        private string nume;
        private string prenume;
        private int varsta;
        private string meserie;
        private bool facultate;
        private byte sex;
        
        public string descriere()
        {
            string text = "";
            text += nume;
            text += prenume;
            text += varsta;
            text += meserie;
            text += facultate;
            text += sex;

            return text;
        }

        //accesorile get si set 

        public Persoana()
        {
            Console.WriteLine("Eus sunt cosntrcutorul fara prametrii");
        }
        public Persoana(int ceva)
        {

            Console.WriteLine("Eu sunt un constrcutor ");
        }


        public Persoana(string name, string prenume, int varsat, string meserie, bool facultate, byte sex)
        {
            this.nume = name;
            this.prenume = prenume;
            this.varsta = varsat;   
            this.meserie = meserie;
            this.facultate = facultate;
            this.sex = sex;

        }


        public string getNume()
        {

            return this.nume;
        }

        public string getPrenume()
        {

            return this.prenume;
        }

        public int getvarsta()
        {

            return this.varsta;
        }

        public string getmeserie()
        {

            return this.meserie;
        }

        public bool getfacultate()
        {

            return this.facultate;
        }

        public byte getsex()
        {
            return this.sex;
        }

        public void setNume(string nume)
        {
            if (nume.Equals("ion") == false)
            {
                this.nume = nume;
            }
            else
            {
                Console.WriteLine("Nu uimi place ion");
            }
           
        }

        public void setprenume(string prenume)
        {
            if(prenume.Equals("vasile")==false)
            {
                this.prenume = prenume;
            }
            else
            {
                Console.WriteLine("Nu imi place vasile");
            }
        }

        public void setvarsta(int varsta)
        {
            if (varsta.Equals(10) == false)
            {
                this.varsta = varsta;
            }
            else
            {
                Console.WriteLine("Nu imi place 10");
            }
        }

        public void setmeserie(string meserie)
        {
            if (meserie.Equals("croitor") == false)
            {
                this.meserie = meserie;
            }
            else
            {
                Console.WriteLine("nu imi place croitor");
            }
        }

        public void setfacultate(bool facultate)
        {
            if(facultate.Equals("calculatoare")==true)
            {
                this.facultate = facultate;
            }
            else
            {
                Console.WriteLine("imi place facultatea");
            }
        }

        public void setsex(byte sex)
        {
            if(sex.Equals("F")==true)
            {
                this.sex = sex; 
            }
            else
            {
                Console.WriteLine("Sexul Feminin");
            }
        }

    }
}
