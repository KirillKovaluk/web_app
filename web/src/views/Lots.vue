<template>
  <div class="lots-page">
    <div class="text-center margin-top-10 front-veight-700 front-size-22">
      <span>Lots</span>
    </div>
    <div>
      <div class="text-center margin-top-10">
        <select v-model="lotType" @change="lotTypeChanged" class="form-select" aria-label="Default select example">
          <option 
            v-for="(item, index) in lotTypesArray" :key="index" :selected="index === 0"
            >{{ item }}
          </option>
        </select>
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
              <span>Lot type:</span>
              <span class="margin-left-5">{{ lot.lotType }}</span>
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
              <button @click="createBet(lot.id)" :disabled="isCreateBetDisabled(lot)" class="stile-button button-create">Place a bet</button>
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
import { LotTypesArray, LotTypes, LotTypesValues } from '@/consts/lotTypes';
import { useStore } from '@/stores/store';

export default {
  components: {
  },
  data() {
    return {
      lots: null,
      lotType: LotTypes.NONE,
      lotTypesArray: LotTypesArray,
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
    init() {
      const lotTypeValue = LotTypesValues[this.lotType];
      lotController.getLotsPublicAsyncHttpPost(lotTypeValue)
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
    lotTypeChanged() {
      this.init();
    },
    isCreateBetDisabled(lot) {
      const store = useStore();
      let user = store.getUser();
      if (!user) return true;
      return user.id === lot.userCreated.id;
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