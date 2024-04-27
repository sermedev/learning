# Minimal API
Las API mínimas son un enfoque simplificado para crear API de HTTP rápidas con ASP.NET Core. Con este enfoque, puedes construir puntos de conexión totalmente funcionales REST con código y configuración mínimos. Olvídate del andamiaje tradicional y evita controladores innecesarios mediante la declaración fluida de las rutas y acciones de la API.

Por ejemplo, el siguiente código crea una API en la raíz de la aplicación web que devuelve el texto “Hello World!”:

```cs
var app = WebApplication.Create(args);
app.MapGet("/", () => "Hello World!");
app.Run();
```

La mayoría de las API aceptan parámetros como parte de la ruta. Aquí tienes otro ejemplo:
```cs
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/users/{userId}/books/{bookId}", (int userId, int bookId) => $"El ID de usuario es {userId} y el ID del libro es {bookId}");
app.Run();
```

Esto es todo lo que necesitas para empezar, pero no es todo lo que está disponible. Las API mínimas admiten la configuración y la personalización necesarias para escalar a varias API, controlar rutas complejas, aplicar reglas de autorización y controlar el contenido de las respuestas de las API. Un buen lugar para comenzar es el Tutorial: Creación de una API mínima con ASP.NET Core12. ¡Espero que encuentres útil esta forma rápida y sencilla de crear puntos de conexión de API web con ASP.NET Core!

🔗 [Documentación oficial Minimal API](https://learn.microsoft.com/es-es/aspnet/core/fundamentals/minimal-apis/overview?view=aspnetcore-8.0)

La gente de Platzi cita las siguientes carácteristicas principales:
- Nueva plantilla con un estilo minimalista.
- Utiliza las últimas mejoras de C# y .NET para disminuir las líneas de código.
- Facilita la curva de aprendizaje de APIs en .NET

## Minimal API vs Web API

### Minimal API
- **Enfoque simplificado: **Las API mínimas son una forma simplificada de crear puntos de conexión de HTTP rápidos con ASP.NET Core.
- **Menos código y configuración:** Con Minimal API, puedes construir puntos de conexión REST completamente funcionales con mínimo código y configuración.
- **Declaración fluida de rutas y acciones:** Olvídate del andamiaje tradicional y evita controladores innecesarios. Puedes declarar rutas y acciones de la API de manera fluida
- Ejemplo:
  ```cs
    var app = WebApplication.Create(args);
    app.MapGet("/", () => "¡Hola, mundo!");
    app.Run();
  ```
- Personalización y escalabilidad: Aunque es simple, las API mínimas admiten configuración y personalización para escalar a varias API y manejar rutas complejas, autorización y contenido de respuestas.


### Web API
- **Enfoque tradicional:** Las Web API en ASP.NET Core siguen el enfoque tradicional con controladores, rutas y atributos.
- **Controladores y acciones:** Utilizas controladores para agrupar acciones relacionadas. Cada acción en un controlador responde a una ruta específica.
- Ejemplo
    ```cs
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetBook(int id)
        {
            // Lógica para obtener un libro por ID
            // ...
        }
    }
    ```
- **Mayor flexibilidad:** Las Web API ofrecen más flexibilidad en términos de estructura y organización.
- **Amplia documentación y comunidad**: Hay mucha documentación y recursos disponibles para las Web API.
  
En resumen, si buscas una forma rápida y sencilla de crear puntos de conexión de API web, Minimal API es una excelente opción. Si necesitas más flexibilidad y estructura, las Web API tradicionales son una elección sólida. ¡Espero que esta comparación te ayude a tomar una decisión informada!

La gente de Platzi destaca las siguientes diferencias:

|Minimal API|Web API|
|---|---|
|Utiliza mapeo de rutas con funciones|Utiliza modelo MVC para estructurar el código|
|Orientado a proyectos pequeños, demos, microservicios y Azure functions|Se puede utilizar para proyectos de cualquier tamaño|
|Complejo de escalar en proyectos de alta complejidad|Más sencillo de escalar|
