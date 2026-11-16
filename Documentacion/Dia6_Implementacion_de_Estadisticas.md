# Día 6. Implementación de estadísticas
## Sistema de Administración de Asientos de Cine

### 1. Descripción del módulo
El módulo de estadísticas permite conocer el estado general de ocupación de la sala de cine mediante el conteo de los asientos disponibles y ocupados.

### 2. Datos utilizados
Para calcular las estadísticas, el sistema utiliza la matriz de 5 filas por 8 columnas, que representa los 40 asientos de la sala.

- `0`: asiento disponible.
- `1`: asiento ocupado.

### 3. Procesamiento de la información
El sistema recorre todas las posiciones de la matriz mediante ciclos y cuenta cuántos asientos están ocupados y cuántos están disponibles.

Posteriormente, calcula el porcentaje de ocupación utilizando la siguiente fórmula:

\[
\text{Porcentaje de ocupación} =
\frac{\text{Asientos ocupados}}{\text{Total de asientos}} \times 100
\]

### 4. Resultados mostrados
El sistema presenta:
- Total de asientos: 40.
- Cantidad de asientos ocupados.
- Cantidad de asientos disponibles.
- Porcentaje de ocupación de la sala.

### 5. Resultado obtenido
Se implementó un módulo que procesa la información almacenada en la matriz y presenta estadísticas actualizadas sobre la ocupación de la sala de cine.