<template>
  <HeaderComponent/>
  <RouterView />
</template>

<script setup lang="ts">
  import { RouterLink, RouterView } from 'vue-router'
  import HeaderComponent from './HeaderComponent.vue'
</script>


<style scoped>

</style>
