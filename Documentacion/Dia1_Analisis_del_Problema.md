# Día 1. Análisis del problema
## Sistema de Administración de Asientos de Cine

### 1. Descripción del problema
En una sala de cine es necesario administrar los asientos para conocer cuáles están disponibles y cuáles se encuentran ocupados. Realizar este control manualmente puede provocar errores al momento de reservar, liberar o consultar un asiento.

Por esta razón, se propone desarrollar un sistema de administración de asientos utilizando el lenguaje C#, que permita controlar la disponibilidad de los lugares mediante una matriz bidimensional.

El sistema contará con una sala de 5 filas y 8 columnas, para un total de 40 asientos.

### 2. Identificación de entradas
Las entradas son los datos que el usuario proporciona al sistema para realizar las operaciones.

- **Opción del menú:** selecciona la operación que desea realizar.
- **Fila:** identifica la fila del asiento, utilizando letras de la A a la E.
- **Columna:** identifica el número del asiento, utilizando números del 1 al 8.

También se reciben entradas para validar que el usuario haya escrito información correcta.

### 3. Identificación de procesos
Los procesos son las operaciones que realiza el programa para administrar los asientos.

- **Inicializar matriz:** crear una matriz de 5 filas y 8 columnas con todos sus valores en 0.
- **Mostrar asientos:** recorrer la matriz y mostrar el estado de cada asiento.
- **Reservar asiento:** validar la ubicación y cambiar su valor de 0 a 1.
- **Liberar asiento:** validar la ubicación y cambiar su valor de 1 a 0.
- **Consultar disponibilidad:** revisar el valor de un asiento para determinar si está ocupado o disponible.
- **Calcular estadísticas:** contar los asientos ocupados y disponibles y calcular el porcentaje de ocupación.
- **Validar entradas:** comprobar que las opciones, filas y columnas ingresadas sean válidas.

### 4. Identificación de salidas
Las salidas son los resultados que el sistema presenta al usuario después de procesar sus entradas.

- Menú principal con las opciones disponibles.
- Mapa de los 40 asientos.
- Confirmación de reservación.
- Confirmación de liberación.
- Resultado de la consulta de disponibilidad.
- Estadísticas de ocupación.
- Mensajes de error cuando se ingresan datos incorrectos o se intenta reservar un asiento ocupado.

### 5. Representación de la matriz
El sistema utiliza una matriz bidimensional de tipo entero:

`static int[,] asientos = new int[5, 8];`

Cada posición representa un asiento de la sala:

- **0:** asiento disponible.
- **1:** asiento ocupado.

La matriz contiene 5 filas y 8 columnas, por lo que permite administrar 40 asientos.

### 6. Objetivo general
Desarrollar un sistema de administración de asientos de cine mediante el lenguaje C#, utilizando matrices bidimensionales para controlar la disponibilidad de los lugares, realizar reservaciones, liberar asientos, consultar su estado y generar estadísticas de ocupación.

### 7. Alcance del sistema
El sistema permitirá administrar una sala de 40 asientos, reservar y liberar lugares individualmente, consultar su disponibilidad, visualizar el estado general de la sala y obtener estadísticas de ocupación.

El sistema funcionará mediante una interfaz de consola y almacenará temporalmente la información en una matriz durante la ejecución del programa.