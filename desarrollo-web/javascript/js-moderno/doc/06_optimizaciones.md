# Optimizaciones


- [Optimizaciones](#optimizaciones)
  - [Patrón módulo](#patrón-módulo)
    - [Ejemplo de implementación](#ejemplo-de-implementación)
  - [Use Strict](#use-strict)
  - [Minifier](#minifier)


## Patrón módulo

El patrón módulo en JavaScript es una técnica que permite encapsular componentes y mejorar la modularidad del código. Aquí tienes algunos detalles al respecto:

1. **Concepto del Patrón Módulo**
 - El patrón módulo consiste en crear un módulo donde se encapsula toda la lógica de una aplicación o proyecto.
 - Dentro de este módulo, se declaran todas las variables o funciones privadas que solo son visibles dentro del mismo.

2. **Implementación**
    - Para crear un patrón módulo, se declara una única variable local que corresponde al nombre del módulo.
    - Esta variable es en realidad una función autoejecutable que devuelve un objeto con la funcionalidad necesaria.
    - Las variables internas se llaman propiedades y las funciones se convierten en métodos.

3. **Acceso a Propiedades y Métodos**
    - Las funciones autoejecutables se inicializan automáticamente y están disponibles en otras partes de la aplicación.
    - Podemos decidir qué propiedades o métodos serán públicos mediante el comando `return`, lo que los hace accesibles desde el contexto global.

4. **Ventajas del Patrón Módulo**
    - Gran potencia y flexibilidad para mantener el contexto global limpio de variables y funciones.
    - Evita problemas asociados con un código lleno de variables globales.
    - Útil para generar componentes reutilizables y modulares.
  - En resumen, el patrón módulo es una herramienta valiosa para estructurar y organizar el código JavaScript, especialmente cuando se busca evitar colisiones de nombres y mantener una arquitectura más limpia y modular

### Ejemplo de implementación

```javascript
// Definición del módulo
const miModulo = (function() {
  // Variables privadas
  let contador = 0;

  // Función privada
  function incrementarContador() {
    contador++;
    console.log(`Contador: ${contador}`);
  }

  // Método público
  function obtenerContador() {
    return contador;
  }

  // Exponer métodos públicos
  return {
    incrementar: incrementarContador,
    obtener: obtenerContador
  };
})();

// Uso del módulo
miModulo.incrementar(); // Incrementa el contador
miModulo.incrementar(); // Incrementa nuevamente
console.log(miModulo.obtener()); // Obtiene el valor actual del contador

```

En este ejemplo:

- Hemos creado un módulo llamado miModulo.
- La variable `contador` es privada y solo es accesible dentro del módulo.
- La función `incrementarContador` incrementa el contador interno.
- El método público `obtenerContador` permite obtener el valor actual del contador desde fuera del módulo.
  
Recuerda que esta es solo una implementación básica. Puedes expandirla según tus necesidades y agregar más propiedades o métodos al objeto retornado por la función autoejecutable.


## Use Strict

El uso de `'use strict'` en JavaScript permite aplicar **estrictamente** ciertas reglas al código, lo que ayuda a evitar errores comunes y a escribir un código más seguro. Aquí tienes algunos detalles sobre `'use strict'`:

1. **¿Qué es 'use strict'?**
   - 'use strict' es una directiva que se utiliza para indicar que el código debe ejecutarse en modo estricto.
   - Fue introducida en ECMAScript 5 (ES5) y no es una declaración, sino una expresión literal.
   - Los navegadores modernos (excepto Internet Explorer 9 y versiones anteriores) admiten 'use strict'.
2. **¿Por qué usarlo?**
    - Mejora la seguridad: Evita errores comunes y hace que ciertos comportamientos sean más estrictos.
    - Previene variables globales no declaradas: En modo estricto, no puedes usar variables no declaradas.
    - Lanza errores en asignaciones inválidas: Por ejemplo, asignar valores a propiedades no modificables o inexistentes.
    - Hace que el código sea más predecible y robusto.
3. **Cómo usar** `'use strict'`:
    - **A nivel global**: Agrega `'use strict';` al principio de tu script. Esto afectará a todo el código en el archivo
    ```javascript
        'use strict';
        x = 3.14; // Esto generará un error porque 'x' no está declarada
    ```
    - **Dentro de una función**: Si lo colocas dentro de una función, solo afectará al código dentro de esa función.
    ```javascript
        function miFuncion() {
            'use strict';
            y = 3.14; // Esto también generará un error por la misma razón
        }
    ```

4. **Consideraciones:**
    - `'use strict'` es solo una cadena de texto, por lo que incluso si un navegador no lo entiende, no lanzará un error (como en Internet Explorer 9).
    - **No se permite** usar variables sin declarar ni objetos sin declarar en modo estricto.
  
En resumen, `'use strict'` es una herramienta poderosa para escribir código más seguro y evitar errores sutiles. ¡Úsalo siempre que puedas! 😊


## Minifier

Minificar un archivo JavaScript es una práctica común para **optimizar** su tamaño y mejorar el rendimiento de las aplicaciones web. Aquí tienes algunas opciones para minificar tu código JS:

1. **Minify-JS.com**: Es una herramienta en línea que permite reducir el tamaño del código JavaScript hasta en un 80%. Utiliza la utilidad Terser, compatible con el estándar ES6+. Solo copia tu código y pégalo en el área de texto “Código fuente” en [Minify-JS.com](https://minify-js.com/). Luego, haz clic en el botón “Minificar” y obtendrás el resultado1.
2. **Aspose Minificador en línea JS**: Otra opción es utilizar la herramienta de Aspose. Puedes copiar tu código JavaScript o cargar un archivo desde tu sistema local. Haz clic en “Minificar” y verás el resultado en el campo de texto2.
3. **Editar en el navegador**: Si prefieres hacerlo directamente en el navegador, puedes usar las herramientas de desarrollador de Google Chrome. Carga el archivo JavaScript local o del servidor, ve a *“Menú” > “Más herramientas” > “Herramientas de desarrollador”* o presiona la tecla de acceso directo (F12) para abrir las herramientas de desarrollador.
   
Recuerda que la minificación **elimina caracteres innecesarios, acorta nombres de variables y funciones, y optimiza el código para una carga más rápida**
