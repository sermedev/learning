# WebAssembly

## ¿Qué es?
WebAssembly (Wasm) es un formato de instrucciones binario diseñado para una máquina virtual basada en pila. Su objetivo es servir como un destino de compilación portátil para lenguajes de programación, lo que permite su implementación en la web tanto para aplicaciones cliente como servidor. Aquí tienes algunos aspectos clave sobre WebAssembly:

1. Eficiente y rápido: La máquina virtual de Wasm está diseñada para ser codificada en un formato binario eficiente en términos de tamaño y tiempo de carga. El objetivo de WebAssembly es ejecutarse a velocidad nativa, aprovechando las capacidades de hardware comunes disponibles en una amplia gama de plataformas.
2. Seguro: WebAssembly proporciona un entorno de ejecución seguro y aislado en términos de memoria. Incluso puede implementarse dentro de las máquinas virtuales JavaScript existentes. Cuando se integra en la web, Wasm cumple con las políticas de seguridad de mismo origen y permisos del navegador.
3. Abierto y depurable: WebAssembly está diseñado para ser legible en un formato textual para depuración, pruebas, experimentación, optimización, aprendizaje, enseñanza y escritura manual de programas. El formato textual se utiliza al ver el código fuente de los módulos Wasm en la web.
4. Parte de la plataforma web abierta: WebAssembly mantiene la naturaleza sin versión, probada en función y compatible con versiones anteriores de la web. Los módulos de WebAssembly podrán llamar dentro y fuera del contexto JavaScript y acceder a la funcionalidad del navegador a través de las mismas API web accesibles desde JavaScript.

En resumen, WebAssembly es un avance importante que permite a los desarrolladores compilar sus aplicaciones en un formato binario eficiente y ejecutarlas en la web con un rendimiento cercano al nativo.

```
💚 La gente de Platzi destaca además:

- Nuevo estándar web que aparece en 2015
- Diseñado inicialmente para C/C++
- Permite a lenguajes compilados ejecutarse en el navegador (C++, C#, Go, Rust)
- Extensiones **.wast, .wasm**
```


[▶️ Youtube - Por qué WebAssembly es el futuro del Desarrollo Web](https://www.youtube.com/watch?v=dY3LO_QES28)


## WebAssembly vs JavaScript

WebAssembly (Wasm) y JavaScript son dos tecnologías fundamentales en el desarrollo web, pero tienen diferencias significativas. Aquí está una comparativa entre ambas:

1. Rendimiento:
   - **WebAssembly**: Wasm está diseñado para ejecutarse a velocidad cercana a la nativa. Su formato binario permite una carga rápida y un rendimiento eficiente en tareas como procesamiento de imágenes y audio.
   - **JavaScript**: Es un lenguaje interpretado y, por lo tanto, más lento en comparación con Wasm. Sin embargo, JavaScript sigue siendo excelente para la manipulación de la interfaz de usuario y la interacción con el usuario.
2. Lenguajes admitidos:
    - **WebAssembly**: A diferencia de JavaScript, Wasm no es un lenguaje de programación en sí mismo. Puede integrar varios lenguajes, como Python, Rust, Go, .NET, C++, Java y PHP.
    - **JavaScript**: Es el lenguaje principal para la web y tiene una gran comunidad de desarrolladores.
3. Uso en la web:
    - **WebAssembly**: Originalmente, Wasm se creó para mejorar la eficiencia de JavaScript en el navegador. Puede compilar código JavaScript en módulos Wasm para mejorar el rendimiento.
    - **JavaScript**: Es ampliamente utilizado para crear aplicaciones web interactivas y dinámicas.
4. Seguridad:
    - **WebAssembly**: Proporciona un entorno de ejecución seguro y aislado en términos de memoria. Cumple con las políticas de seguridad del navegador.
   - **JavaScript**: Puede ser vulnerable a ataques, como inyección de código malicioso.
5. Compatibilidad:
    - **WebAssembly**: Funciona en navegadores modernos y también puede ejecutarse fuera del navegador en servidores y dispositivos IoT.
    - **JavaScript**: Es omnipresente en los navegadores, pero no se utiliza fuera del contexto web.

En resumen, WebAssembly es ideal para tareas intensivas en recursos y donde se requiere un alto rendimiento. JavaScript sigue siendo esencial para la interacción con el usuario y la construcción de aplicaciones web.

## Casos de éxito

WebAssembly (Wasm) ha demostrado ser una tecnología poderosa en el desarrollo web, y varios proyectos exitosos lo utilizan para ofrecer experiencias avanzadas y de alto rendimiento. Aquí tienes algunos casos notables:

1. Figma:
    - [Figma](https://www.figma.com/), una herramienta de diseño colaborativo, utiliza WebAssembly para ofrecer una experiencia fluida y rápida en la edición de imágenes y diseño gráfico.
2. Google Earth para la Web:
    - [Google Earth](https://earth.google.com/web/) utiliza WebAssembly para ofrecer una experiencia de exploración 3D en el navegador sin necesidad de instalar complementos adicionales.
3. Blazor WebAssembly:
   - Blazor es un framework moderno de Microsoft para desarrollo web.
   - La variante WebAssembly de Blazor compila código C# y .NET a Wasm, lo que permite programar aplicaciones web SPA (una sola página) usando HTML, CSS y C# sin depender de JavaScript.
4. WASI (WebAssembly System Interface):
   - [WASI](https://wasi.dev/) es una interfaz estándar que permite a los programas Wasm interactuar con el sistema operativo y otros entornos.
   - Se utiliza para ejecutar aplicaciones Wasm fuera del navegador, como en servidores o dispositivos IoT.
5. AutoCAD Web:
    - [AutoCAD](https://www.autodesk.es/products/autocad-web), el popular software de diseño asistido por computadora, tiene una versión web que utiliza WebAssembly para proporcionar una interfaz de usuario similar a la de la aplicación de escritorio.
6. Ioide:
    - [Ioide](https://alpha.iodide.io/) es un IDE (entorno de desarrollo integrado) basado en WebAssembly.
    - Permite a los desarrolladores escribir y compilar código en varios lenguajes directamente en el navegador.
7. Soundation:
    - [Soundation](https://soundation.com/) es una aplicación de creación musical en línea que utiliza WebAssembly para procesar audio y ofrecer una interfaz de usuario interactiva.
8. 8th Wall:
    - [8th Wall](https://www.8thwall.com/) es una plataforma de realidad aumentada que utiliza WebAssembly para ofrecer experiencias AR en dispositivos móviles y navegadores web.

En resumen, WebAssembly ha permitido desde ejecutar Python en el navegador hasta crear frameworks completos de desarrollo web. Estos proyectos demuestran su capacidad y cómo está transformando el futuro del desarrollo web.