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

<style lang="scss">

@use "@/assets/scss/global.scss";

.router-view {
  padding-top: 80px;
}
body {
  margin: 0;
}
</style>