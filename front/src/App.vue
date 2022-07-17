<script setup>
// This starter template is using Vue 3 <script setup> SFCs
// Check out https://vuejs.org/api/sfc-script-setup.html#script-setup
import HelloWorld from '@/components/HelloWorld.vue'
const msg = "ffdsfsd"
const url = "https://localhost:7096/api/aliments/1222"
fetch(url)
    .then(response => {
        // handle the response
        return response.json()
    }).then(data => {
        // handle the data
        console.log(data)
    })
    .catch(error => {
        // handle the error
    });
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
