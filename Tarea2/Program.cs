using System;

namespace Tarea2
{

    class Alumno
    {
        //Atributos de la clase ejemplo
        private string nombre;
        private int edad;
        private decimal calificacion=90;

        //Aquí se utilizará la palabra clave this en un constructor para evitar ambigüedad (los datos se hacen propiedad)
        public Alumno(string nombre, int edad)
        {
            this.nombre=nombre;
            this.edad=edad;

        }

        //Método de impresion
        public void Imprime()
        {
            Console.WriteLine("Nombre: {0} \n Edad: {1}", nombre, edad);
            //Aquí se utiliza el this para pasar el objeto
            Console.WriteLine("Calificación: {0}", Puntos.Puntos_ex(this));
        }

        //retorno del valor calificacion
        public decimal Calificacion
        {
            get{return calificacion;}

        }

             

    }

    class Puntos
    {
        public static decimal Puntos_ex(Alumno Dan)
        {
            return 10 + Dan.Calificacion; 
        }
    }




    //Clase Dado para el punto 2.7
    class Dado
    {
        //Atributos del dado
        public string color;
        public int valor;

        //Métodos
        public Dado(string color, int valor)
        {
            this.color=color;
            this.valor=valor;
        }

        //Impresión
        public void Imprime()
        {
            Console.WriteLine("Valor del dado: {0} \n Color del dado: {1}", valor,color);


        }

        public string Imprime(string n)
        {
            return "hecho por Daniel"+n;

        }

        //Sobrecarga de operadores relacionales, utilizando el estado del dato booleano que va a regresar

        public static bool operator ==(Dado a, Dado b)
        {
           return a.valor==b.valor;
        }

        public static bool operator !=(Dado a, Dado b)
        {
        return a.valor!=b.valor;
        
        }

        public static bool operator <(Dado a, Dado b)
        {
        return a.valor<b.valor;
        }

        public static bool operator>(Dado a, Dado b)
        {
            return a.valor>b.valor;
     
        }

        
    }




    class Program
    {
        static void Main(string[] args)
        {
            //Creación de alumno
            Alumno Daniel=new Alumno("Daniel",19);

            //Se imprime el resultado
            Daniel.Imprime();



            //Creación de objetos del tipo dado para el punto 2.7
            Dado uno=new Dado("rojo",4);
            Dado dos=new Dado("azul",1);
            Dado tres=new Dado("blanco",6);

           if(uno.valor==dos.valor && uno.valor==tres.valor)
           {
               uno.Imprime();

           }
           else if(uno.valor>dos.valor && uno.valor>tres.valor)
           {
               uno.Imprime();

           }
           else if (dos.valor>uno.valor && dos.valor>tres.valor)
           {
               dos.Imprime();
           }
           else if (tres.valor>uno.valor && tres.valor>dos.valor)
           {
               tres.Imprime();

           }
           
           
            



        }
    }
}
