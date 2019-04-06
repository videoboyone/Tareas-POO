# Tarea 4

## 4.1 Qué valores imprimen la línea 1 y 2?
Imrpime a la variable "a" dos veces, ya que en el metodo Display(), la linea de codigo especifica que se debe imprimir a.ToString. B es una clase que hereda de A, e incluye, por lo tanto, el mismo metodo, asi que para que se imprime el valor de B, se debe de hacer un override

### Una vez redefinido el método, ¿qué valores imprimen las lineas (1) y (2)?
Ahora si imprimen los valores de las variables a y b respectivamente. Ya que en el override ya hay una impresión específicamente para la variable b.

### ¿Que palabra debes agregar en la linea (public _______ string Display()) al definir A.Display()?
la palabra clave *virtual*, que es necesaria para hacer el sobrecargado del método en las clases derivadas.


## Parte 2: clase de Musico
### 2.2. Hay un error en uno de los puntos (A)(B)(C)(D). ¿Cuál es y por qué?
Es en el punto D. Esta tratando de instanciar un objeto de una clase abstracta 

###  ¿Qué método se debe implementar obligatoriamente en ambas clases y por qué?
El método de afinar, ya que esta declarado como un método abstracto, que signifíca que, la clase músico no lo debe implementar(ya que sería demasiado generalizado), pero los Bajistas y Guitarristas estan heredando del Músico. Por lo tanto, los métodos abstractos aplican para las clases derivadas, aunque no para la base.

### 2.4. ¿Por qué no se ponen las llaves en (B)?, ¿Cuando si se pondrían?
Es un método abstracto y no aplica para la clase Musico, por que un músico es muy general. Entonces, como ese código está en la clase Musico, pero esa misma no lo utiliza, no hay necesidad de declarar un cuerpo ahí, pero si al momento de implementarlo en las clases hijas.

### 2.5. ¿Qué pasa si el método Afina() lo hacemos virtual en lugar de abstract?
Deberíamos de declararle un cuerpo en la clase Musico, y ese código podrá ser implementado en las clases derivadas (aunque no es obligatorio). Aquí como no hay cuerpo, a fuerza tenemos que hacer override


