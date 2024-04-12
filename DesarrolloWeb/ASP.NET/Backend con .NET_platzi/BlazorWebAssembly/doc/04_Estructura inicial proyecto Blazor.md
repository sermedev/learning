# Estructura inicial proyecto Blazor

🗒️ ***.csproj***  
Archivo de proyecto. Define la configuración del framework, librería cargadas.

📁 **Properties**  
Carpeta con la configuración de ejecución de la aplicación.
 
📁 **wwwroot**  
Carpeta donde se guardarán los archivos estáticos como css, html, imágenes, etc. Veremos un único archivo *index.html* ya que blazor es una *SPA (sinlge page application)* en donde un único archivo html contiene toda la aplicación.

📁 **Pages**  
Carpeta con los componentes de la aplicación.

🗒️ **_Imports.razor**  
Declaraciones de los *using* comunes que se usarán en los componentes.

🗒️ **App.razor:**  
contiene toda la estructura de componentes del proyecto. No se suele modificar.

📁 **Layout**  
Carpeta con los componentes compartidos, genéricos para reutilizar en diferentes partes.

 🗒️ **Program.cs:**   
Estructura general para ejecutar el proyecto y configuracion de los servicios/dependencias.