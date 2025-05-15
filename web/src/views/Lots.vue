<template>
  <div>
    <div class="text-center margin-top-10">
      <span>Lots</span>
    </div>
    <div class="margin-top-10">
      <div v-for="(lot, index) in lots" :key="index" class="margin-top-10 lot-block">
        <div class="lot-card">
          <div>
            <span>Name:</span>
            <span class="margin-left-5">{{ lot.name }}</span>
          </div>
          <div>
            <span>Description:</span>
            <span class="margin-left-5">{{ lot.description }}</span>
          </div>
          <div>
            <span>Price start:</span>
            <span class="margin-left-5">{{ lot.priceStart }}</span>
          </div>
          <div>
            <span>Date end:</span>
            <span class="margin-left-5">{{ lot.dateEnd }}</span>
          </div>
          <div>
            <span>Creator:</span>
            <span class="margin-left-5">{{ lot.userCreated.name }}</span>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>

import { lotController } from '@/services/apiService';

export default {
  components: {
  },
  data() {
    return {
      lots: null,
    }
  },
  created() {
    this.init(); 
  },
  watch: { 
  },
  computed: {
  },
  methods: {
    init(){
      lotController.getLotsPublicAsyncHttpGet()
      .then((data) => {
        this.lots = data;
      });
    },
  },
}
</script>

<style scoped>
.lot-block {
  display: flex;
  justify-content: center;
}
.lot-card {
  padding: 5px;
  border-radius: 6px;
  border-style: groove;
  width: 400px;
}
</style>