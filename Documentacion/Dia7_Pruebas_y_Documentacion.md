# Día 7. Pruebas y documentación
## Sistema de Administración de Asientos de Cine

### 1. Objetivo de las pruebas
Comprobar que las funciones del sistema trabajen correctamente, que los datos se validen y que la disponibilidad de los asientos se actualice de acuerdo con las operaciones realizadas.

### 2. Pruebas realizadas

| Prueba | Acción | Resultado esperado |
|---|---|---|
| 1 | Mostrar los asientos | Visualizar los 40 asientos y su estado |
| 2 | Reservar un asiento disponible | Cambiar su estado a ocupado |
| 3 | Reservar un asiento ocupado | Mostrar un mensaje indicando que ya está ocupado |
| 4 | Liberar un asiento ocupado | Cambiar su estado a disponible |
| 5 | Liberar un asiento disponible | Mostrar un mensaje indicando que ya está disponible |
| 6 | Consultar un asiento libre | Informar que está disponible |
| 7 | Consultar un asiento ocupado | Informar que está ocupado |
| 8 | Ingresar una fila o columna inválida | Mostrar un mensaje de error |
| 9 | Ingresar una opción incorrecta en el menú | Informar que la opción no es válida |
| 10 | Mostrar estadísticas | Presentar los totales y el porcentaje de ocupación |

### 3. Resultados de las pruebas
Las funciones principales del sistema fueron ejecutadas y probadas. Se comprobó el funcionamiento de las operaciones de visualización, reservación, liberación, consulta y estadísticas.

También se probaron entradas inválidas para verificar que el sistema rechazara ubicaciones y opciones incorrectas.

### 4. Evidencias
En esta sección se agregarán capturas de pantalla que demuestren el funcionamiento de las operaciones principales del sistema.

### 5. Conclusión
El sistema cumple con las funciones establecidas para administrar los 40 asientos de una sala de cine. Permite reservar, liberar y consultar asientos, además de mostrar estadísticas sobre la ocupación.

Las pruebas permitieron comprobar el funcionamiento de las operaciones y la validación de los datos ingresados.