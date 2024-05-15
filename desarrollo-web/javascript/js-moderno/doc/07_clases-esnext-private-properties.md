# Clases en JavaScript y ESNext private properties


- [Clases en JavaScript y ESNext private properties](#clases-en-javascript-y-esnext-private-properties)
  - [Prototypes vs clases](#prototypes-vs-clases)
  - [Problematica de prototipos](#problematica-de-prototipos)
  - [Clases](#clases)
  - [Sets](#sets)
  - [Gets](#gets)
  - [Métodos estáticos](#métodos-estáticos)
  - [Gets estáticos](#gets-estáticos)
  - [ESNext: Propiedades privadas (aún no soportado completamente)](#esnext-propiedades-privadas-aún-no-soportado-completamente)
  - [Singletons](#singletons)
  - [Multiples constructores](#multiples-constructores)


## Prototypes vs clases 

1. **Prototipos** 
   - JavaScript es un lenguaje basado en prototipos. Los objetos heredan propiedades y métodos de otros objetos a través de una cadena de prototipos.
   - Los prototipos ofrecen flexibilidad y control. Puedes modificar y extender objetos existentes dinámicamente.
   - Ejemplo:
        ```javascript
        function Persona(nombre) {
            this.nombre = nombre;
        }
        Persona.prototype.saludar = function() {
            return `¡Hola, ${this.nombre}!`;
        };
        ```

2. **Clases**

   - A partir de *ES6*, JavaScript introdujo la palabra clave `class`. Las clases son **azúcar sintáctico** sobre el sistema de prototipos.
   - Proporcionan una sintaxis más limpia y familiar para crear objetos y métodos.
   - Ejemplo:
       ```javascript
       class Persona {
           constructor(nombre) {
               this.nombre = nombre;
           }
           saludar() {
               return `¡Hola, ${this.nombre}!`;
           }
       }
       ```

3. **¿Cuál es mejor?**
   - Depende del contexto:
       - **Prototipos**: Útiles cuando necesitas flexibilidad y personalización dinámica.
       - **Clases**: Ofrecen una estructura más organizada y fácil de entender.
   - Como desarrollador, debes estar cómodo con ambos enfoques y elegir según los requisitos del proyecto.

   En resumen, **ambos** tienen sus ventajas



🎯 En este curso nos decantaremos por **Clases** ya que se está asentando como un estándar en la industria. 



## Problematica de prototipos

JavaScript es un lenguaje dinámico que utiliza prototipos para implementar la herencia. Aunque los prototipos son poderosos, también pueden presentar algunas problemáticas:

1. **Complejidad**:
    - La sintaxis de prototipos puede ser confusa para desarrolladores acostumbrados a lenguajes basados en clases.
    - La cadena de prototipos puede volverse complicada al seguir múltiples niveles de herencia.
2. **Herencia no intuitiva**:
   - La herencia basada en prototipos no sigue un modelo de clases tradicional.
   - No existe una relación directa entre una clase y su prototipo.
3. **Sintaxis verbosa**:
   - Definir métodos y propiedades en el prototipo puede ser más verboso que usar la sintaxis de clases.
4. **Necesidad de organización**:
   - Las clases proporcionan una estructura más organizada y fácil de entender.
   - La palabra clave class (introducida en ES6) simplifica la creación de objetos y métodos.


En resumen, las clases ofrecen una alternativa más clara y familiar para crear objetos en JavaScript. Sin embargo, los prototipos siguen siendo útiles para la flexibilidad y personalización dinámica.


## Clases
## Sets
## Gets
## Métodos estáticos
## Gets estáticos
## ESNext: Propiedades privadas (aún no soportado completamente)
## Singletons
## Multiples constructores