<template>
  <div class="lots-page">
    <div class="text-center margin-top-10 front-veight-700 front-size-22">
      <span>Lots</span>
    </div>
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
            <div>
              <span>Price bet:</span>
              <span v-if="lot.priceBet" class="margin-left-5">{{ lot.priceBet }}</span>
              <span v-else class="margin-left-5">No bets</span>
            </div>

            <div v-if="lot.fileImages && lot.fileImages[0]" class="text-center">
              <img :src="getImageUrl() + lot.fileImages[0].path" alt="" class="lot-image">
            </div>
            
            <div class="margin-top-10">
              <button @click="createBet(lot.id)" class="stile-button button-create">Place a bet</button>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>

import { lotController } from '@/services/apiService';
import { getApiUrl } from '@/services/helperService';

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
    createBet(id){
      lotController.betLotAsyncHttpPost(id)
      .then(() => {
        this.init();
      });
    },
    getImageUrl() {
      return getApiUrl();
    },
  },
}
</script>

<style scoped>

.margin-left-5 {
  margin-left: 8px;
  color: #168518;
}

.button-create {
 min-width: 120px;
}
</style>