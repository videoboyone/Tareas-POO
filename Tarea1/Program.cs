using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFracciones
{

    class Fraccion
    {
        //Atributos
        private int numerador, denominador;

        //Metodos
        public Fraccion(int numerador, int denominador)
        {
            this.denominador = denominador;
            this.numerador = numerador;
        }
        //Sobrecarga del metodo Fraccion
        public Fraccion()
        {
            numerador = 1;
            denominador = 1;
        }

        //Metodo de tipo constructor, utilizando un operador para realizar una suma de fracciones
        public static Fraccion operator +(Fraccion x, Fraccion y)
        {

            Fraccion sum = new Fraccion (x.numerador * y.denominador + x.denominador * y.numerador, x.denominador * y.denominador);
            return sum;
           
        }

        //Metodo para realizar la resta
        public static Fraccion operator -(Fraccion x, Fraccion y)
        {
            Fraccion resta = new Fraccion(x.numerador * y.denominador - x.denominador * y.numerador, x.denominador * y.denominador);
            return resta;
        }

        //metodo para la multiplicacion
        public static Fraccion operator *(Fraccion x, Fraccion y)
        {
            Fraccion multi = new Fraccion(x.numerador * y.numerador, x.denominador * y.denominador);
            return multi;
        }

        //Metodo para la impresion de la fraccion
        public void Imprime()
        {
            Console.WriteLine("{0}/{1}", numerador, denominador);
        }

      

        //Retorno de valor en decimal
        public decimal a_decimal()
        {
            return numerador/ denominador;
        }


    }


    class Program
    {
        static void Main(string[] args)
        {

            //constructores para las fracciones
            Fraccion a = new Fraccion(1,2);
            Fraccion b = new Fraccion(3,5);
            Fraccion sum;
            Fraccion res;
            Fraccion multi;

             a.Imprime();
            b.Imprime();

            sum=a+b;
            sum.Imprime();

            res=a-b;
            res.Imprime();

            multi=a*b;
            multi.Imprime();
                      
            
           
            Console.ReadKey();
        }

    }
}
