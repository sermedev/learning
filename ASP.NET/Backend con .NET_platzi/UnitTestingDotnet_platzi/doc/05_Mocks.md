# Mocks
En xUnit, un Mock es un objeto simulado que se utiliza en pruebas unitarias para reemplazar dependencias reales. Estas dependencias pueden ser clases, interfaces o métodos que la clase bajo prueba utiliza. Los mocks se crean para aislar la funcionalidad específica que se está probando y para controlar su comportamiento durante las pruebas.

Aquí hay algunos puntos clave sobre los mocks en xUnit:
1. Propósito:
   - Los mocks se utilizan para simular el comportamiento de las dependencias reales sin ejecutar el código real.
   - Permiten probar una unidad de código de manera aislada, sin depender de componentes externos.
2. Creación de Mocks:
   - En xUnit, se suelen utilizar bibliotecas de mocking como **Moq** para crear mocks.
   - Estas bibliotecas proporcionan métodos para configurar el comportamiento esperado de los mocks.
3. Ejemplo de Uso: Supongamos que tienes una clase `UserService` que depende de una interfaz `IUserRepository`. Quieres probar el método GetUserById de `UserService`. Aquí está cómo podrías usar un mock:
   
    ```cs
    // Interfaz IUserRepository
    public interface IUserRepository
    {
        User GetUserById(int userId);
    }

    // Clase UserService
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public string GetUserNameById(int userId)
        {
            var user = _userRepository.GetUserById(userId);
            return user?.Name ?? "User not found";
        }
    }

    // Prueba unitaria con Moq
    [Fact]
    public void GetUserNameById_ReturnsUserName()
    {
        // Arrange
        var userId = 42;
        var expectedUserName = "John Doe";

        var userRepositoryMock = new Mock<IUserRepository>();
        userRepositoryMock.Setup(repo => repo.GetUserById(userId))
            .Returns(new User { Id = userId, Name = expectedUserName });

        var userService = new UserService(userRepositoryMock.Object);

        // Act
        var result = userService.GetUserNameById(userId);

        // Assert
        Assert.Equal(expectedUserName, result);
    }

    ```
    En este ejemplo, hemos creado un mock de `IUserRepository` utilizando Moq. Configuramos el comportamiento esperado del método `GetUserById` para que devuelva un usuario con el nombre “John Doe”. Luego, probamos el método `GetUserNameById` de `UserService`.