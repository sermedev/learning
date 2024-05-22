namespace DesignPatterns.Patterns.Creational.Singleton
{
    // La clase Singleton define el método `GetInstance` como alternativa al constructor.
    // Permite a los clientes acceder a la misma instancia repetidas veces.
    // Singleton debe ser siempre una clase 'sealed' para prevenir la herencia 
    // a través de clases externas y también a través de clases anidadas.
    public sealed class Singleton
    {
        // El constructor debe ser siempre privado para prevenir
        // llamadas directas de construcción con el operador "new".
        private Singleton() { }

        // La instancia del Singleton se almacena en un campo estático.
        // Existen varias formas de inicializar este campo, todas tienen pros y contras.
        // En este ejemplo mostraremos la más simple de estas formas,
        // que, sin embargo, no funciona muy bien en programas multihilo
        private static Singleton _instance;

        // Este es el método estático que controla el acceso a la instancia singleton.
        // En la primera ejecución, crea un objeto singleton y lo asigna en el campo estático.
        // En las siguientes ejecuciones, devuelve el objeto existente almacenado en el campo estático
        public static Singleton GetInstance(string value)
        {
            if (_instance == null)
            {
                _instance = new Singleton();
                _instance.Value = value;
            }
            return _instance;
        }

        // Por último, cualquier singleton definirá alguna lógica de negocio para ser ejecutada
        public void DoSomething(string messageToShow)
        {
            // For examplo write a trace
        }


        // Usaremos esta propiedad para probar que nuestro Singleton realmente funciona.
        public string Value { get; set; }
    }
}
