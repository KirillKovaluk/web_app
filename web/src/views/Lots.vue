<template>
  <div class="lots-page">
    <div>
      <div class="text-center margin-top-10">
      </div>
      <div class="margin-top-10">
        <div v-for="(lot, index) in lots" :key="index" class="margin-top-10 lot-block">
          <div class="lot-card">
            <div class="front-veight-700 front-size-22">
              <span>Name:</span>
              <span class="margin-left-5">{{ lot.name }}</span>
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
            <div>
              <span>Description:</span>
              <span class="margin-left-5">{{ lot.description }}</span>
            </div>
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
  margin-top: 20px;
}

.lot-card {
  padding: 12px 16px;
  border-radius: 6px;
  border-style: groove;
  border-color: #75df5d;
  width: 600px;
  height: 200px;
  background: linear-gradient(135deg, #d8efd8, #b1e2b1);
  box-shadow: 0 4px 10px rgba(113, 160, 113, 0.3);
  color: #2e7d32;
  font-size: 16px;
  transition: box-shadow 0.3s ease;
}

.lot-card:hover {
  box-shadow: 0 8px 20px rgba(46, 125, 50, 0.5);
}
  
.lot-card div {
  margin-bottom: 10px;
}

.lot-card span:first-child {
  font-weight: 600;
  color: #3a8f3a;
}

.margin-left-5 {
  margin-left: 8px;
  color: #168518;
}
.lots-page {
  min-height: 100vh;
  background: linear-gradient(
    90deg,
    rgba(193, 230, 193, 1) 3%,
    rgba(142, 212, 145, 1) 14%,
    rgba(178, 237, 198, 1) 36%,
    rgba(118, 130, 111, 1) 100%
  );
  box-sizing: border-box;
  display: flex;
  flex-direction: column;
  align-items: center;
}

</style>