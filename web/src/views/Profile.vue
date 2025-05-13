<template>
  <div>
    <div class="text-center margin-top-10">
      <span>Profile</span>
    </div>
    <div class="text-center margin-top-10">
      <span>Information</span>
    </div>
    <div class="text-center margin-top-10">
      <span>Name:&nbsp;</span>
      <span>{{ user.name }}</span>
    </div>
  </div>
</template>

<script>

import { useStore } from '@/stores/store';

export default {
  components: {
  },
  data() {
    return {
      user: null,
    }
  },
  created() {
    this.start();
  },
  watch: { 
  },
  computed: {
  },
  methods: {
    start() {
      const store = useStore();
      this.user = store.getUser();
    },
  },
}
</script>

<style scoped>

</style>