<script setup>
const props = defineProps({
  name: {
    type: String,
    validator(value) {
      return value.toLowerCase();
    }
  }
})
</script>

<template>
  <h1>Aliment : {{ props.name }}</h1>
</template>

<style scoped>
</style>
