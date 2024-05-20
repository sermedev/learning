# Repaso de Programación Orientada a Objetos

Antes de comenzar con el curso es necesario repasar conceptos básicos de la programación orientada a objetos.

## Clases y objetos
- **Clase**: Una clase es como un plano o molde que define la estructura y el comportamiento de un objeto. Contiene atributos (propiedades) y métodos (funciones).
- **Objeto**: Un objeto es una instancia de una clase. Representa un elemento concreto y tiene sus propios valores para los atributos y puede ejecutar los métodos definidos en la clase.
- Ejemplo de código:
    ```c#
        class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
        }

        // Crear un objeto de la clase Persona
        var persona1 = new Persona();
        persona1.Nombre = "Juan";
        persona1.Edad = 30;
    ```

## Herencia
- La herencia permite definir una clase base (superclase) que proporciona funcionalidad específica, y clases derivadas (subclases) que heredan o modifican esa funcionalidad.
- Ejemplo de código:
    ```c#
        class Animal
        {
            public void EmitirSonido()
            {
                Console.WriteLine("Hace un sonido genérico.");
            }
        }

        class Perro : Animal
        {
            public void Ladrar()
            {
                Console.WriteLine("¡Guau guau!");
            }
        }

        // Crear un objeto de la clase Perro
        var miPerro = new Perro();
        miPerro.EmitirSonido(); // Salida: "Hace un sonido genérico."
        miPerro.Ladrar(); // Salida: "¡Guau guau!"
    ```

## Interfaces
- Una interfaz define un contrato que una clase debe cumplir. Es un conjunto de métodos, propiedades, eventos e indizadores que una clase debe implementar.
- Ejemplo de código:
    ```c#
    interface IReproductorMusica
    {
        void Reproducir();
        void Pausar();
    }

    class ReproductorMP3 : IReproductorMusica
    {
        public void Reproducir()
        {
            Console.WriteLine("Reproduciendo música...");
        }

        public void Pausar()
        {
            Console.WriteLine("Pausa.");
        }
    }

    // Crear un objeto de la clase ReproductorMP3
    var reproductor = new ReproductorMP3();
    reproductor.Reproducir(); // Salida: "Reproduciendo música..."
    reproductor.Pausar(); // Salida: "Pausa."
    ```
