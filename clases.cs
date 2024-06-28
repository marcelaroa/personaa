using System;

namespace LibreriaClase{

    class Persona{

        private string nombre;
        public string Nombre (get; set;)

        private string fechaNacimiento;
        public string FechaNacimiento (get; set;)
        
        private int dni;
        public int Dni (get, set;)

        public Persona(string rnombre, string rfechaNacimiento, int rdni){
            nombre = rnombre;
            fechaNacimiento = rfechaNacimiento;
            dni = rdni;

        }

        public string caminar(){

            return "caminando";
        }

        public void mostrarPersona(){
            Console.WriteLine("nombre: {0}", nombre);
            Console.WriteLine("fecha nacimiendo: {0}", fechaNacimiento);
            Console.WriteLine("DNI: {0}", dni);
        }
    }
    class Alumno : Persona{
        private int legajo;
        private string curso;
        private int[] notas;
        
        public void estucdiar(){
            Console.WriteLine("Estudiando...");
        }
    }
}
