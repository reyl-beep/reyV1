# Backend ReyV1

Proyecto .NET Framework 4.8 con Nancy y OWIN.

## Componentes principales

- `CustomBootstrapper`: registra servicios y configura middlewares (CORS, diagnósticos).
- `HealthModule`: endpoint básico `GET /health` para monitoreo.
- `AppSettingsProvider`: acceso tipado a configuraciones desde `App.config`.
- `Program`: arranca la API con OWIN self-host.

## Requisitos

- Visual Studio 2022 o superior.
- Paquetes NuGet restaurados (`Restore NuGet Packages`).

## Ejecución

1. Restaurar paquetes NuGet.
2. Establecer `ReyV1.Api` como proyecto de inicio.
3. Ejecutar con F5. Por defecto escuchar en `http://localhost:5000`.

Ajuste la cadena de conexión en `App.config` antes de conectarse a SQL Server.
