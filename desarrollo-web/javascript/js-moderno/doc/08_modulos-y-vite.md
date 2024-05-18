# Módulos y Vite


## ¿Qué son bundlers?

Un **bundler de JavaScript** es un archivo único que contiene **todas las dependencias y componentes** de una aplicación web. El bundling simplifica la carga y el manejo del código en el navegador, **mejorando el rendimiento y la experiencia del usuario**. En otras palabras, los bundlers agrupan múltiples archivos JavaScript en uno solo, lo que evita que el navegador realice varias peticiones HTTP para cargar todos los archivos por separado. Algunos ejemplos populares de bundlers son **Webpack, Parcel y Rollup**. Estas herramientas nos permiten combinar y optimizar nuestro código para una entrega más eficiente al cliente. Si tienes más preguntas o necesitas más detalles, no dudes en preguntar.


## ¿Qué es Webpack y TurboPack?

**Webpack** es un **empaquetador de módulos** utilizado en el desarrollo web Front-End. Permite gestionar dependencias, ejecutar tareas, convertir formatos, servir en un entorno de desarrollo y cargar módulos de diferentes tipos (como AMD, CommonJS o ES2015). Además, no solo se aplica a código JavaScript, sino también a hojas de estilo, páginas HTML e imágenes. En resumen, Webpack coloca en un grafo de dependencias todos los elementos de tu proyecto, lo que lo hace extremadamente poderoso.

Por otro lado, **Turbopack** es una herramienta desarrollada por Vercel, creadores de Webpack y NextJS. Afirman que en aplicaciones a gran escala, Turbopack se actualiza 10 veces más rápido que Vite y 700 veces más rápido que Webpack. Sin embargo, su adopción aún está en proceso, y es importante evaluarlo según las necesidades específicas de tu proyecto


## ¿Qué es Vite?

**Vite** es una herramienta de **compilación para proyectos web modernos**. Su objetivo es proporcionar una experiencia de desarrollo más rápida y ágil. Consta de dos partes principales:

1. **Servidor de desarrollo**: Proporciona mejoras enriquecidas de funcionalidades sobre módulos ES nativos, como el **reemplazo de módulos en caliente (HMR)** extremadamente rápido.
2. **Comando de compilación**: Empaqueta tu código con **Rollup**, preconfigurado para generar recursos estáticos altamente optimizados para producción12.

Vite es agnóstico a frameworks y viene con configuraciones predeterminadas listas para usar. Puedes probarlo en línea en **StackBlitz** o crear tu primer proyecto Vite con el siguiente comando:

```console
npm create vite@latest
```


## ¿Por qué queremos utilizar esas herramientas?