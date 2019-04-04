#Tarea 3 Herencia

##3.1: Herencia, clase base y derivada.

### Qué es la herencia?
Una herencia es un concepto relacionado a las clases en la programación orientada a objetos. Se le dice así cuándo una se crea una clase nueva a partir de otra ya existente. Proviene del hecho de que las clases nuevas que hereden de otra, van a tener las propiedades y métodos  de su clase madre, teniendo la ventaja de que solo se deberán establecer los atributos generales en una sola clase, y las subsecuentes podrán heredarlas sin tener que volver a escribirlas.

### Qué es una clase madre y una clase derivada?
En la herencia, encontramos dos tipos de clases

*  **Clases madres**: Aquella que va a transmitir su código a las clases hijas (derivadas), es decir, los métodos y propiedades que se hayan puesto en este tipo de clase serán transmitidas a todas las clases derivadas que programemos.

* **Clase derivada**: Aquellas que van a recibir los las características de una clase madre. Cabe notar que en ciertos lenguajes de programación una clase derivada puede tener herencia de múltiples clases madres (en otros como C# esta restringido).

## 3.2 Diagrama UML de la clase figura, rectángulo y círculo.


![Ejemplo](C:\Users\Dell\Documents\GitHub\Tareas-POO\Tarea3\Images\UML.PNG)


Aquí podemos observar una relación de herencia entre la clase Figura, que en este caso es la clase madre, y las clases de círculo y rectángulo, que son las clases derivadas o hijas. Podemos ver que están unidas por una flecha, apuntando hacia la dirección de la clase base, lo cuál indica la relación de herencia. También podemos observar el hecho de que en las clase del círculo, solo se agrega un nuevo atributo *int radio*, y la razón por la cuál esta ahí, es que el radio es una propiedad que tienen los círculos y no todas las figuras.
En la clase base vemos que están la mayoría de los atributos, por lo que ya no hay necesidad de volverlos a escribir en cada una de las clases que heredan de Figura.


![Ejemplo](C:\Users\Dell\Documents\GitHub\Tareas-POO\Tarea3\Images\diagrama.png)


*Ejemplo de una clase madre, con sus clases derivadas.*

## 3.4 Herencia simple y herencia múltiple

* **Herencia simple**: Es el concepto de herencia fundamental y el más simple. Es la relación entre una clase base y otra derivada, como mencionada antes. Aquí debemos de tomar en cuenta que una clase no puede heredar de más de una clase padre. Los ejemplos anteriores han sido de este tipo.

* **Herencia múltiple**: El tipo de herencia que como su nombre indica, una clase derivada tiene permitido heredar de más de una clase base.


![Ejemplo](C:\Users\Dell\Documents\GitHub\Tareas-POO\Tarea3\Images\H01.JPG)


*Ejemplo de una herencia múltiple, dónde la clase hombre hereda tanto de carnívoro como de herbívoro*

###Se puede hacer herencia múltiple en C#?
No esta permitido heredar de varias clases. Existe otra forma para poder implementar métodos en clases, que es con interfaces. Una interfaz contiene ciertos métodos que una *class* o *struct* puede utilizar. A diferencia de otras clases, las interfaces se **implementan**, y en C# si esta permitido implementar de varias interfaces.

## 3.5 Programa de Figuras
*Ver el program.cs*


https://es.ccm.net/contents/411-poo-herencia
http://jbgarcia.webs.uvigo.es/asignaturas/TO/cursilloCpp/15_herencia_simple.html

