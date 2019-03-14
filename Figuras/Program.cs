using System;
using System.Collections.Generic;

namespace Figuras
{
    class Vector2D
    {
        protected int x, y;

        //Constructor de Vector2D
        public Vector2D(int x, int y)
        {
            this.x=x;
            this.y=y;
        }

    }

    class Color
    {

        enum Name{red, blue, white, black, none}
        public int r,g,b;

        private Color.Name colorName;

        //Constructor de Color
        public Color(int r, int g, int b)
        {
            this.r=r;
            this.g=g;
            this.b=b;
        }


        private Color(Color.Name name)
        {
            colorName=name;
            if (name==Color.Name.red)
            {
              r=255;
              g=0;
              b=0;
              
            }
            else if (name==Color.Name.blue)
            {
                r=0;g=0;b=255;
            }
            else if (name==Color.Name.black)
            {
                r=0; g=0; b=0;
            }
            else if (name==Color.Name.white)
            {
                r=255; g=255; b=255;
            }
        }
    }

    

    abstract class Figura
    {
        public Vector2D position;
        public Color fill, border;

        public Figura(Vector2D position, Color fill, Color border)
        {
            this.position=position;
            this.fill=fill;
            this.border=border;
        }

        //Metodo para dibujar
        public abstract void dibuja();


    }


    class Circulo:Figura
    {
        private double radio, area_c;

        public Circulo(Vector2D position, Color fill, Color border, double radio):base(position, fill, border)
        {
            this.radio=radio;
        }

        //Metodo heredado de Figura, de dinuja

        public override void dibuja()
        {
            Console.WriteLine("Se dibuja un circulo en {0}, de relleno {1}, contorno {2}", position, fill, border);

        }  

        
    }

        class Rectangulo:Figura
        {
            public Rectangulo(Vector2D position, Color fill, Color border):base(position,fill, border)
            {
                
            }
           
           public override void dibuja()
           {
               Console.WriteLine("Se crea un rectangulo en {0}, de relleno {1}, y bordes {2}", position, fill, border);
           }
            
        }

        class Triangulo:Figura
        {
            public Triangulo(Vector2D position, Color fill, Color border):base(position, fill, border)
            {

            }

            public override void dibuja()
            {
                Console.WriteLine("Se dibuja un triangulo en {0}, de relleno {1}, y bordes {2}",position,fill, border);
            }
        }



    class Program
    {
        static void Main(string[] args)
        {
            //Se crea lista de figuras
            List<Figura> figuras= new List<Figura>();

            figuras.Add(new Circulo(new Vector2D(100,100),new Color(Color.Name.red), new Color(Color.Name.red),10));

            figuras.Add(new Rectangulo(new Vector2D(300,300),new Color(Color.Name.black),new Color(Color.Name.black)));

            figuras.Add(new Triangulo(new Vector2D(400,400),new Color(Color.Name.blue),new Color(Color.Name.blue)));


            foreach(Figura Figura in figuras)
            {
                Figura.dibuja();

            }
        }
    }
}

