# Día 4. Desarrollo del módulo de captura
## Sistema de Administración de Asientos de Cine

### 1. Descripción del módulo

El módulo de captura permite al usuario interactuar con el sistema mediante el ingreso de datos para seleccionar y administrar los asientos de la sala de cine.

### 2. Datos capturados

Para realizar una operación, el sistema solicita dos datos:

- **Fila:** identifica la ubicación vertical del asiento mediante letras de la A a la E.
- **Columna:** identifica la ubicación horizontal del asiento mediante números del 1 al 8.

### 3. Funciones desarrolladas

**Reservar asiento:** solicita la fila y columna, verifica que la ubicación exista y comprueba que el asiento esté disponible. Si cumple las condiciones, modifica su valor en la matriz de 0 a 1.

**Liberar asiento:** solicita la ubicación, comprueba que el asiento esté ocupado y modifica su valor de 1 a 0 para dejarlo disponible.

### 4. Validaciones implementadas

El sistema verifica que:

- La fila ingresada esté entre A y E.
- La columna ingresada sea un número entre 1 y 8.
- No se intente reservar un asiento que ya esté ocupado.
- No se intente liberar un asiento que ya esté disponible.
- Los datos ingresados tengan un formato válido.

### 5. Actualización de la matriz

La información se almacena en una matriz bidimensional de 5 filas y 8 columnas.

- 0 representa un asiento disponible.
- 1 representa un asiento ocupado.

Cada reservación o liberación actualiza directamente la posición correspondiente de la matriz.

### 6. Resultado obtenido

Se desarrolló un módulo funcional que permite registrar reservaciones y liberar asientos, manteniendo actualizada la disponibilidad de los 40 lugares de la sala.