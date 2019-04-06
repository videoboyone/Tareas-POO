using System;
using System.Collections.Generic;

namespace Tarea4
{

    //**********Para la parte 1 de la Tarea 4**********
    class A

    {

    public int a;

    public A()

        {

        a = 10;

        }

    public virtual string Display()

      {

      return a.ToString();

      }

    }

class B:A

   {
     public int b;

        public B():base()

         {

         b = 15;

         }

   //Redefinir metodo Display aqui, debe regresar el campo b como string.
   public override string Display()
   {
       return b.ToString();
   }

   }


   //*********Aqui terminan las clases de la parte 1 de la Tarea 4******


   // *******Inicio de la segunda parte de la Tarea 4*************
   abstract class Musico

    {

    public string nombre;

    public Musico (string n)

        {

         nombre = n;

        }

   

   public  string Display()

      { 

       return nombre;

      }

   }

   interface IMusico
   {
        void Afina();  
   }


class Bajista: Musico,IMusico

  {

    public string i;

    public Bajista (string i, string n ):base(n)
    {
        this.i=i;

    }

     public  void Afina()
        {
            Console.WriteLine("Hola, soy {0}, toco el {1}, y estoy afinando", nombre, i);
        }
      

    
   
 }

class Guitarrista:Musico,IMusico
     {

     public string instrumento;

     public Guitarrista (string instrumento, string n):base(n)
     {
         this.instrumento=instrumento;

     }

        public  void Afina()
        {
            Console.WriteLine("Hola, soy {0}, toco la {1}, y estoy afinando", nombre, instrumento);
        }
      

 

     }


    class Program
    {
        static void Main(string[] args)
        {
            // ****Esto es de la parte 1 ****
           A objA = new A();

            B objB = new B();

         Console.WriteLine(objA.Display()); ////  (1 )

         Console. WriteLine(objB.Display()); ////  ( 2)



         // ***** Aqui empieza la parte 2 ******
    

            Bajista b = new Bajista("Bajo","Flea");

            Guitarrista g = new Guitarrista("Guitarra","Santana");

            Musico [] m = new Musico[10];

             m[0] = b;

            m[1] = g;

 

            foreach ( Musico mus in m)
            {
                (mus as IMusico).Afina();
            }

 

         Console.ReadKey();
        }
    }
}
