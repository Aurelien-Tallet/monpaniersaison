<script setup>

</script>

<template>
  <nav>
    <router-link to="/">Accueil</router-link>
    <router-link to="/about">À propos</router-link>
    <router-link
        :to="{
          name: 'Aliment',
          params : { name: 'Banane'}
        }">
      Aliment 1
    </router-link>
  </nav>
  <h1>APP</h1>
  <router-view/>
</template>

<style scoped lang="scss">

</style>
