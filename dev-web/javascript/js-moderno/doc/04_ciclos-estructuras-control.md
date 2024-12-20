# Ciclos y estructuras de control

- [Ciclos y estructuras de control](#ciclos-y-estructuras-de-control)
  - [Antes de comenzar, opearadores especiales](#antes-de-comenzar-opearadores-especiales)
    - [Rest y Spread](#rest-y-spread)
    - [Operador `==` y `===`](#operador--y-)
  - [Estructuras de control de flujo](#estructuras-de-control-de-flujo)
  - [Paso de variables por valor y por referencia](#paso-de-variables-por-valor-y-por-referencia)
  - [Romper referencia de objetos](#romper-referencia-de-objetos)
  - [If y Else](#if-y-else)
  - [Un poco sobre lógica booleana](#un-poco-sobre-lógica-booleana)
  - [Operadores y operadores de asignación](#operadores-y-operadores-de-asignación)
  - [Operador condicional ternario](#operador-condicional-ternario)
  - [Switch](#switch)
  - [While](#while)
  - [Do While](#do-while)
  - [For](#for)
  - [For in](#for-in)
  - [For of](#for-of)


## Antes de comenzar, opearadores especiales

### Rest y Spread

Los operadores **rest** y **spread** en JavaScript utilizan los mismos tres puntos (`...`), pero tienen diferentes funciones. Permíteme explicarte cada uno:

1. Operador Rest
   - El operador rest se utiliza para agrupar el resto de valores específicos proporcionados por el usuario en un arreglo de JavaScript.
   - Su sintaxis es: `...tusValores`.
   - Solo se puede utilizar antes del último parámetro en la definición de una función.
   - Ejemplo:
       ```javascript
       function miBio(primerNombre, apellido, ...otraInfo) {
       return otraInfo;
       }
       const infoAdicional = miBio("Oluwatobi", "Sofela", "CodeSweetly", "Desarrollo Web", "Hombre");
       // infoAdicional contendrá: ["CodeSweetly", "Desarrollo Web", "Hombre"]
       ```
       En el ejemplo anterior, usamos el parámetro rest ...otraInfo para agrupar los valores adicionales proporcionados por el usuario en un arreglo.

2. Operador Spread:
   - El operador spread se utiliza para expandir los elementos de un iterable (como un arreglo o una cadena) en argumentos individuales.
   - Puede usarse en varios contextos, como al pasar argumentos a una función o al crear un nuevo arreglo.
   - Ejemplo:
       ```javascript
       function miBio(primerNombre, apellido, empresa) {
       return `${primerNombre} ${apellido} dirige ${empresa}`;
       }
       const datos = ["Oluwatobi", "Sofela", "CodeSweetly"];
       const bioCompleta = miBio(...datos);
       // bioCompleta contendrá: "Oluwatobi Sofela dirige CodeSweetly"
       ```
       En este ejemplo, utilizamos el operador spread ...datos para distribuir los elementos del arreglo [\"Oluwatobi\", \"Sofela\", \"CodeSweetly\"] como argumentos individuales en la función miBio().

En resumen:

- **Rest** agrupa valores en un arreglo.
- **Spread** expande elementos de un iterable en argumentos individuales.
- Ambos operadores son útiles y versátiles en JavaScript. 

### Operador `==` y `===`

El operador `===` en JavaScript se llama operador de igualdad estricta. Veamos cómo funciona y cuál es su diferencia con el operador `==:`

1. **Operador de Igualdad Estricta** `(===):`
   - El operador === compara dos valores sin realizar conversión de tipo.
   - Para que la comparación sea verdadera, ambos valores deben ser del mismo tipo y tener el mismo valor.
   - Ejemplo:
       ```javascript
           const a = 5;
           const b = "5";
           console.log(a === b); // Falso (diferentes tipos)
       ```

2. **Operador de Igualdad No Estricta** (`==`):
   - El operador == también compara dos valores, pero convierte los tipos si son diferentes.
   - Si los tipos son diferentes, intenta convertir uno o ambos valores para que tengan el mismo tipo antes de la comparación.
   - Ejemplo:
       ```javascript
       const c = 5;
       const d = "5";
       console.log(c == d); // Verdadero (se convierte "5" a número 5)
       ```

3. **Diferencias**:
   - `===` es más estricto y no realiza conversiones de tipo.
   - `==` es menos estricto y puede convertir tipos automáticamente.
   - En general, se recomienda usar `===` para evitar sorpresas debido a conversiones inesperadas.

En resumen, el operador `===` verifica igualdad tanto en valor como en tipo, mientras que `==` sólo verifica igualdad de valor

## Estructuras de control de flujo

## Paso de variables por valor y por referencia

## Romper referencia de objetos

Clonar un objeto en JavaScript es útil cuando deseas crear una copia independiente del objeto original sin afectar sus valores. Existen varias formas de hacerlo, y aquí te presento tres métodos comunes:

1.  **Spread Operator**, operador de propagación:
    - El operador de propagación `(...)` se introdujo en ES6 y es una forma sencilla de clonar objetos.
    - Crea una **copia superficial** del objeto original.
    - Ejemplo:
        ```javascript
        const usuario = { nombre: "John Doe", edad: 14, verificado: false };
        const clonUsuario = { ...usuario };
        console.log(clonUsuario); // { nombre: 'John Doe', edad: 14, verificado: false }
        ```
        El objeto `clonUsuario` ya no está vinculado directamente al objeto original, por lo que cualquier cambio en uno no afectará al otro.

2. **Object.assign()**:
   - Object.assign() copia las propiedades enumerables de uno o más objetos fuente a un objeto destino.
   - También crea una **copia superficial**.
   - Ejemplo:
       ```javascript
       const objetoOriginal = { nombre: "Ana", edad: 25 };
       const copia = Object.assign({}, objetoOriginal);
       ```
       La variable `copia` contiene una copia independiente del objeto original.

3. **JSON.parse() y JSON.stringify():**
   - Este método crea una **copia profunda** del objeto original.
   - Primero, convierte el objeto en una cadena JSON usando `JSON.stringify()`.
   - Luego, analiza la cadena JSON para crear un nuevo objeto usando `JSON.parse()`.
   - Ejemplo:
       ```javascript
       const objetoOriginal = { nombre: "Carlos", edad: 30 };
       const objetoJSON = JSON.stringify(objetoOriginal);
       const clon = JSON.parse(objetoJSON);
       ```
       El objeto `clon` es completamente independiente del objeto original.

4. **slice()** - Sólo para arreglos
    Puedes clonar un arreglo en JavaScript utilizando el método `slice()`. Aunque `slice()` se utiliza principalmente para copiar partes de un arreglo, también puedes usarlo para clonar todo el arreglo. Aquí tienes un ejemplo:

    ```javascript
    const miArreglo = [1, 2, 3, 4, 5];
    const clon = miArreglo.slice(0);

    console.log(clon); // [1, 2, 3, 4, 5]
    ```
    En este ejemplo, clon es una copia independiente de miArreglo. Cualquier modificación en uno de los arreglos no afectará al otro. Ten en cuenta que esto crea una **copia superficial**, lo que significa que si el arreglo original contiene objetos o referencias a otros objetos, ambos arreglos seguirán compartiendo esas referencias


En resumen, elige el método que mejor se adapte a tus necesidades.

## If y Else


## Un poco sobre lógica booleana
La lógica booleana en JavaScript es fundamental para tomar decisiones y controlar el flujo de tus programas. Vamos a explorar los conceptos básicos y los operadores relacionados:

1. **Valores Booleanos:**
    - Un booleano es un tipo de dato primitivo que puede tener dos valores: `true` (verdadero) o `false` (falso).
    - En JavaScript, a menudo se realiza coerción de tipos implícita para convertir otros valores en booleanos cuando sea necesario.
2. **Coerción de Tipos a Booleano:**
    - Al evaluar expresiones, JavaScript convierte automáticamente ciertos valores a booleanos.
    - Los valores que generan coerción a falso son:
        - `false` (ya es falso)
        - `null`
        - `undefined`
        - `NaN`
        - `0`
        - `-0`
        - `0n` (BigInt)
        - `""`, `' '`, `` (cadena de texto vacía)
        - `document.all`
    - Cualquier otro valor diferente de los mencionados se convierte en verdadero.
3. **Operadores Lógicos:**
    - JavaScript proporciona tres operadores lógicos principales:
        - **AND** `(&&):` Devuelve `true` si ambos operandos son verdaderos.
        - **OR** `(||):` Devuelve `true` si al menos uno de los operandos es verdadero.
        - **NOT** (`!`): Invierte el valor booleano (si es `true`, se convierte en `false`, y viceversa).
4. Evaluación Cortocircuito:
    - Los operadores `&&` y `||` utilizan una evaluación cortocircuito:
      - Si el primer operando determina el resultado (por ejemplo, en `true || ...`), no se evalúa el segundo operando.
      - Esto es útil para evitar cálculos innecesarios.
5. Ejemplos:
    ```javascript
        const a = 'palabra';
        const b = false;
        const c = true;
        const d = 0;
        const e = 1;
        const f = 2;
        const g = null;

        console.log(a || b); // 'palabra'
        console.log(c || a); // true
        console.log(b || a); // 'palabra'
        console.log(e || f); // 1
        console.log(f || e); // 2
        console.log(d || g); // null
        console.log(a && c); // true
        console.log(c && a); // 'palabra'
    ```
6. Objeto Boolean:
    - Existe un objeto nativo llamado `Boolean`.
    - Puedes usarlo para convertir valores a booleanos explícitamente.
    - Si omites el valor o proporcionas uno de los valores falsos mencionados, el objeto tiene un valor inicial de `false`.
    - Cualquier otro valor crea un objeto con un valor inicial de `true`.


En resumen, la lógica booleana y los operadores son esenciales para tomar decisiones y controlar el flujo de tus programas en JavaScript.


## Operadores y operadores de asignación

## Operador condicional ternario
El operador condicional ternario en JavaScript es una herramienta útil para escribir código de manera concisa y tomar decisiones basadas en una condición. A continuación, te explico cómo funciona y cómo puedes usarlo:

1. **Sintaxis:**
    - El operador condicional tiene la siguiente estructura:
        `condición ? expr1 : expr2;`

    - Donde:
        - `condición` es una expresión que se evalúa como `true` o `false`.
        - `expr1` es el valor que se devuelve si la condición es verdadera.
        - `expr2` es el valor que se devuelve si la condición es falsa.
2. **Ejemplos:**
    - Para mostrar un mensaje diferente según el valor de la variable isMember, puedes usar lo siguiente:
        ```javascript
            const isMember = true;
            const cuota = isMember ? "$2.00" : "$10.00";
            console.log("La cuota es de: " + cuota);
            // Salida: "La cuota es de: $2.00"
        ```
    - También puedes asignar variables dependiendo del resultado de la condición ternaria:
        ```javascript
        const elvisLives = Math.PI > 4 ? "Sip" : "Nop";
        console.log(elvisLives); // Salida: "Nop"
        ```
    - Realizar evaluaciones ternarias múltiples:
        ```javascript
        const firstCheck = false;
        const secondCheck = false;
        const access = firstCheck ? "Acceso Denegado" : secondCheck ? "Acceso Denegado" : "Acceso Permitido";
        console.log(access); // Salida: "Acceso Permitido"
        ```
    - Realizar más de una operación por caso:
        ```javascript
        const stop = false;
        const age = 16;
        age > 18 ? location.assign("continue.html") : (stop = true);
        ```

    - Asignar un valor con múltiples operaciones:
        ```javascript
        const age = 16;
        const url = age > 18
        ? (alert("OK, puedes continuar."), "continue.html")
        : (alert("Eres menor de edad!"), alert("Disculpa :-("), "stop.html");
        location.assign(url); // Redirige a "stop.html"
        ```
3. Ventajas:
    - Ayuda a escribir código limpio y conciso.
    - Es el único operador de JavaScript que requiere tres operandos.
  
En resumen, el operador condicional ternario es una herramienta poderosa para tomar decisiones de manera eficiente en tus programas JavaScript.


## Switch

## While

## Do While

## For

## For in

## For of