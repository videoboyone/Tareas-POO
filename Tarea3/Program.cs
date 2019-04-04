using System;
using System.Collections.Generic;

namespace Tarea3
{
    class Vector
    {
        int x;
        int y;

        //Constructor
        public Vector(int x, int y)
        {
                this.x=x;
                this.y=y;
        }

        //Redefiniendo el metodo de String, para que al momento de correr no salga el nombre de la clase
        public override string ToString()
        {
            return String.Format("{0},{1}", x,y);
        }
    }
     class Figura
    {
        protected string fill, border;
        protected Vector posicion;

        //Constructor

        
        public Figura(string fill, string border, Vector posicion)
        {
            this.fill=fill;
            this.border=border;
            this.posicion=new Vector(200,100);
        }
        //Sobrecargado del constructor 
        public Figura()
        {
            
        }

        
        

        //Metodo para dibujar

        public virtual void dibujar()
        {
            Console.WriteLine("Se dibuja una figura en {0}, de relleno {1} y contorno {2}",posicion, fill, border);
        }
    }

    //Se crea una clase hija de Figura
    class Circulo:Figura
    {
        int radio;

        /* Constructor, donde se usa la palabra clave "Base", la cual se utiliza para poder utilizar las propiedades
        presentes en la clase base, y mandarlas a llamar a esta clase*/
        public Circulo(int radio,Vector posicion, string fill, string border):base(fill, border, posicion)
        {
            this.radio=radio;
        }

        

        //Sobrecargo el metodo de dibujar para que indique que se dibuja un circulo
        public override void dibujar()
        {
            Console.WriteLine("Se dibuja un círculo en {0}, de relleno {1} y contorno {2}",posicion, fill, border);
        }
    }

    //Clase Rectangulo con todos sus atributos
    class Rectangulo:Figura
    {
        public Rectangulo(string fill, string border, Vector posicion):base(fill, border, posicion)
        {

        }

 
    }
    class Program
    {
        static void Main(string[] args)
        {

            //Se crea una lista de figuras
            List<Figura>figuras=new List<Figura>();

            figuras.Add(new Circulo(5,new Vector(200,100),"Verde","Rojo"));
            figuras.Add(new Rectangulo("Negro","Gris",new Vector(500,300)));
            figuras.Add(new Rectangulo("Morado","Negro",new Vector(1000,1000)));

            //Se crea ciclo para imprimir las figuras en la lista
            foreach (Figura f in figuras)
            {
                f.dibujar();
            }
        }
    }
}
