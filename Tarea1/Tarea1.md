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

![Encapsulación](./img/Encapsulacion1 "Ejemplo donde el ocultamiento se hace correctamente")
![No Encapsulación](./img/Encapsulacion2 "Ejemplo donde no hay ocultamiento")

## Herencia
La herencia es uno de los conceptos fundamentales de la programación OO. Se refiere a la habilidad de traspasar los atributos y métodos de una clase a otra. Es útil al momento de que necesitemos una clase similiar a otra, pero que se requieran de atributos adicionales. Por ejemplo: si se tiene una clase automóvil, tendra ciertas características, como podrían ser el color, tamaño, etc. Pero también podemos fabricar una clase llamada camioneta, entonces, la camioneta es un tipo de auto, por lo tanto se podrían heredar los atributos que ya hicimos en automóvil, mientras agregamos otros especiales solamente para la camioneta.

![Automóvil](./img/Herencia1 "Aquí se ilustra la clase automóvil" )
![Camioneta](./img/Herencia2 "Y aquí la camioneta, notese que hay partes compartidas, pero otras se agregan")

##Lenguaje de modelado unificado
Conocido por sus siglas en inglés UML, es u lenguaje diseñado para planos de software, se utiliza para visualizar, construir y documentar los artefactos que conforman a un sistema. Utiliza una variedad de simbolos, notaciones y diagramas estandar para modelar programas orientados a objetos.
Este lenguaje empezó a gestar en octubre de 1994 cuándo James Rumbaugh se une a la compañía *Rational Software*, donde Grady Booch tambión trabajaba como científico. El objetivo de ellos dos fue unificar los modelos que habían creado previamente: el método Booch y el OMT. El primer borrador surge en 1995. Alrededor de este tiempo, Ivar Jacobson, un reconocido investigador también se unió a Rational, y desde ese punto, los tres colaboradores trabajaron en conjunto para desarrollar el UML, permitiendo que otras empresas contribuyeran a su proyecto.
Algunas herramientas que se utilizan para visualizar en UML son: 
* LucidChart: Esta basado en HTML 5 y se pueden hacer colaboraciones en tiempo real con otras personas, también se puede vincular con Microsoft Visio.
* GenMyModel: Originalmente de UML, pero se ha expandido desde entonces. Es una herramienta de modelaje así que puede ser compatible con archivos .XMI, que es el formato estándar para intercambio de modelos.
* Glyffy: Tiene aspectos cooperativos y de control de versiones, con soporte para todo tipo de diagramas UML
* Draw.io: Versión simple y ligera para hacer diagramas de este lenguaje. Fácil de usar, ya que solo necesitas accesar a su sitio web y no requiere registros ni adquisición de licencia. Se usa bien con Google Drive, Dropbox y Onedrive.
* Creately: Ofrece colaboraciones en tiempo real y ejemplos ya hechos para ayudar a principiantes, se puede trabajar offline, y después integrarlo cuándo se tenga conexión a internet. Requiere Adobe Flash.

**Diagramas de UML**
A continuación, los diagramas más prominentes en el lenguaje de modelado universal:
1. Diagramas de clase.- son la parte fundamental de los sistemas orientados a objetos, describen la estructura estática de ese sistema
2. Diagrama de paquete.- similares a los de clase, organizan elementos de un sistema a grupos relacionados para minimizar dependencias entre paquetes
3. Diagrama de objetos.- describen la estructura estática de un sistema en un momento determinado, se usan para probar diagramas de clase
4. Diagrama de estructura compuesta.- Muestran la parte interna de una clase
5. Diagrama use-case.- Muestran la funcionalidad de un sistema usando casos y actores
6. Diagrama de actividad.- Muestran la parte dinámica de un sistema, enseñando el flujo de actividad a actividad, que resultan en cambios al sistema
7. Diagrama de secuencias.- Describen actividades entre clases, via mensajes
 ![Clases](./img/Diagrama "Un ejemplo de diagrama de clases" )

##Propuesta de una máquina vendedora
La siguiente será una maquina expendedora de dispositivos moviles. El usuario al introducir una cierta cantidad de dinero, seleccionar su artículo deseado, y aparte deja al usuario elegir un plan de cobertura en su nuevo dispositivo. Basicamente actuará como un centro de atención de telefonía, pero automatizado.

![Diagrama_practica](./img/Diagrama2)