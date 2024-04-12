# Componentes

En Blazor, los componentes son elementos fundamentales de la interfaz de usuario. Cada componente puede contener marcado HTML, CSS y código C#. Estos componentes se pueden anidar, reutilizar y compartir entre proyectos, lo que facilita la creación y el mantenimiento de aplicaciones web complejas

Los componentes en un proyecto Blazor, inicialmente se ubican en la carpeta *Pages*

## Estructura

Su estructura general es:

- ** @page:** ruta para acceder a él  
- **\<PageTitle>:** título de la página   
- **Estructura** del contenido en html con c#

Ejemplo:

``` html
@page "/counter"

<PageTitle>Counter</PageTitle>

<h1>Counter</h1>

<p role="status">Current count: @currentCount</p>

<button class="btn btn-primary" @onclick="IncrementCount">Click me</button>

@code {
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }
}
```

Puede darse el caso también de componentes sin ningún código. Ejemplo:


``` html
@page "/"

<PageTitle>Home</PageTitle>

<h1>Hello, world!</h1>

Welcome to your new app.

```

## Ciclo de vida de componentes en Blazor

En Blazor, los componentes tienen un ciclo de vida que abarca desde su creación hasta su eliminación. Estos eventos de ciclo de vida son fundamentales para comprender cómo funcionan los componentes y cuándo se ejecutan ciertas operaciones. A continuación, te explico los principales eventos del ciclo de vida de los componentes en Blazor:

1. Creación e Inicialización:
    - **SetParametersAsync**: Este evento se dispara cuando se establecen los parámetros del componente. Aquí se inicializan las propiedades y se configuran los valores iniciales.
    - **OnInitialized {Async}:** Después de la inicialización de parámetros, este evento se ejecuta. Es útil para realizar tareas de configuración adicionales.
2. Actualización de Parámetros:
    - **OnParametersSet {Async}:** Cuando se modifican los parámetros del componente, este evento se activa. Aquí puedes reaccionar a los cambios y actualizar el estado interno.
3. Renderizado y Representación:
    - **Render**: Este evento se dispara cuando se necesita representar el componente. Aquí se genera el marcado HTML y se actualiza la interfaz de usuario.
    - **OnAfterRender {Async}:** Después de que se complete el renderizado, este evento se ejecuta. Puedes realizar acciones adicionales después de que la interfaz de usuario se haya actualizado.
4. Eliminación y Limpieza:
    - Dispose: Cuando se elimina el componente (por ejemplo, cuando se cambia de página o se destruye), este evento se activa. Aquí puedes liberar recursos y realizar tareas de limpieza.
  
  **\* StateHasChanged**: Es un método que notifica a Blazor que el estad*o de un componente ha cambiado y que debe renderizar nuevamente. Se lanza de manera automática pero también puede ser invocado manualmente.

![](img/components_parentrenders.png)
  
Es importante recordar que estos eventos se pueden invalidar en los componentes para personalizar su comportamiento. Además, algunos de ellos admiten versiones asincrónicas (marcadas con `{Async}`), lo que permite trabajar con operaciones asíncronas durante el ciclo de vida del componente.

🔗 [Más info](https://learn.microsoft.com/es-es/aspnet/core/blazor/components/lifecycle?view=aspnetcore-8.0)