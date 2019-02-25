# Tarea 2, resumen

## 2.1 Declaración de clases: atributos, métodos, encapsulamiento. 
 Las dos estructuras de datos más importantes en un framework de .NET son las *class* y las tipo *struct*. Las dos son similares en el hecho de que son una construcción de datos que va a encapsular información y comportamientos como una unidad lógica. Entre los más importantes se encuentran los métodos, atributos, propiedades y eventos.
 Cuándo se define la clase o la estructura, toda información dentro de ella se considera un tipo de dato con el mismo nombre (es un objeto o instancia de esa clase o estructura). 
 * Una clase, entonces, es un tipo de referencia, los objetos dentro de una solo contienen una dirección a la memoria donde está la clase.
 * Por otro lado la estructura es un tipo de valor, la variable que ese asigna a la estructura contiene los datos reales de ella misma.

 Las clases se utilizan para un modelado complejo o datos que se prevén modificar después de ser creados sus objetos, y las estructuras son para cantidades de datos pequeñas que no se tiene previsto modificar.
 * Objeto: Un objeto (también llamado instancia de una clase) es una entidad concreta basada en una clase, se construyen con un operador *new* seguido del nombre de la clase
 * Clase: es un tipo de referencia, contendrá los atributos y métodos para objetos que sean declarados del tipo de esa clase

 ### Herencia
 Este es un concepto que se permite en las clases pero no en las estructuras. En esencia, es una clase que deriva de otra clase, que contiene todos los atributos y métodos de la clase original(excepto constructores y finalizadores)

 ### Tipos de clases
 * Genéricos: Pueden definirse con varios parámetros de tipo. El código de cliente proporciona el tipo cuando crea una instancia del tipo.
 * Estáticos: Las clases se pueden declarar de tipo static, que solo contiene miembros estáticos y no se pueden crear con la palabra clave *new*.
 * Anidadas: Las clases y estructuras se pueden crear dentro de otras, creando un anidamiento.

 ## 2.2 Instanciación de una clase

 ### Operador **New**
 Esta palabra clave se utiliza para crear nuevos objetos e invocar constructores, ejemplo:

     Class1 obj  = new Class1();
El bloque de código anterior está creando un objeto (obj) de una clase determinada (Class1), por sintaxis el constructor termina con los paréntesis (), dónde se pueden poner parámetros si fuera necesario, seguido por punto y coma.

También se usa para crear instancias de un tipo anónimo, y para invocar el constructor default para los datos de valor, como por ejemplo:

    int i = new int();
Aquí se esta inicializando una nueva variable de tipo interger (int). La variable en este caso es *i*. Este bloque de código es lo mismo que hacer lo siguiente:

    int i = 0;
Cabe recalcar que el operador *new* **NO** puede ser sobrecargado.

## 2.3 Referencia al objeto actual
### Escribe un programa donde utilices this para obtener acceso a miembros con el fin de evitar ambigüedades con nombres similares.

    class Alumno
    {
        //Atributos de la clase ejemplo
        private string nombre;
        private int edad;

        //Aquí se utilizará la palabra clave this en un constructor para evitar ambigüedad (los datos se hacen propiedad)
        public Alumno(string nombre, int edad)
        {
            this.nombre=nombre;
            this.edad=edad;

        }
En este ejemplo debemos de notar que declaramos los parámetros `string` nombre e `int` edad, en la clase alumno, pero más abajo, hicimos un constructor que también ocupaba de esos parámetros, así que para evitar confusiones con la computadora usamos la palabra clave `this` dentro del constructor. Esto significa que `this.nombre` es el atributo nombre que esta **dentro** del constructor, y el que no tiene la palabra reservada, señala al que esta declarado en la clase.
Este ejemplo esta hecho en el archivo **Program.cs** que viene incluido en el trabajo.

### Escribe un programa donde se utilice this como parámetro.
  Ir a **Program.cs** para ver el programa.
Nota: me base principalmente en  [este](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/this)  código para hacer el programa.

## 2.4  Métodos: declaración, mensajes, paso de parámetros, retorno de valores.

### Parámetros de métodos
Los parámetros declarados para métodos sin *in*, *ref* o *out* se pasan a un método llamado por valor, que se puede cambiar dentro del método. Todos los cambios se pierden cuándo se devuelve el control a la función que mandó a llamar al parámetro. Las siguientes son palabras clave que declarar parámetros de métodos:
1. params: toma un número variable de argumentos, aunque no es necesario mandar argumentos. Si es que se llegaran a usar, se pueden mandar por medio de una lista separada por comas o una matriz de un tipo de argumento determinado (debe ser unidimensional). No se permiten parámetros adicionales después de la palabra clave *params*.
2. in: Aquí los argumentos pasan por referencia. No se pueden modificar los argumentos. Las variables que se pasan como argumentos deben estar inicializadas para comenzar. se puede sobrecargar.
3. ref: Valor pasado por referencia. Se usa en la firma y llamada de un método, para pasar argumentos o para devolver un valor de la llamada por la referencia. También para declarar una *ref struct* o *ref readonly struck*. Como vamos a pasar el valor por medio de una referencia, las modificaciones que hagamos en el argumento se va a reflejar en el lugar desde donde lo llamamos. Se  deben de inicializar los valores antes de llamarlos.
4. out: También hace que los argumentos pasen por referencia. A diferencia de *ref*, aquí no se necesita inicializar el valor antes de usarlo. A diferencia del *in* si se pueden modificar los valores de los argumentos por medio del método.

## 2.5  Constructores y destructores: declaración, uso y aplicaciones.
### Constructores
Los constructores son métodos que se utilizan dentro de clases y se usan para inicializar un nuevo objeto  de un tipo determinado. Los constructores utilizan el mismo nombre de la clase que los encapsula. Para un ejemplo de constructor, ir a program.cs, línea 52.
Un constructor predeterminado es aquel que no toma parámetros. En caso de que una clase no tenga un constructor, se le asigna un constructor público mediante el compilador de C#.
Los constructores de un tipo *struct* son similares, pero no puede haber uno explícito, ya que el compilador proporciona uno con valores predeterminados.
Cualquier constructor puede ser marcado como `public`, `private`, `protected`, `internal` o `protectedinternal`, y definen como el usuario puede construir una clase. También se puede declarar de la manera `static` y se le de prioridad ante cualquier campo estático y se usan para instanciar miembros de una clase estática.

## Sobrecarga de operadores: Concepto y utilidad, operadores unarios y binarios.
Implementar una clase llamada dado, que es una abstracción de cualquier juego, con por lo menos las siguientes propiedades: valor y color.
Debe haber dos constructores sobrecargados, Los operadores < ,  >, ==, sobrecargados, el uso de la palabra clave *this*.
Utilizar el método main del programa para crear tres dados, arrojandolos e imprimiendo el mejor de ellos, o si alguno es igual.

    

