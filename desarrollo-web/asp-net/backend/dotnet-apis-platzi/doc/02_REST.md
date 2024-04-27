# ¿Qué es REST?

REST (Representational State Transfer) es una arquitectura de software utilizada para crear servicios web. 

Prinicpales características y utilidades:

- Definición: REST establece cómo un módulo de software se comunica o interactúa con otro para cumplir una o muchas funciones.
- **Comunicación entre Aplicaciones**: con REST, es posible compartir recursos y datos entre diferentes dispositivos y aplicaciones de manera eficiente y escalable. Por ejemplo, cuando abres un juego en tu teléfono móvil y te conectas a tu cuenta de Facebook para iniciar sesión, estás utilizando una API REST. También, cuando una aplicación te envía notificaciones al móvil o al ordenador, está utilizando una API REST.
- Estado **Stateless**: la clave de REST es que un servicio REST no tiene estado (es stateless). Esto significa que, entre dos llamadas cualesquiera, el servicio pierde todos sus datos. El cliente debe pasar el estado en cada llamada, como un usuario y una contraseña o un token.
- **Escalabilidad**: aunque no tener estado puede ser tedioso al tener que pasar información en cada llamada, esta característica permite una mayor escalabilidad. Mantener un estado requiere memoria, y a más clientes, más memoria se necesita. REST evita este problema al no mantener estado en el servidor.
- 
En resumen, REST es una interfaz para conectar sistemas basados en el protocolo **HTTP**, permitiendo la comunicación entre diferentes componentes de una aplicación de manera eficiente y siguiendo estándares web como XML y JSON.


El equipo de [Platzi](https://platzi.com/) destaca así sus características principales:

- Estilo de arquitectura para el diseño de interfaces web
- Permite el manejo de recursos desde el lado del servidor
- Contiene las siguientes propiedades:
    - Rendimiento
    - Escalabilidad
    - Simplicidad
    - Confiabilida

## HTTP Verbs
Una de las reglas que tiene REST indica que debemos utilizar una seria de *verbos* a la hora de llamar a la API para indicar cuál es la acción que vamos a ejecutar. Los principales son:

- **GET**: Permite obtener y leer recursos.
- **POST**: Creación de recursos.
- **PUT**: Actualización de un registro.
- **PATCH**: Actualización parcial de un registro.
- **DELETE**: Eliminación de un registro

## Manejo de URLs
REST nos indica que debemos manejar una URL por cada recurso que tengamos en la base de datos. Esa URL no puede ser dinámica y debe indicar claramente cual es el recurso al que estamos accediendo.

- URI: los recursos en REST siempre se manipulan a partir de la URL, identificadores universales de recursos.
- Se necesita una URL por recurso.
 
 Ejemplo: /api/users/1


## Respuestas HTTP
**(100–199)** Respuestas informativas  
**(200–299)** Respuestas satisfactorias  
**(300–399)** Redirecciones  
**(400–499)** Errores de los clientes  
**(500–599)** Errores de los servidores    


Entre las respuestas más utilizadas encontramos:
- 500 - Internal error
- 200 - Ok codigo exitoso
- 404 - Not found (recurso no encontrado)
- 201 - Created, recurso creado
- 204 - No content - no hay contenido retornado











