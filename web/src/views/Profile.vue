<template>
  <div class="page-background">
    <div class="text-center margin-top-10">
      <span>Profile</span>
    </div>
    <div class="text-center margin-top-10">
      <span>Information</span>
    </div>
    <div v-if="user">
      <div class="text-center margin-top-10">
        <span>Name:</span>
        <span class="margin-left-5">{{ user.name }}</span>
      </div>
      <div class="text-center margin-top-10">
        <span>Balance:</span>
        <span class="margin-left-5">{{ user.balance }}</span>
      </div>
    </div>
  </div>
</template>

<script>

import { userController } from '@/services/apiService';

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
      userController.getUserAsyncHttpGet()
      .then((data) => {
        this.user = data;
      })
      .catch((e) => {
        console.log(e);
      })
      ;
    },
  },
}
</script>

<style scoped>
.page-background {
  min-height: 100vh;
  background: #c1e6c1;
  background: linear-gradient(
    90deg,
    rgba(193, 230, 193, 1) 3%,
    rgba(142, 212, 145, 1) 14%,
    rgba(178, 237, 198, 1) 36%,
    rgba(118, 130, 111, 1) 100%
  );
}
</style>