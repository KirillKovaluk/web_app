<template>
  <div>

    <RouterView></RouterView>
  </div>
</template>

<script>
//import HelloWorld from './components/HelloWorld.vue'
import Menu from './components/Menu.vue'

export default {
  components: {
    Menu,
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #077a16;
  margin-top: 60px;
}
</style>
