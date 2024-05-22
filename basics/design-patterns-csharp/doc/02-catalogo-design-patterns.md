# Catálogo de patrones de diseño

## Patrones creacionales

### Singleton 🕴️
Singleton nos permite asegurarnos de que una clase tenga una única instancia. Proporciona un punto de acceso global a dicha instancia.

✅ **USO RECOMENDADO**
- **Gestión de configuraciones**
  Cuando necesitas almacenar configuraciones que deben ser consistentes y accesibles desde diferentes módulos, el Singleton es una opción válida.
- **Acceso a una base de datos**
  Si deseas tener una única instancia de una clase para acceder a una base de datos desde cualquier parte del código, el Singleton es apropiado.
- **Gestión de Logs**
  Para centralizar la gestión de logs y asegurar que sólo haya una instancia encargada de registrar eventos, el Singleton es una buena opción.

❌ **USO NO RECOMENDADO**
- No lo uses para almacenar **datos sensibles**. 
  La disponibilidad global del Singleton dificulta rastrear qué partes del programa están afectadas si se realizan cambios en él.
- Evita usarlo en **situaciones concurrentes sin tomar precauciones** adecuadas. Si hay llamados concurrentes al Singleton, pueden surgir problemas. En este caso sería necesaria una implementación especial y segura del Singleton.


⚠️ **CONSIDERACIONES**
 
 - El patrón singleton habitual puede dar problemas en determinadas circunstancias como el uso de hilos o reflexión. Procura implementar el patrón de una manera robusta.

- Muchos desarrolladores consideran el patrón Singleton un antipatrón. Por este motivo, su uso está en declive en el código C#.