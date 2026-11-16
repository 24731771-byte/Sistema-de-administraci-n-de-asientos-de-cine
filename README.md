# Sistema de Administración de Asientos de Cine

## Descripción
Este proyecto consiste en un sistema de administración de asientos para una sala de cine, desarrollado en C# mediante una aplicación de consola.

El sistema permite visualizar los asientos, realizar reservaciones, liberar asientos, consultar su disponibilidad y mostrar estadísticas de ocupación.

## Características
- Sala de cine representada mediante una matriz de 5 filas por 8 columnas.
- Administración de 40 asientos.
- Reservación de asientos disponibles.
- Liberación de asientos ocupados.
- Consulta individual de disponibilidad.
- Visualización general de los asientos.
- Estadísticas de ocupación y disponibilidad.
- Validación de los datos ingresados.

## Representación de los asientos
- `0`: asiento disponible.
- `1`: asiento ocupado.
- `[L]`: asiento libre en pantalla.
- `[X]`: asiento ocupado en pantalla.

## Estructura del proyecto

- `CodigoFuente/`: contiene el código fuente del sistema.
- `Documentacion/`: contiene la documentación de las siete etapas de desarrollo.
- `Evidencias/`: contiene capturas de pantalla del funcionamiento del programa.

## Requisitos
- .NET SDK 10.0 o compatible con el proyecto.
- Visual Studio Code o un editor compatible.
- Terminal de comandos.

## Ejecución
Desde la carpeta principal del proyecto, ejecutar:

```powershell
dotnet run --project .\CodigoFuente\SistemaCine.csproj
```

## Autor
Proyecto académico desarrollado individualmente.