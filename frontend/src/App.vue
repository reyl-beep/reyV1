<script setup lang="ts">
import { ref } from 'vue';

const isCollapsed = ref(false);
</script>

<template>
  <div class="d-flex flex-column min-vh-100">
    <header class="bg-primary text-white py-3 shadow">
      <div class="container d-flex justify-content-between align-items-center">
        <h1 class="h3 m-0">ReyV1 Base</h1>
        <button
          class="btn btn-outline-light btn-sm"
          type="button"
          @click="isCollapsed = !isCollapsed"
        >
          {{ isCollapsed ? 'Expandir' : 'Colapsar' }}
        </button>
      </div>
    </header>

    <main class="flex-grow-1 py-5">
      <div class="container">
        <section class="mb-4">
          <h2 class="h4">Bienvenido</h2>
          <p class="text-muted">
            Este es un proyecto base construido con Vue 3, TypeScript y Bootstrap 5. Utiliza Vite para el
            tooling moderno y está listo para integrarse con la API construida en .NET Framework y Nancy.
          </p>
        </section>

        <section class="card shadow-sm">
          <div class="card-header bg-white">
            <h3 class="h5 m-0">Siguientes pasos recomendados</h3>
          </div>
          <div class="card-body">
            <ul class="list-group list-group-flush">
              <li class="list-group-item">Configurar variables de entorno con Vite.</li>
              <li class="list-group-item">
                Implementar un cliente HTTP (por ejemplo Axios o Fetch wrapper) para consumir la API.
              </li>
              <li class="list-group-item">Integrar un manejador de estados (Pinia) cuando sea necesario.</li>
              <li class="list-group-item">Agregar pruebas unitarias con Vitest.</li>
            </ul>
          </div>
        </section>
      </div>
    </main>

    <footer class="bg-light py-3 border-top">
      <div class="container text-center text-muted small">
        Proyecto base ReyV1 &copy; {{ new Date().getFullYear() }}
      </div>
    </footer>
  </div>
</template>

<style scoped>
header {
  transition: min-height 0.2s ease;
  min-height: v-bind(isCollapsed ? '3rem' : '6rem');
}
</style>
