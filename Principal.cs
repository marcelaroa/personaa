using System;
using LibreriaClase;

namespace Libreria{

    class Principal{
        static void Main(){
            Persona p1 = new Persona("Diego", "1-1-1", 12345);
            Persona p2 = new Persona("Juan", "2-1-1", 98765); 

            Console.WriteLine(p1.caminar());
            p1.mostrarPersona();
            p2.mostrarPersona();

            Alumno a1 = new Alumno;
            a1.mostrarPersona();
        }
    }
}