# Base de datos ReyV1

Scripts de inicialización para SQL Server 2014. Ejecutar en orden numérico para crear la base de datos y datos iniciales.

## Pasos

1. Ajustar los scripts para apuntar a su instancia de SQL Server si es necesario.
2. Ejecutar `001_create_database.sql` para crear la base de datos y tablas básicas.
3. Ejecutar `002_seed_data.sql` para insertar datos de ejemplo.

Se recomienda versionar cualquier cambio en la estructura a través de scripts incrementales numerados.
