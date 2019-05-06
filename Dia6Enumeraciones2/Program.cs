using System;
//----------------------------------
//---------Enumeraciones2-----------
//----------------------------------
namespace Dia6Enumeraciones2
{
    
    class Program
    {
        //Segun la fidelidad de los clientes de un almacén recibe un tipo de descuento, 
        //si es un cliente vip tiene un descuento del 30% 
        //para clientes platino un 50%
        // para general un 5%, 
        //el usuario debe ingresar el tipo de usuario y el valor de la compra
        //Mostrar el valor inicial,Descuento y el valor de la compra
        enum cliente
        {

            General=5,
            Vip=30,
            Platino=50,
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"Ingrese su tipo de usuario {cliente.General}");
                Console.WriteLine($"{cliente.Vip}");
                //={ (int)cliente.Vip} ={(int)cliente.Platino}={(int)cliente.General}
                Console.WriteLine($"{cliente.Platino}");
                var datoCl =Convert.ToString(Console.ReadLine());
                Console.WriteLine($"Ingrese El valor de la compra");
                double datoComp =Convert.ToDouble(Console.ReadLine());
            //    double valDescue;
            //    double valTot;
            //        switch (datoCl)
            //        {
            //            case "General":
            //                Console.WriteLine($"Usuario:{datoCl}");
            //                Console.WriteLine($"Valor Compra inicial:{datoComp}");
            //                valDescue = (datoComp * (int)cliente.General) / 100;
            //                Console.WriteLine($"Descuento:{valDescue}");
            //                valTot = datoComp - valDescue;
            //                Console.WriteLine($"Valor Compra Final:{valTot}");
            //                break;
            //            case "Vip":
            //                Console.WriteLine($"Usuario:{datoCl}");
            //                Console.WriteLine($"Valor Compra inicial:{datoComp}");
            //                valDescue = (datoComp * (int)cliente.Vip) / 100;
            //                Console.WriteLine($"Descuento:{valDescue}");
            //                valTot = datoComp - valDescue;
            //                Console.WriteLine($"Valor Compra Final:{valTot}");
            //                break;
            //            case "Platino":
            //                Console.WriteLine($"Usuario:{datoCl}");
            //                Console.WriteLine($"Valor Compra inicial:{datoComp}");
            //                valDescue = (datoComp * (int)cliente.Platino) / 100;
            //                Console.WriteLine($"Descuento:{valDescue}");
            //                valTot = datoComp - valDescue;
            //                Console.WriteLine($"Valor Compra Final:{valTot}");
            //                break;
            //            default:
            //                Console.WriteLine($"Usuario:{datoCl} no es un dato valido");
            //                break;
            //        }
            //}
            //catch (Exception error)
            //{
            //    Console.WriteLine(error.Message);

            //}
            Console.ReadKey();
        }
        static void compra(string val,double com) {
             val = "";
             com = 0;
            double valDescue;
            double valTot;
            switch (val)
            {
                case "General":
                    Console.WriteLine($"Usuario:{val}");
                    Console.WriteLine($"Valor Compra inicial:{com}");
                    valDescue = (com * (int)cliente.General) / 100;
                    Console.WriteLine($"Descuento:{valDescue}");
                    valTot = com - valDescue;
                    Console.WriteLine($"Valor Compra Final:{valTot}");
                    break;
                case "Vip":
                    Console.WriteLine($"Usuario:{val}");
                    Console.WriteLine($"Valor Compra inicial:{com}");
                    valDescue = (com * (int)cliente.Vip) / 100;
                    Console.WriteLine($"Descuento:{valDescue}");
                    valTot = com - valDescue;
                    Console.WriteLine($"Valor Compra Final:{valTot}");
                    break;
                case "Platino":
                    Console.WriteLine($"Usuario:{val}");
                    Console.WriteLine($"Valor Compra inicial:{com}");
                    valDescue = (com * (int)cliente.Platino) / 100;
                    Console.WriteLine($"Descuento:{valDescue}");
                    valTot = com - valDescue;
                    Console.WriteLine($"Valor Compra Final:{valTot}");
                    break;
                default:
                    Console.WriteLine($"Usuario:{val} no es un dato valido");
                    break;
            }
        }
        static void compra1(double comp,int val)
        {
            double valor1 = comp * val / 100;
        }
    }
}
