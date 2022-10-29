using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persoana a = new Persoana(23);
            //Persoana b = new Persoana(12);
            //Persoana c = new Persoana();
            //Persoana d = new Persoana("Alex", "Achim", 34, "lacatur", true, 1 );

            //Console.WriteLine(d.descriere());

            //a.setNume("Ovidiu");
            //a.setprenume("Popescu");
            //a.setvarsta(25);
            //a.setmeserie("doctor");
            //a.setfacultate(true);
            //a.setsex(0); 

            //b.setNume("Adrian");
            //b.setprenume("Popescu");
            //b.setvarsta(30);
            //b.setmeserie("inginer");
            //b.setfacultate(true);
            //b.setsex(0);

            //c.setNume("Ioana");
            //c.setprenume("Damian");
            //c.setvarsta(32);
            //c.setmeserie("ospatarita");
            //c.setfacultate(false);
            //c.setsex(1);

            ControllerPersoane ctrl = new ControllerPersoane();

            Persoana x = ctrl.findByName("Maria");
            Persoana y = ctrl.sorteazaVarstaInaintata();
            Persoana z = ctrl.sorteazaVarstaMinima();

            Console.WriteLine(x.descriere());
            Console.WriteLine(y.descriere());
            Console.WriteLine(z.descriere());
            Console.ReadKey();

        }
    }
}
