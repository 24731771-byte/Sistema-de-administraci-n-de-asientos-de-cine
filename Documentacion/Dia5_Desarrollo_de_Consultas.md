# Día 5. Desarrollo de consultas
## Sistema de Administración de Asientos de Cine

### 1. Descripción del módulo
El módulo de consultas permite al usuario conocer el estado de los asientos de la sala de cine sin modificar la información almacenada en la matriz.

### 2. Consulta de disponibilidad
El sistema solicita al usuario la fila y columna del asiento que desea consultar.

Después de recibir los datos, verifica que la ubicación sea válida y revisa el valor correspondiente en la matriz.

### 3. Información mostrada
- Si el valor es `0`, el asiento está disponible.
- Si el valor es `1`, el asiento está ocupado.

### 4. Validaciones implementadas
- La fila debe estar entre A y E.
- La columna debe estar entre 1 y 8.
- Los datos deben tener un formato válido.
- El asiento consultado debe pertenecer a la matriz.

### 5. Consulta general de asientos
El sistema también permite visualizar todos los asientos de la sala mediante una representación de la matriz:

- `[L]` representa un asiento libre.
- `[X]` representa un asiento ocupado.

### 6. Resultado obtenido
Se desarrolló un módulo que permite consultar individualmente la disponibilidad de los asientos y visualizar el estado general de la sala, facilitando la administración de las reservaciones.