namespace DesignPatterns.Patterns.Creational.Singleton
{
    // El patrón Sigletón standart podría llegar a tener problemas de concurrencia 
    // en algunas circusntacias. Por suerte existen algunas estrategias para 
    // fortalecer nuestro patrón.
    class SingletonSafeThreads

    {
        private SingletonSafeThreads() { }

        private static SingletonSafeThreads _instance;

        // Creamos un objeto de bloqueo que se usará para sincronizar hilos
        // durante el primer acceso al Singleton.
        private static readonly object _lock = new object();

        public static SingletonSafeThreads GetInstance(string value)
        {
            // Esta condicional es necesaria para evitar que los hilos tropiecen con el
            // bloqueo una vez que la instancia está lista.
            if (_instance == null)
            {
                // Ahora, imagine que el programa acaba de lanzarse. Dado que
                // aún no hay instancia Singleton, múltiples hilos pueden
                // pasar simultáneamente el condicional anterior y llegar a este
                // punto casi al mismo tiempo. El primero de ellos adquirirá
                // el bloqueo y seguirá adelante, mientras que el resto esperará aquí.
                lock (_lock)
                {
                    // El primer hilo que adquiere el bloqueo, alcanza esta
                    // condicional, entra y crea la instancia Singleton
                    // instancia. Una vez que abandona el bloqueo, un hilo que
                    // podría haber estado esperando la liberación del bloqueo puede entonces
                    // entrar en esta sección. Pero como el campo Singleton
                    // ya inicializado, el hilo no creará un nuevo
                    // objeto.
                    if (_instance == null)
                    {
                        _instance = new SingletonSafeThreads();
                        _instance.Value = value;
                    }
                }
            }
            return _instance;
        }

        // Usaremos esta propiedad para probar que nuestro Singleton realmente funciona.
        public string Value { get; set; }
    }
}
