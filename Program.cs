using System;

namespace ejer2
{
    class Program
    {
        static void Main(string[] args)

        {

            int publico=0, privado=0, cantidadAlumnos=0;
            string colegio="e";
            float porcentajePublico=0f;
            float porcentajePrivado=0f;


            Console.WriteLine("SISTEMA DE ALUMNOS PUBLICOS Y PRIVADOS");

            while (colegio=="e" || colegio=="E" || colegio=="p" || colegio=="P"){
                Console.WriteLine("Ingrese E para alumno publico; ingrese P para privado, x salir");
                colegio=Console.ReadLine();
                Console.Clear();

                if(colegio =="e" || colegio=="E"){
                        cantidadAlumnos=cantidadAlumnos+1;
                        publico=publico+1;
                }
                if(colegio== "p" || colegio =="P"){

                    cantidadAlumnos=cantidadAlumnos+1;
                    privado=privado+1;

                }
                if(colegio=="X" || colegio=="x"){
                    Console.WriteLine("Saliendo del sistema ....");
                    Console.ReadKey();
                    colegio="salir";
                } 
                else if(colegio=="salir"){
                    Console.WriteLine("Debe ingresar una opcion validad: E, P , X");
                    Console.WriteLine("Ingrese E para alumno publico; ingrese P para privado, x salir");
                    colegio=Console.ReadLine();

                }


            }
            Console.Clear();

            porcentajePrivado=(privado*100)/cantidadAlumnos;
            porcentajePublico=(publico*100)/cantidadAlumnos;

            Console.WriteLine("SISTEMA DE ALUMNOS PUBLICOS Y PRIVADOS");
            Console.WriteLine("Cantidad de Alumnos: " + " " + cantidadAlumnos);
            Console.WriteLine("Cantidad de Privados: " + " " + privado);
            Console.WriteLine("Cantidad de Publicos: " + " " + publico);
            Console.WriteLine("Porcentaje de Publicos: " + " " + porcentajePublico + " %");
            Console.WriteLine("Porcentaje de Privados: " + " " + porcentajePrivado + " %");


        }
    }
}
