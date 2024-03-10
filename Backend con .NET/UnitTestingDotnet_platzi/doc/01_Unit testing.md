# Unit testing

```
⚠️ Las pruebas unitarias en .NET son una práctica esencial en el desarrollo de software
```

## ¿Qué son las pruebas unitarias?
- Las pruebas unitarias son pequeños fragmentos de código que verifican el comportamiento de una **unidad aislada** de código, como una función, método o clase
- Se centran en probar una parte específica del código, sin depender de otras partes del sistema


## Beneficios de las pruebas unitarias
- **Ahorro de tiempo**: Las pruebas unitarias son rápidas y automáticas, lo que ahorra tiempo en comparación con las pruebas funcionales manuales
- **Protección contra regresiones**: Detectan errores cuando se realizan cambios en el código, evitando que se rompa la funcionalidad existente
- **Documentación ejecutable**: Cada prueba unitaria describe claramente el comportamiento esperado de una acción
- Son facilmente **automatizables**
- Son facilmente **reutilizables**
- Son fáciles de implementar


## Herramientas populares para pruebas unitarias en .NET
- **xUnit**: Una herramienta gratuita de pruebas unitarias de código abierto centrada en la comunidad para aplicaciones .NET
  - Creada por la comunidad
  - Open source con gran soporte
  - Simplifica todo el proceso de creación de pruebas
  - Una de las más populares para nuevos y modernos proyectos con .NET
  - Ejemplo:
    ```cs
    [Fact]
    public void MyTest()
    {
        var objectToTest= new MyClass();
        string result = objectToTest.Method();
        Assert.Equal("MyResult", result);
    }
    ```
- **NUnit**: Otra opción popular para escribir pruebas unitarias en .NET
  - JUnit para .NET
  - Opensource con gran soporte
  - Muy fácil de usar
- **MSTest**
    - Microsoft Test
    - Gran soporte por el equipo de Microsoft
    - Excelente integración con Visual Studio
    - Alta complejidad para algunos     escenarios


En resumen, las pruebas unitarias son fundamentales para garantizar la calidad del código, la detección temprana de errores y la documentación efectiva del comportamiento del software.

