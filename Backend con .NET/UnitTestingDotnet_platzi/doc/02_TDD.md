# Test Driven Development


📝 Las siguientes notas han sido extraídas de 
[devexpert.io](https://devexpert.io/test-driven-development-tdd/) y [inesdi.com](https://www.inesdi.com/blog/que-es-TDD-test-driven-development/)


TDD (**Test Driven Development**) es un enfoque de desarrollo de software en el que los desarrolladores escriben primero las pruebas antes de escribir el código.

La idea es escribir las pruebas primero para asegurarse de que el código cumpla con los requisitos específicos y también para identificar errores de manera temprana en el proceso de desarrollo.


## La rueda del TDD
Aplicar TDD implica seguir los siguientes pasos:

1. **Escribir una prueba que falle**: Primero, se escribe una prueba que se espera que falle. Esto ayuda a establecer un objetivo claro para el desarrollo y a identificar los requisitos del código.
2. **Escribir código para hacer que la prueba pase**: A continuación, se escribe el código necesario para hacer que la prueba pase.
3. **Refactorizar** el código: Una vez que la prueba pasa, se puede refactorizar el código para hacerlo más limpio y eficiente.
4. **Repetir** el proceso: Se repite este proceso para cada prueba adicional hasta que todas las pruebas pasen y el código esté completo.



## Ventajas del TDD
Hay muchos beneficios al usar TDD en desarrollo de software, incluyendo:

1. Mayor calidad del código: Al escribir pruebas antes del código, te aseguras de que el software cumpla con los requisitos y detectes errores temprano.
2. Menos tiempo de depuración: Al detectar errores temprano, pasarás menos tiempo corrigiendo problemas y más tiempo creando nuevas funcionalidades.
3. Mejor documentación: Las pruebas te ayudan a documentar cómo usar el software, especialmente cuando otras personas o equipos lo usan.
4. Mayor confianza en el código: Al tener pruebas automatizadas que prueban el software, puedes estar seguro de que sigue funcionando correctamente después de cada cambio.


## Inconvenientes de usar TDD
Aunque el TDD tiene muchas ventajas, también existen algunos inconvenientes:

1. Aprendizaje: Requiere tiempo y práctica para aprender a escribir pruebas efectivas y eficientes.
Tiempo adicional: Escribir pruebas puede llevar más tiempo que escribir solo el código, especialmente al principio.
2. Cambios constantes en el código: Al hacer cambios en el código, puede ser necesario actualizar las pruebas, lo que puede aumentar el tiempo de desarrollo.
3. Dificultad para probar código complejo: Puede ser difícil escribir pruebas para código complejo o con dependencias externas.
4. Tiempos de compilación: en Android son bastante altos, especialmente si tenemos que ejecutarlos en un dispositivo, y la rueda de tests se puede hacer complicada de manejar

A pesar de estos inconvenientes, muchos desarrolladores encuentran que el TDD es una práctica valiosa que vale la pena adoptar. Con el tiempo, puede reducir la cantidad de errores y mejorar la calidad del software, lo que compensa el tiempo inicial invertido.



## ¿Qué diferencia a Test Driven Development de otros métodos de prueba?
La principal característica que hace diferente a esta metodología es que está basada en test o pruebas que guían el proceso. Esto es todo lo contrario a lo que ocurre en otras metodologías en las que lo que se hace es posponer los test a un momento posterior en el tiempo.

A partir del TDD se ha desarrollado el **BDD** (Behavior Driven Development), una metodología que se guía por el comportamiento que se quiere conseguir con el software. Se suele decir que el BDD es la mejor manera de diseñar pruebas y que el TDD proporciona una arquitectura más limpia.