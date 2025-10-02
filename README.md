# ReyV1 Base

Proyecto base con frontend en Vue 3 + TypeScript + Bootstrap 5, backend en .NET Framework 4.8 con Nancy y scripts de base de datos para SQL Server 2014.

## Estructura

```
frontend/   # Aplicación SPA con Vite
backend/    # Solución .NET Framework con Nancy
  src/
  test/
database/   # Scripts SQL Server 2014
```

## Requisitos

- Node.js 18+
- NPM o PNPM/Yarn
- Visual Studio 2022 con soporte para .NET Framework 4.8
- SQL Server 2014 o superior

## Frontend

```bash
cd frontend
npm install
npm run dev
```

El servidor se levanta en `http://localhost:5173`. Ejecutar `npm run build` para compilar y `npm run lint` para verificar el estilo.

## Backend

Abrir `backend/ReyV1.sln` en Visual Studio. Restaurar paquetes NuGet y ejecutar el proyecto `ReyV1.Api`. El servicio OWIN inicia en la URL configurada en `App.config` (por defecto `http://localhost:5000`).

### Endpoint inicial

- `GET /health`: Devuelve información básica para comprobar el estado de la API.

## Base de datos

Ejecutar los scripts de `database/scripts` en orden numérico sobre SQL Server 2014. Ajustar la cadena de conexión en `backend/src/ReyV1.Api/App.config` si es necesario.

## Buenas prácticas incluidas

- Separación clara de capas y responsabilidades.
- Configuración externa mediante `App.config` y proveedor de settings tipado.
- Bootstrapper de Nancy con configuración de CORS y diagnósticos.
- Scripts SQL versionados incrementalmente.
- Linter configurado para Vue 3 + TypeScript.
- Importación de Bootstrap 5 y estilos globales con SCSS.
