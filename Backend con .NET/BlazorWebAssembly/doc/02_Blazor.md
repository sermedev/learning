# Blazor

## ¿Qué es?

Blazor es un moderno framework de desarrollo web que te permite utilizar C# para construir aplicaciones web de pila completa sin necesidad de escribir una sola línea de JavaScript. Aquí tienes algunos aspectos clave sobre Blazor:

1. Flexibilidad y reutilización
   - Blazor utiliza un modelo de componentes flexible y reutilizable. Puedes crear componentes web con HTML, CSS y C#, y luego ejecutarlos tanto en el cliente como en el servidor. Esto te permite ofrecer excelentes experiencias web.

2. Ejecución en el cliente y en el servidor
    - WebAssembly (Wasm): Puedes ejecutar componentes Blazor en cualquier navegador web utilizando WebAssembly. Esto proporciona un rendimiento cercano al nativo.
    - Servidor: También puedes ejecutar componentes Blazor en el servidor utilizando ASP.NET Core. Esto es útil para aplicaciones con interacción en tiempo real o para reducir la carga en el cliente.
  
3. Conexión a datos
    - Blazor te permite visualizar y editar datos mediante la vinculación a modelos de datos fuertemente tipados.

4. Seguridad
    - Puedes configurar rápidamente políticas de autenticación y autorización utilizando plantillas preconfiguradas y herramientas integradas.

5. Interop con JavaScript
   - Blazor te permite llamar a bibliotecas y APIs JavaScript existentes desde C#.

En resumen, Blazor es una excelente opción para desarrolladores que desean aprovechar su conocimiento de C# para crear aplicaciones web modernas y eficientes.



```
💚 La gente de Platzi destaca además:

- Es una Nueva tecnología para el desarrollo web
- Está basada en componentes
- Sintaxis C# y HTML
- Es OpenSource
- Es multiplataforma
- Gran comunidad
- Compatible con JavaScript
```

## Blazor WebAssembly vs Blazor Server
Blazor Server y Blazor WebAssembly son dos [modelos de hospedaje en el marco de desarrollo web Blazor](https://learn.microsoft.com/es-es/aspnet/core/blazor/hosting-models?view=aspnetcore-8.0). Las diferencias clave entre ambos son:

1. Blazor Server
   - Los componentes se ejecutan **en el servidor** desde una aplicación ASP.NET Core.
   - Las actualizaciones de la interfaz de usuario, el control de eventos y las llamadas de JavaScript se gestionan mediante una conexión **SignalR** utilizando el protocolo **WebSockets**.
   - El estado en el servidor asociado a cada cliente conectado se llama **circuito**.
   - Los circuitos no están vinculados a una conexión de red específica y pueden tolerar interrupciones temporales de red.
   - Cada pantalla del explorador requiere un circuito e instancias independientes del estado del componente que administra el servidor.
   - Ideal para aplicaciones que requieren interactividad en **tiempo real** y una integración sin problemas con el backend.
  
2. Blazor WebAssembly
   - Los componentes se ejecutan **en el cliente**, dentro del explorador, en un entorno de ejecución .NET basado en WebAssembly (Wasm).
   - Descarga una versión ligera del tiempo de ejecución .NET al cliente.
   - Ofrece compatibilidad **multiplataforma** y ejecución del lado cliente.
   - Excelente para aplicaciones que deben funcionar sin conexión a Internet o en entornos donde el servidor no está disponible.
  
En resumen:

Blazor Server destaca en interactividad en tiempo real y backend integrado.
Blazor WebAssembly ofrece compatibilidad multiplataforma, ejecución del lado cliente y mayor rendimiento

```
💚 La gente de Platzi destaca además:

- Blazor WebAssembly:
   - Mejor experiencia en la web
   - Soporta progressive web apps (PWA)
- Blazor Server
   - Excelente para manipular grandes cantidades de datos y lógica de negocio
```