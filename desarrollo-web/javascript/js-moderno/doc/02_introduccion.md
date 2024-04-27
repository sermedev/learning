## Introducción a JavaScript y la consola

Temas que se verán en esta sección:

## Historia de JavaScript
> JavaScript NO es lo mismo que Java

JavaScript, abreviado comúnmente como **JS**, es un lenguaje de programación interpretado que se define como orientado a objetos, basado en prototipos, imperativo, débilmente tipado y dinámico. Su historia se remonta al año 1995, cuando fue desarrollado originalmente por **Brendan Eich** de Netscape Communications. A lo largo de los años, JavaScript ha evolucionado enormemente y se ha convertido en una de las linguas más influyentes en el mundo de la tecnología.

En sus inicios, JavaScript se llamó *Mocha*, luego fue renombrado a *LiveScript* y finalmente quedó como JavaScript. Fue diseñado con una sintaxis similar a C++ y Java, aunque adopta nombres y convenciones del lenguaje de programación Java. Sin embargo, Java y JavaScript tienen semánticas y propósitos diferentes. La relación entre ellos es puramente comercial, ya que Sun Microsystems (creador de Java) adquirió Netscape Navigator (creador de LiveScript) y cambió el nombre del lenguaje de programación. Desde entonces, JavaScript se ha convertido en un componente esencial para mejorar la interfaz de usuario y crear páginas web dinámicas. Además, su uso se ha extendido más allá de las aplicaciones web, incluyendo documentos PDF y aplicaciones de escritorio.

