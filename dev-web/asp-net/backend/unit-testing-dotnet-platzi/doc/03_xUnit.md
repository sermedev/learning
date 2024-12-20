# xUnit

**xUnit** es un marco de pruebas unitarias gratuito, de código abierto y centrado en la comunidad para el .NET Framework. Fue escrito por el creador original de NUnit v2 y es la tecnología más reciente para realizar pruebas unitarias en C#, F#, VB.NET y otros lenguajes de .NET

## Estructura básica de un test en xUnit

Un test en xUnit se compone de un método que verifica si una parte específica del código funciona correctamente. 

Por ejemplo, consideremos una clase Calculator con un método Add que suma dos números. Un test básico podría ser:

```cs
using Xunit;

public class CalculatorTests
{
    [Fact]
    public void Add_TwoNumbers_ReturnsSum()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Add(3, 5);

        // Assert
        Assert.Equal(8, result);
    }
}
```
En este ejemplo, estamos probando si el método `Add` devuelve la suma correcta de dos números.

## Teorías en xUnit

Las teorías en xUnit permiten probar un conjunto de datos con un solo test.

Por ejemplo, si queremos probar si el método `IsPrime` de una clase `PrimeService` funciona correctamente para varios números, podemos usar una teoría:

```cs
using Xunit;

public class PrimeServiceTests
{
    [Theory]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(5)]
    public void IsPrime_ReturnsTrueForPrimes(int number)
    {
        var primeService = new PrimeService();
        var result = primeService.IsPrime(number);
        Assert.True(result);
    }
}
```
Aquí, estamos probando si el método `IsPrime` devuelve `true` para los números 2, 3 y 5.


## Aserciones en xUnit

Las aserciones son declaraciones que verifican si una condición es verdadera o falsa.

Por ejemplo, en el test anterior, usamos `Assert.True(result)` para verificar si el resultado es verdadero.

En resumen, xUnit es una herramienta poderosa para realizar pruebas unitarias en .NET, y su sintaxis es clara y concisa. Puedes encontrar más información en la [documentación oficial de xUnit](https://xunit.net/).