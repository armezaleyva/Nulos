using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nulos {
    class Program {
        static void Main(string[] args) {
            Carro miCarro = new Carro();
            miCarro.Marca = "Tsuru";
            miCarro.Kilometraje = 100000;

            Console.WriteLine("Marca: " + miCarro.Marca);
            Console.WriteLine("Km: " + miCarro.Kilometraje);

            miCarro.Due�oCarro = new Due�o();
            miCarro.Due�oCarro.Nombre = "Pedro";
            miCarro.Due�oCarro = null;

            if (miCarro.Due�oCarro != null) {
                Console.WriteLine("Due�o: " + miCarro.Due�oCarro.Nombre);
            } else {
                Console.WriteLine("No se encontr� due�o");
            }
            
            Console.ReadKey();
        }
    }
}
