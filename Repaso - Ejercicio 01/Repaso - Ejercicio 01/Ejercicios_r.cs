using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso___Ejercicio_01
{
    internal class Ejercicios_r
    {
        public void G1E01_r()
        {
            //Declaro variables
            int ultimos_tres_digitos;
            int contador = 0;
            string resultado = "";

            //Pido al usuario que ingrese sus últimos tres dígitos del registro
            Console.WriteLine("Ingrese sus últimos tres números del registro");
            ultimos_tres_digitos = Convert.ToInt32(Console.ReadLine());

            //Validación por si los ultimos tres dígitos son menores a 100
            if(ultimos_tres_digitos < 100)
            {
                ultimos_tres_digitos = ultimos_tres_digitos + 100;
            }

            //Bucle para mostrar en pantalla todos los números hasta llegar al´número ingresado por el user
            while (contador != ultimos_tres_digitos)
            {
                contador++;

                if(contador % 3 == 0 && contador % 5 != 0)
                {
                    resultado = contador.ToString() + " - " + " Foo";
                }
                else if(contador % 5 == 0 && contador % 3 != 0)
                {
                    resultado = contador.ToString() + " - " + " Bar";
                }
                else if(contador % 3 == 0 && contador % 5 == 0)
                {
                    resultado = contador.ToString() + " - " + " FooBar";
                }
                else
                {
                    resultado = contador.ToString();
                }

                Console.WriteLine(resultado);
                

            }

        }
    }
}
