<template>
  <div>
    <Menu></Menu>
    <RouterView class="router-view"></RouterView>
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
.router-view {
  padding-top: 60px;
}
body {
  margin: 0;
}
</style>
