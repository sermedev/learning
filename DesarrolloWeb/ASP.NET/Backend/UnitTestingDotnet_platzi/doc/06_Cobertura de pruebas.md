# Cobertura de pruebas
La cobertura de pruebas de código se refiere a una métrica que mide la cantidad de código que es ejecutada por las pruebas unitarias. Esta medida puede ser expresada en términos de líneas de código, ramas o métodos. En otras palabras, la cobertura de código nos dice qué porcentaje del código fuente está siendo probado por nuestras pruebas.

Para lograr una buena cobertura de código, es importante escribir pruebas unitarias exhaustivas que cubran diferentes caminos de ejecución en tu código. Esto ayuda a garantizar la funcionalidad y proporciona una forma de verificar los esfuerzos de refactorización.

En resumen, la cobertura de código te permite evaluar cuánto de tu código está siendo probado y te ayuda a identificar áreas que pueden necesitar más atención en tus pruebas unitarias.

## Herramientas para medir la cobertura
En el contexto de .NET, existen varias herramientas que puedes utilizar para medir la cobertura de pruebas unitarias. Aquí te presento algunas opciones:

- **Visual Studio Enterprise**: Si utilizas Visual Studio Enterprise, también puedes aprovechar su funcionalidad integrada para medir la cobertura de código durante las pruebas.
  
- Herramientas antiguas:
  - NCover
  - OpenCover
  
- **DotCover**: DotCover es una herramienta de cobertura de código desarrollada por JetBrains. Proporciona análisis de cobertura de código para aplicaciones .NET. Puedes utilizarla para medir la cobertura de tus pruebas unitarias.  [+Info](https://www.jetbrains.com/dotcover/)

- **Fine Code Coverage** [+Info](https://marketplace.visualstudio.com/items?itemName=FortuneNgwenya.FineCodeCoverage2022)
  

- **Coverlet**: 
  - Es un proyecto de **código abierto** en GitHub.
  - Proporciona un marco de cobertura de código **multiplataforma**
  - Soporta **.NET Framework** y **.NET Core**. 
  - Es parte de la .NET Foundation.
  - Coverlet recopila datos de series de pruebas de cobertura, que se utilizan para la **generación de informes**.
  - Funciona con VSTest, NUnit, XUnit y otros
  

