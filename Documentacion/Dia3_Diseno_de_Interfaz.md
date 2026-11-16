# Día 3. Diseño de interfaz
## Sistema de Administración de Asientos de Cine

### 1. Descripción de la interfaz

El sistema contará con una interfaz de consola desarrollada en C#. Su diseño busca facilitar la interacción del usuario mediante un menú principal que presenta las diferentes operaciones disponibles.

### 2. Elementos de la interfaz

- **Título:** identifica el sistema de administración de asientos.
- **Pantalla:** representa la parte frontal de la sala de cine.
- **Matriz de asientos:** muestra los 40 lugares organizados en cinco filas y ocho columnas.
- **Menú principal:** permite seleccionar las operaciones del sistema.
- **Entrada de opción:** recibe la selección del usuario.
- **Mensajes:** muestran confirmaciones, resultados y errores.

### 3. Distribución de la interfaz

La interfaz se divide en tres secciones:

1. Encabezado: presenta el nombre del sistema y la pantalla del cine.
2. Área de asientos: representa la distribución y disponibilidad de los lugares.
3. Área de operaciones: muestra el menú principal y recibe las instrucciones del usuario.

### 4. Identificación visual de los asientos

Se utilizan dos indicadores para representar el estado de cada asiento:

- **[L]:** asiento disponible.
- **[X]:** asiento ocupado.

### 5. Justificación del diseño

Se eligió una interfaz de consola porque permite desarrollar un sistema sencillo, funcional y fácil de utilizar, además de facilitar la implementación de matrices bidimensionales y operaciones de control de disponibilidad.