# Coverlet
- Es un proyecto de **código abierto** en GitHub.
- Proporciona un marco de cobertura de código **multiplataforma**
- Soporta **.NET Framework** y **.NET Core**. 
- Es parte de la .NET Foundation.
- Coverlet recopila datos de series de pruebas de cobertura, que se utilizan para la **generación de informes**.
- Funciona con VSTest, NUnit, XUnit y otros

[🔗 +Info](https://learn.microsoft.com/es-es/dotnet/core/testing/unit-testing-code-coverage?tabs=windows)

## Comenzando con converlet

1. Instalar paquetes necesarios:
   - `coverlet.collector`. Se puede instalar con Nuget
   - `coverlet.msbuild`. Se puede instalar con Nuget
  
2. Instalar herramienta `converlet.console`
   - Buscar en [nuget.org](https://www.nuget.org/) la herramienta `converlet.console`
   - Copiar el comando de instalación. En mi caso:
       > dotnet tool install --global coverlet.console --version 6.0.1
   - Ejecutar en la terminal de Visual Studio.


3. Ejecutar comando para comprobar la cobertura:
    > dotnet test /p:CollectCoverage=true

    Esto ejecutará la pruebas y analizará la cobertura, dando unos porcentajes obtenidos. Ejemplo:

    >   
        +-------------+--------+--------+--------+
        | Module      | Line   | Branch | Method |
        +-------------+--------+--------+--------+
        | StringUtils | 30.16% | 45.83% | 61.11% |
        +-------------+--------+--------+--------+

        +---------+--------+--------+--------+
        |         | Line   | Branch | Method |
        +---------+--------+--------+--------+
        | Total   | 30.16% | 45.83% | 61.11% |
        +---------+--------+--------+--------+
        | Average | 30.16% | 45.83% | 61.11% |
        +---------+--------+--------+--------+


## Atributos de configuración

Algunos atributos de configuración relevantes para Coverlet:

1. Exclusión e inclusión de ensamblados:
   - Puedes especificar los ensamblados que deseas excluir o incluir en la cobertura utilizando las opciones `--exclude` y `--include`.
   - También puedes incluir la cobertura del propio ensamblado de pruebas especificando la bandera `--include-test-assembly`.
  
2. SourceLink:
   - Coverlet admite **SourceLink**, que es información de depuración personalizada contenida en los archivos PDB.
  
3. Opciones de formato de salida:
   - Por defecto, el formato de salida del informe de cobertura es cobertura (cobertura.cobertura.xml).
   - Puedes cambiar el formato de salida utilizando la opción `--coverletOutputFormat`.
  
4. Opciones adicionales:
    - Hay otras opciones disponibles, como `--exclude-by-attribute`, `--threshold`, `--merge-with`, etc. [Puedes consultar la documentación para obtener detalles completos sobre estas opciones.](https://github.com/coverlet-coverage/coverlet/blob/master/Documentation/VSTestIntegration.md)
  
Recuerda que Coverlet es una herramienta versátil y puedes personalizar su comportamiento según tus necesidades específicas


## Ejemplos de comandos para nuestro proyecto

- Ejecutar los tests con Coverlet.
    > dotnet test /p:CollectCoverage=true

- Incluir solo los namespace que queremos ejecutar con Coverlet.
    > dotnet test /p:CollectCoverage=true /p:Include="[\*]NameSpace.*"

    En nuestro caso: 

    > dotnet test /p:CollectCoverage=true /p:Include="[\*]StringUtils.\*"

- A nivel de código, podemos excluir clases o métodos que no necesitamos tener en cuenta en el análisis de cobertura. Para ello basta con colocar el atributo *[ExcludeFromCodeCoverage]* al principio de nuestra clase o método.


## Reporte de cobertura

- Comando para obtener reporte de cobertura en json (basta con ejecutar el comando básico de análisis):
    > dotnet test /p:CollectCoverage=true 

- Comando para obtener reporte de cobertura en xml:
    > dotnet test /p:CollectCoverage=true /p:coverletOutputFormat=cobertura

Ambos reportes (json o xml) son completos pero difíciles de leer. Para ayudarnos con el análsis tenemos una librería especial que nos generará informes más "legibles". Se trata de *ReportGenerator*.
  

### Report Generator

[Report Generator](https://github.com/danielpalme/ReportGenerator) es un librería para obtener reportes de cobertura con Coverlet más legibles. Se puede instalar desde el gestor de paquetes de *NuGet*. Instalarlo como herramienta global (*dotnet-reportgenerator-globaltool*):
> dotnet tool install --global dotnet-reportgenerator-globaltool --version 5.2.2

El comando para obtener el report sería:
> reportgenerator "-reports:StringUtilsTest\coverage.cobertura.xml" "-targetdir:StringUtilsTest\coverage-report" -reporttypes:html;