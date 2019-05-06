using System;
//-------Enumeraciones-------

namespace Dia6Enumeraciones
{
    class Program
    {

        enum Dias {
            lunes,
            martes,
            miercoles,
            jueves,
            viernes,
            sabado,
            domingo
        }
        enum Meses {
            Enero=1,
            Febrero=2,
            Marzo=20,
            Abril,
            Mayo=50,
            Julio
        }
        static void Main(string[] args)
        {
            var diaFav = Dias.lunes;
            Console.WriteLine($"Hello World!{diaFav}");
            Console.WriteLine($"Hello World!{(Dias)6}");
            Console.ReadKey();
            Console.WriteLine($"Hello World!{(int)Meses.Abril}");
            Console.WriteLine($"Hello World!{(int)Meses.Julio}");
            Console.ReadLine();

        }
    }
}
