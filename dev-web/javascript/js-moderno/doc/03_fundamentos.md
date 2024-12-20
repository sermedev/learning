# Fundamentos de JavaScript, primitivos, arreglos, obtejos y funciones básicas

- [Fundamentos de JavaScript, primitivos, arreglos, obtejos y funciones básicas](#fundamentos-de-javascript-primitivos-arreglos-obtejos-y-funciones-básicas)
  - [¿Qué son los primitivos?](#qué-son-los-primitivos)
  - [Palabras reservadas](#palabras-reservadas)
    - [Palabras reservadas](#palabras-reservadas-1)
    - [Palabras reservadas en un futuro](#palabras-reservadas-en-un-futuro)
    - [Evitar usar](#evitar-usar)
  - [Arreglos](#arreglos)
  - [Objetos literales](#objetos-literales)
  - [Funciones básicas](#funciones-básicas)
  - [Funciones de flecha](#funciones-de-flecha)
  - [Retorno de las funciones](#retorno-de-las-funciones)


## ¿Qué son los primitivos?

Es una información que no es objeto y son inmutables.
- **String** - Una cadena de caracteres, ej: Palabras, nombre de personas
- **Boolean** - true/false :: Verdadero y Falso. JavaScript es *case sensitive*
- **Number** - integers, floats, etc. En JavaScript sólo tenemos un tipo de número
- **Undefined** - Una variable declarada que aún no se le asigna valor
- **Null** - Sin valor en lo absoluto
- **Symbol** - Es un valor único que no es igual a ningún otro valor


## Palabras reservadas

[JavaScript variable name validator](https://mothereff.in/js-variables#%E0%B2%A0%5f%E0%B2%A0)

[Valid JavaScript variable names](https://mathiasbynens.be/notes/javascript-identifiers)


### Palabras reservadas
- break
- export
- super
- case
- extends
- switch
- catch
- finally
- this
- class
- for
- throw
- const
- function
- try
- continue
- if
- typeof
- debugger
- import
- var
- default
- in 
- void
- delete 
- instanceof
- while
- do 
- new
- with
- else
- return
- yield
- let
  
### Palabras reservadas en un futuro
- enum
- package 
- public
- implements
- private
- static
- interface
- protected
- await

### Evitar usar
- null
- undefined
- true
- false
- hasOwnProperty
- undefined
- isNaN
- Infinity
- isFinite
- NaN
- length
- Math
- isPrototypeOf
- prototype
- valueOf
- name
- Number
- Object
- String
- toString
- prompt
- alert
- conform

## Arreglos

Los arreglos en JavaScript son estructuras de datos que nos permiten almacenar y manipular colecciones de elementos. Aquí tienes algunos puntos clave sobre los arreglos:

1. Definición:
   - Un arreglo es una colección ordenada de elementos.
   - Puede contener elementos de diferentes tipos de datos (números, cadenas, objetos, etc.).
   - Los arreglos en JavaScript comienzan con el índice 0.
   - Por ejemplo:
  
    ```javascript
    const miArreglo = [2.5, false, 6, "Hola"];
    ```

2. Creación de Arreglos:
    - Puedes crear un arreglo asignando valores a una variable:
    ```javascript
    const miArreglo = ["manzana", "banana", "pera"];
    ```
    - También puedes usar el constructor de Array:
    ```javascript
    const otroArreglo = new Array(1, 2, 3);
    ```

3. Acceso a Elementos
   - Puedes acceder a un elemento por su índice:
   ```javascript
   const primerElemento = miArreglo[0]; // "manzana"
   ```

4. Longitud del Arreglo:
    - La longitud de un arreglo se obtiene con la propiedad length:
    ```javascript
    const longitud = miArreglo.length; // 3
    ```

5. Métodos de Arreglos:
   - JavaScript proporciona varios métodos para trabajar con arreglos:
        - `push()`: Agrega un elemento al final del arreglo.
        - `pop()`: Elimina el último elemento del arreglo.
        - `shift()`: Elimina el primer elemento del arreglo.
        - `unshift()`: Agrega un elemento al principio del arreglo.
        - `splice()`: Permite agregar, eliminar o reemplazar elementos en posiciones específicas.
        - Y muchos más.
  
6. Longitud Variable:
    - A diferencia de algunos lenguajes, los arreglos en JavaScript no tienen longitud fija.
    - Puedes cambiar la longitud asignando un valor numérico positivo:
     ```javascript
     miArreglo.length = 5; // Ahora tiene 5 elementos
     ```
       

## Objetos literales

Los objetos literales en JavaScript son una forma de crear y organizar datos de manera explícita.

1. ¿Qué es un objeto literal?
    - Un objeto literal es una colección de pares clave-valor que representan propiedades y sus valores asociados1.
    - A diferencia de otros objetos, los objetos literales declaran sus propiedades de manera explícita.
    - Estos objetos agrupan información de la propiedad de manera textual.
  
2. Ejemplo de creación de un objeto literal:
    - Puedes definir un objeto literal utilizando llaves {} y especificando las propiedades y sus valores dentro de ellas.
    - Aquí tienes un ejemplo:
    ```javascript
        const miCoche = {
        marca: "Ford",
        modelo: "Mustang",
        año: 1969
        };
    ```
    En este caso, `miCoche` es un objeto con tres propiedades: `marca`, `modelo` y `año`

3. Acceso a las propiedades:
    - Puedes acceder a las propiedades de un objeto utilizando la notación de puntos (objeto.propiedad) o la notación de corchetes (objeto['propiedad']).
    - Por ejemplo:
    ```javascript
    console.log(miCoche.marca); // Imprime "Ford"
    console.log(miCoche['modelo']); // Imprime "Mustang"
    ```
4. Creación de objetos literales vs. otros métodos:
    - Los objetos literales funcionan bien si deseas crear un sólo objeto.
    - Si necesitas crear múltiples objetos con las mismas propiedades y métodos, puedes considerar otras formas, como el uso de clases o constructores de objetos.

En resumen, los objetos literales son una herramienta poderosa en JavaScript para organizar y manipular datos de manera clara y concisa.


## Funciones básicas

Las **funciones** son uno de los conceptos fundamentales en JavaScript. 

1. **Definición de funciones**:
    - Una función en JavaScript es similar a un procedimiento. Es un conjunto de instrucciones que realiza una tarea o calcula un valor.
    - Para que una función califique como tal, debe tomar **alguna entrada** (parámetros) y **devolver una salida** (resultado).
    - Puedes definir funciones de dos maneras principales: 
      1. **Declaración de función**:
            ```javascript
            function square(number) {
                return number * number;
            }
            ```
        En este ejemplo, `square` es una función que toma un parámetro llamado `number` y devuelve su cuadrado. 

      2.  **Expresión de función:** Puedes crear funciones anónimas utilizando expresiones:
            ```javascript
            const square = function(number) {
                return number * number;
            };
            ```

2. **Parámetros y valores de retorno:**
    - Los parámetros son los valores que pasas a una función cuando la llamas.
    - El valor de retorno es lo que la función devuelve después de procesar los parámetros.
Por ejemplo, en la función square, el parámetro number se multiplica por sí mismo y se devuelve como resultado.

1. **Ámbito de ejecución y pila de funciones:**
    - Las funciones tienen su propio ámbito de ejecución. Las variables declaradas dentro de una función no son accesibles fuera de ella.
    - Las funciones pueden llamarse a sí mismas o a otras funciones, creando una pila de funciones en ejecución.
  
2. **Funciones anidadas y cierres:**
    - Puedes definir funciones dentro de otras funciones (funciones anidadas).
    - Los cierres (closures) son funciones que “recuerdan” su entorno léxico incluso después de que la función exterior haya terminado de ejecutarse.

En resumen, las funciones son bloques de código reutilizables que te permiten organizar y modular tu código en JavaScript. 

## Funciones de flecha

Las funciones de flecha (también conocidas como arrow functions) son una característica introducida en ECMAScript 6 (ES6) que permite declarar funciones de forma más concisa y legible en JavaScript. Aquí tienes los aspectos básicos:

1. **Sintaxis de las funciones de flecha:**
   - La sintaxis de una función de flecha es la siguiente:
    ```javascript
    let func = (arg1, arg2, ..., argN) => expression;
    ```
    Esto crea una función llamada `func` que acepta los parámetros `arg1` a `argN`, evalúa la expresión del lado derecho y devuelve su resultado.
2. **Ejemplos**:
    - Función de suma:
        ```javascript
        let sum = (a, b) => a + b;
        alert(sum(1, 2)); // Resultado: 3
        ```
        En este ejemplo, `(a, b) => a + b` representa una función que toma dos argumentos (`a` y `b`) y devuelve la suma de ambos.
    - Función para duplicar un número:
        ```javascript
        let double = n => n * 2;
        alert(double(3)); // Resultado: 6
        ```
        Aquí, `n => n * 2` es una función que acepta un solo argumento (`n`) y devuelve el doble de ese número.
3. **Ventajas de las funciones de flecha:**
    - Sintaxis más breve: Las funciones de flecha son ideales para acciones simples de una línea.
    - No requieren la palabra clave `function` ni las llaves `{}` si la expresión es única.
    - El valor de retorno se infiere automáticamente.
4. **Funciones de flecha multilínea:**
    - Si necesitas una función más compleja con múltiples expresiones o sentencias, puedes usar llaves `{}` para encerrar el cuerpo de la función.
    - En este caso, debes usar la palabra clave `return` explícitamente
        ```javascript
        let complexFunction = (a, b) => {
            let result = a + b;
            return result;
        };
        ```
En resumen, las funciones de flecha son una herramienta poderosa para escribir código más limpio y conciso en JavaScript. Aunque pueden parecer extrañas al principio, rápidamente te acostumbrarás a su estructura.

[MDN Funciones flecha](https://developer.mozilla.org/es/docs/Web/JavaScript/Reference/Functions/Arrow_functions)


## Retorno de las funciones

1. **¿Qué son los valores de retorno?**
    - Los valores de retorno son los valores que una función devuelve cuando se completa su ejecución.
    - Imagina que una función es como una “caja negra” que toma ciertos datos de entrada (parámetros) y produce un resultado específico.
    - El valor de retorno es ese resultado que la función proporciona al final.

2. **Ejemplo con la función** `replace()`:
    - Consideremos el siguiente código:
        ```javascript
        const myText = "I am a string";
        const newString = myText.replace("string", "sausage");
        console.log(newString);
        ```
    - Aquí, estamos utilizando la función `replace()` en la cadena `myText`.
    - La función toma dos parámetros: la subcadena a encontrar (“string”) y la subcadena con la que reemplazarla (“sausage”).
    - Cuando la función `replace()` se completa, devuelve un valor, que en este caso es una nueva cadena con el reemplazo realizado.

3. **Funciones con retorno personalizadas:**
    - Puedes crear tus propias funciones que devuelvan valores útiles.
    - Por ejemplo:
        ```javascript
        function sumar(a, b) {
        return a + b;
        }
        const resultado = sumar(2, 3); // Devuelve 5
        ```
    - La función `sumar` toma dos argumentos (`a` y `b`) y devuelve la suma de ambos.
    - Guardamos el valor de retorno en la variable `resultado`.

4. **Uso de valores de retorno:**
    - Los valores de retorno son útiles cuando una función es un paso intermedio en un cálculo más grande.
    - Queremos llegar a un resultado final que involucra varios valores.
    - La función calcula esos valores y los devuelve para su uso en la siguiente etapa del cálculo.

En resumen, el retorno de las funciones en JavaScript nos permite obtener resultados específicos y utilizarlos en nuestro código.

