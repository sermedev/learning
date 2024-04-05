# Buenas prácticas en xUnit

## Nomenclatura
- El proyecto de pruebas se llamará como nuestro proyecto a probar + "Test" 

    `MyProject -> MyProject.Tests`

- Cada clase de prueba se llamará como nuestra clase a probar + "Test" 
  
  `MyClass -> MyClassTest`


## Estructura de cada caso de prueba
En cada caso de pruebas deberemos seguir la **Estructura AAA**. Se refiere al orden del código interno en nuestra prueba:
1. **Arrange**: configurar datos iniciales u objetos requeridos
2. **Act**: ejecución de la prueba. Crearemos variables para guardar el resultado.
3. **Assert**: comprobar el resultado.

Esta simple estructura se traducirá en una prueba fácil de leer y de mantener por otros desarrolladores (o nosotros mismos).

## Principios F.I.R.S.T

1. Rápido (**Fast**):
    - Las pruebas unitarias deben ejecutarse rápidamente.
    - Se centran en tareas específicas y evitan comunicación en red o operaciones de base de datos.
    - La ejecución frecuente durante el desarrollo ayuda a detectar problemas temprano.
2. Independiente (**Independent**):
    - Cada prueba unitaria debe ser independiente de las demás.
    - No debe depender de los resultados de otras pruebas.
    - Aísle el código bajo prueba de sus dependencias (a menudo mediante mocks o stubs).
3. Repetible (**Repeatable**):
    - Una prueba unitaria debe producir el mismo resultado al ejecutarse varias veces.
    - Independiente del entorno y consistente en diferentes máquinas.
    - Parámetros de entrada predefinidos aseguran la repetibilidad.
4. Autovalidante (**Self-validating**):
    - Las pruebas unitarias validan sus propios resultados.
    - No se necesitan comprobaciones manuales después de la finalización de la prueba.
    - Decisión clara de aprobado o fallido basada en la salida de la función bajo prueba.
5. Exhaustivo (**Thorough**) y Oportuno (**Timely**):
    - Pruebe exhaustivamente todos los escenarios relevantes.
    - Los desarrolladores que practican el desarrollo dirigido por pruebas aseguran una cobertura completa.
   - Las pruebas deben ser oportunas: creadas temprano y mantenidas durante todo el desarrollo .