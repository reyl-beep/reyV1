# Frontend ReyV1

Aplicación creada con Vite + Vue 3 + TypeScript y Bootstrap 5.

## Scripts

- `npm run dev`: inicia el servidor de desarrollo en `http://localhost:5173`.
- `npm run build`: genera la compilación de producción en `dist/`.
- `npm run preview`: sirve la versión compilada para verificación.
- `npm run lint`: ejecuta ESLint con la configuración recomendada para Vue 3 + TS.

## Estructura

- `src/main.ts`: punto de entrada, inicializa Vue e importa Bootstrap.
- `src/App.vue`: componente raíz.
- `src/assets/`: estilos globales SCSS.
- `src/components/`: componentes Vue reutilizables.

Se recomienda añadir pruebas con Vitest e integrar Pinia cuando la aplicación lo requiera.
