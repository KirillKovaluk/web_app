<template>
  <div>
    <Menu></Menu>
    <RouterView class="router-view"></RouterView>
  </div>
</template>

<script>
import Menu from './components/Menu.vue'
import { useStore } from '@/stores/store';

export default {
  components: {
    Menu,
  },
  data() {
    return {
    }
  },
  created() {
    this.readToken(); 
  },
  watch: { 
  },
  computed: {
  },
  methods: {
    readToken() {
      const store = useStore();
      store.readToken(); 
    },
  },
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