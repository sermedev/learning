# ¿Qué es MVC?

El MVC (Modelo-Vista-Controlador) es un patrón de arquitectura de software que se utiliza para desarrollar aplicaciones de manera organizada y modular. A continuación, te explico sus componentes y su funcionamiento:

- **Modelo (Model)**:
    - El Modelo representa los datos y la lógica de negocio de la aplicación.
    - Se encarga de acceder a la base de datos, procesar información y gestionar los datos.
    - Es independiente de la interfaz de usuario y no sabe nada sobre cómo se presenta la información.
- **Vista (View)**:
    - La Vista es la parte visible de la aplicación que muestra los datos al usuario.
    - Representa la interfaz gráfica y se encarga de presentar la información de manera adecuada.
    - No contiene lógica de negocio y se actualiza automáticamente cuando cambian los datos del Modelo.
- **Controlador (Controller)**:
    - El Controlador actúa como intermediario entre el Modelo y la Vista.
    - Recibe las solicitudes del usuario desde la interfaz (por ejemplo, al hacer clic en un botón).
    - Procesa las acciones del usuario, actualiza el Modelo y decide qué Vista mostrar.
    - Es responsable de la lógica de flujo y la coordinación entre el Modelo y la Vista.

En resumen, el patrón **MVC separa las responsabilidades** de una aplicación en tres componentes claramente definidos: el Modelo (datos y lógica), la Vista (interfaz gráfica) y el Controlador (gestión de acciones). Esta separación facilita el **mantenimiento**, la **reutilización** del código y la **escalabilidad** de las aplicaciones


🔗 [Artículo definición MVC](https://desarrolloweb.com/articulos/que-es-mvc.html)


##  Template Web API de .NET
El template de web API de .Net se basa en la arquitectura MVC. Sin embargo, al crear un proyecto en .NET de tipo Web API, el template inicial creado automáticamente elimina por defecto la capa *Vista* dejando una arquitectura MC (Model-Controller). Esto es así porque una API web no tiene una interfaz final con el que el usuario interactúe directamente. Existirá otro componente del lado de cliente que será quién contenga esa interfaz directa.
En una API web el concepto de *Vista* lo podrían representar los *JSON* devueltos.



