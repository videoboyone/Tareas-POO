# Tarea #1
==========

## Concepto de paradigma
Dependiendo de la disciplina de la que estemos hablando, el significado de paradigma puede ir variando, sin embargo, pondré un concepto en general, y luego me concentrare en la programación.
**Significado general.-**   en griego, significaba modelo o ejemplo, y ahora lo asociamos con un conjunto de diferentes creencias, procedimientos y filosofías que dictan el desarrollo de un trabajo, disciplina o proyecto, nos dicen cómo llevar a cabo las tareas de una manera que el resultado sea el óptimo (mas rápido, entendible, estético, entre otras características).
**Significado en la programacón.-**   similarmente, es una manera de estructurar un programa, nos permiten utilizar diferentes herramientas para resolver los problemas que se nos presentan. Cada paradigma ofrece una diferente sintaxis por la cuál regirnos.
Existen varios tipos de paradigmas en la programación, entre los más utilizados se encuentran: el imperativo, funcional, lógico y el orientado a objetos.

## Concepto de abstracción
Es un proceso de separación o de extracción, donde se segregan aquellos elementos necesarios para poder describir a algo. Por este proceso, podemos identificar las características escenciales de un objeto y también su comportamiento. Los elementos que decidimos no son requeridos para nuestro trabajo son descartados.
**Ejemplo 1 de abstracción.-**   objeto avión, atributos:
1. color
2. tipo
3. modelo
4. marca
5. año
metodos:
1. cambio_velocidad
2. avionica

**Ejemplo 2 de abstracción.-**    objeto refrigerador, atributos
1. luces
2. sistema_enfriamiento
3. congelador
4. color
5. tamaño
metodos:
1. congelar
2. refrigerar
3. encender_luz

## Por qué decimos que la clase es el mecanísmo de abstracción de la POO?
En la POO, una clase nos sirve para definir los atributos de los objetos que se encuentran dentro de ella, es decir, una clase es una colección de objetos que cooperan entre sí, estos objetos comparten las mismas propiedades que son definidas por la clase. Por lo tanto, la clase nos ayuda a abstraer los elementos necesarios y plasmarlos en nuestro código, para que todos los objetos que esten ahí tengan solamente los atributos necesarios.

## Encapsulamiento
Primero que nada, debemos saber que el concepto de encapsulamiento podemos tomarlo de dos diferentes maneras que se explican a continuación.
1. El primer concepto tiene que ver con la abstracción. Se refiere a la habilidad que tenemos para agrupar los diferentes elementos y atributos en un entorno definido, por esto, también se le llama encapsulación abstracta.
2. El segundo concepto tambien se conoce como __ocultamiento.__ Esto refiere a mantener ocultos los elementos que el usuario no necesita o no le importa saber, para que pueda tener una experiencia más comprensible. Esto ofrece varias ventajas, por ejemplo, nos aseguramos de que el usuario sea controlado por nuestras limitaciones, para que no realice intervenciones no deseadas en nuestro código. Otra ventaja sería que puedes hacer mejoras a tu código sin afectar como lo utilicen.

![Encapsulación](http://www.adnradio.cl/images_remote/374/3740380_n_vir3.jpg?u=211217 "Ejemplo donde el ocultamiento se hace correctamente")
![No Encapsulación](https://lorrieporter.files.wordpress.com/2012/10/taking-character-apart.jpg "Ejemplo donde no hay ocultamiento")

## Herencia
La herencia es uno de los conceptos fundamentales de la programación OO. Se refiere a la habilidad de traspasar los atributos y métodos de una clase a otra. Es útil al momento de que necesitemos una clase similiar a otra, pero que se requieran de atributos adicionales. Por ejemplo: si se tiene una clase automóvil, tendra ciertas características, como podrían ser el color, tamaño, etc. Pero también podemos fabricar una clase llamada camioneta, entonces, la camioneta es un tipo de auto, por lo tanto se podrían heredar los atributos que ya hicimos en automóvil, mientras agregamos otros especiales solamente para la camioneta.

![Automóvil](https://s1.thingpic.com/images/c9/Wv3kbUhJyzVQwNPsGhy15QUX.jpeg "Aquí se ilustra la clase automóvil" )
![Camioneta](https://nationalcarparts.co.nz/wp-content/uploads/2016/08/body-parts-977685.jpg "Y aquí la camioneta, notese que hay partes compartidas, pero otras se agregan")