[🔗 JavaScript en Wikipedia](https://es.wikipedia.org/wiki/JavaScript)


## ECMAScript

ECMAScript es una especificación de lenguaje de programación publicada por Ecma International. Su desarrollo comenzó en 1996 y se basó en el popular lenguaje JavaScript, que fue propuesto como estándar por Netscape Communications Corporation. Actualmente, ECMAScript está aceptado como el estándar ISO/IEC 22275:2018.

Aquí tienes algunos detalles clave sobre ECMAScript:

- Definición y Propósito:
    - **ECMAScript** es un lenguaje de programación orientado a objetos, estándar y abierto. Se utiliza para crear scripts que se emplean en sitios web, aplicaciones web, servidores, entornos de navegador y aplicaciones de escritorio1.
- Historia:
    - ECMAScript fue desarrollado por **Brendan Eich**, quien trabajaba en **Netscape**. Inicialmente, el lenguaje se llamaba **Mocha**, luego **LiveScript** y finalmente **JavaScript**.
    - En diciembre de **1995, Sun Microsystems y Netscape** anunciaron **JavaScript** en una conferencia de prensa.
    - Desde entonces, han existido varias versiones de ECMAScript, incluyendo la **versión 6 (ES6)**, que introdujo muchas características nuevas y poderosas

En resumen, ECMAScript es el estándar internacional que define a JavaScript y es ampliamente utilizado en el desarrollo web y otras aplicaciones. ¡Es el corazón del lenguaje que impulsa la interactividad en la web! 😊

**Historia detallada:**
 Desde su lanzamiento en junio de 1997, el estándar ECMAScript ha experimentado varias versiones significativas. A continuación, te presento algunas de las versiones más destacadas:

  1. ECMAScript 1 (ES1):
    - Año: 1997.
    - Notas: Fue la primera versión oficial y estableció las bases para el lenguaje JavaScript.
  2. ECMAScript 2 (ES2):
    - Año: 1998.
    - Notas: Introdujo mejoras menores y correcciones de errores.
  3. ECMAScript 3 (ES3):
    - Año: 1999.
    - Notas: Esta versión incluyó mejoras significativas, como soporte para expresiones regulares y manejo de excepciones.
  1. ECMAScript 5 (ES5):
    - Año: 2009.
    - Notas: Introdujo características importantes como métodos nativos para manipulación de arreglos (map, filter, reduce, etc.) y el modo estricto ('use strict').
  1. ECMAScript 6 (ES6) o ECMAScript 2015:
    - Año: 2015.
    - Notas: Esta versión fue un gran salto y trajo consigo muchas características poderosas, como las clases, arrow functions, módulos, destructuring, promesas y más.
  1. ECMAScript 7 (ES7) o ECMAScript 2016:
    - Año: 2016.
    - Notas: Introdujo características como el operador de exponenciación (**) y el método Array.prototype.includes().
  1. ECMAScript 8 (ES8) o ECMAScript 2017:
    - Año: 2017.
    - Notas: Incluyó mejoras como async/await, Object.values(), Object.entries() y String padding.

  Cada una de estas versiones ha aportado al crecimiento y la evolución del lenguaje JavaScript. La más utilizada actualmente es ES5, aunque ES6 y versiones posteriores han introducido características poderosas que los desarrolladores aprovechan en sus proyectos


## Uso de JavaScript en la industria actual

JavaScript ha experimentado una evolución significativa y se ha convertido en uno de los lenguajes de programación más influyentes en la actualidad. A continuación, te proporciono información relevante sobre el uso de JavaScript en la industria de la programación:

- Creación de páginas web:
  JavaScript es fundamental para desarrollar páginas web interactivas y dinámicas. Permite manipular el contenido de una página de forma dinámica, brindando una experiencia más rica al usuario.
- Desarrollo del backend de aplicaciones:
  Node.js, que sigue siendo JavaScript, se utiliza para programar el backend de aplicaciones. Esto permite construir servidores y manejar la lógica del lado del servidor.
- Sistemas operativos:
  Aunque no es su uso principal, JavaScript también se ha utilizado en sistemas operativos y herramientas relacionadas.
- Servidores de Internet:
  JavaScript se emplea en el desarrollo de servidores web y aplicaciones que requieren comunicación en tiempo real, como chats y aplicaciones colaborativas.
- Bases de datos:
  A través de bibliotecas y frameworks, JavaScript se integra con bases de datos para crear aplicaciones web escalables y eficientes.
- Plataformas de juego:
  Con el auge de los juegos en línea y las aplicaciones de entretenimiento, JavaScript se ha utilizado en el desarrollo de juegos y experiencias interactivas en el navegador.

En resumen, JavaScript es un lenguaje versátil y omnipresente que se ha consolidado como una herramienta esencial en la industria de la programación. Su comunidad activa y su maduro ecosistema lo convierten en una elección poderosa para una variedad de aplicaciones y proyectos


## Hola Mundo en JavaScript

Hay varias formas de crear un “Hola Mundo” en JavaScript. Aquí te presento algunas opciones:

1. Usando `document.write()`
    Crea una página HTML con la siguiente estructura
    ```html
    <!DOCTYPE html>
    <html>
    <head>
        <title>Mi primer código JavaScript</title>
    </head>
    <body>
        <h1>Mi primer código JavaScript</h1>
        <script>
        document.write("¡Hola Mundo!");
        </script>
    </body>
    </html>
    ```
    Abre esta página en un navegador web y verás el mensaje “¡Hola Mundo!”.

2. Mediante `console.log():`
   Si deseas ver el mensaje en la consola del navegador, puedes usar:
   ```javascript
   console.log("¡Hola Mundo!");
   ```
3. En un archivo HTML
   Crea un archivo HTML (por ejemplo, index.html) y agrega el siguiente código:

    ```html
   <!DOCTYPE html>
    <html>
    <head>
        <title>Mi primer código JavaScript</title>
    </head>
    <body>
        <h1>Mi primer código JavaScript</h1>
        <script src="tu-archivo.js"></script>
    </body>
    </html>
    ```
    Luego, crea un archivo JavaScript (por ejemplo, tu-archivo.js) con el siguiente contenido:

    ```javascript
    // tu-archivo.js
    document.write("¡Hola Mundo!");
    ```
    Abre el archivo HTML en un navegador para ver el mensaje.


## Creación de variables y constantes

💡 Usar `const` si vamos a declarar una variable que no vamos a modificar, será más eficiente en memoria


## Introducción a la consola de JavaScript
--


## Depuración y breakpoints
--


## Problemas con la declaración de variables con var

La sentencia `var` en JavaScript se utiliza para declarar una variable, opcionalmente inicializándola con un valor. Aquí tienes algunos detalles importantes sobre el uso de `var`:

1. Ámbito de las variables:
    - Las variables declaradas con `var` tienen un ámbito de ejecución en curso. Esto significa que su alcance puede ser la función que las contiene o, si están declaradas fuera de cualquier función, un ámbito global.
  
    - Si re-declaras una variable con `var`, no perderá su valor. Sin embargo, ten en cuenta que asignar un valor a una variable no declarada la crea como una variable global (se convierte en una propiedad del objeto global).
  
    - Ejemplo:
  
    ```javascript
        function ejemplo() {
        y = 1; // Lanza un error de tipo "ReferenceError" en modo estricto ('use strict')
        var z = 2;
        }
        ejemplo();
        console.log(y); // Imprime "1"
        console.log(z); // Lanza un error de tipo "ReferenceError": z no está definida fuera de ejemplo
    ```

3. Elevación de variables:
    - La declaración de variables (y todas las declaraciones en general) se procesa antes de ejecutar cualquier otro código. Por lo tanto, declarar una variable en cualquier parte del código es equivalente a declararla al inicio del mismo.
    - Ejemplo:

    ```javascript
    console.log(a); // Lanza un error de tipo "ReferenceError"
    console.log("trabajando..."); // Nunca se ejecuta
    var a;
    console.log(a); // Imprime "undefined" o "" dependiendo del navegador
    console.log("trabajando..."); // Imprime "trabajando..."
    ```
3. Diferencias entre variables declaradas y no declaradas:
    - Las variables declaradas se limitan al contexto de ejecución en el que se declaran, mientras que las no declaradas siempre son globales.
    - Las variables declaradas se crean antes de ejecutar cualquier otro código, mientras que las no declaradas no existen hasta que se ejecuta el código que las asigna.
    - Las variables declaradas son propiedades no configurables de su contexto de ejecución (ya sea una función o un ámbito global), mientras que las no declaradas son configurables (pueden borrarse).
  
Por tanto, se recomienda siempre declarar las variables, sin importar si están en una función o en un ámbito global. En el modo estricto (strict mode) de ECMAScript 5, asignar un valor a una variable no declarada lanzará un error

💡No usar `var`, no se elimina por retrocompatibilidad. Usar `let` en su lugar. var sobreescribe las variables de windows y además puede enmascarar errores en ejecución en cuanto a utilización de variables sin definir previamente


## Prompts, alerts, confirms

Tenemos que ser conscientes de donde se ejecutará nuestro código js ya algunas librería u objetos pueden no estar disponibles inicialmente. Por ejemplo:
- En `console.log(global)`, global estará disponible en *node.js* pero no en nuestro navegador
- `confirm()`, `alert()` o `prompt()` no estarán disponibles en node.js porque están en el objeto *window*