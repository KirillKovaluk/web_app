<template>
  <div>
    <div class="text-center margin-top-10 front-veight-700 front-size-22">
      <span>Create new lot</span>
    </div>

    <div class="text-center margin-top-10">
      <div>
        <div>
          <span>Lot name</span>
        </div>
        <div class="margin-top-4">
          <input v-model="name" class="input-custom" type="text" placeholder="Enter name" />
        </div>
      </div>

      <div class="margin-top-10">
        <div>
          <span>Price start</span>
        </div>
        <div class="margin-top-4">
          <input v-model="priceStart" class="input-custom" type="text" placeholder="Enter price start" />
        </div>
      </div>

      <div class="margin-top-10">
        <div>
          <span>Description</span>
        </div>
        <div class="margin-top-4">
          <input v-model="description" class="input-custom" type="text" placeholder="Enter description" />
        </div>
      </div>

      <div class="margin-top-10">
        <div>
          <span>Hours</span>
        </div>
        <div class="margin-top-4">
          <input v-model="hours" class="input-custom" type="text" placeholder="Enter hours" />
        </div>
      </div>

      <div class="margin-top-10">
        <div>
          <span>Lot type</span>
        </div>
        <div class="margin-top-4">
          <select v-model="lotType" @change="lotTypeChanged" class="form-select max-width-400" aria-label="Default select example">
            <option 
              v-for="(item, index) in lotTypesArray" :key="index" :selected="index === 0"
              >{{ item }}
            </option>
          </select>
        </div>
      </div>

      <div v-show="false" class="margin-top-10">
        <input
          ref="input"
          type="file"
          @change="fileChanged">
      </div>

      <div class="margin-top-30">
        <div>
          <button @click="addFile" class="stile-button button-create">Add Image</button>
        </div>
      </div>

      <div v-if="selectedFile" class="margin-top-10">
        <div>
          <span>{{ selectedFile.name }}</span>
          <img
            @click="closeFile"
            class="icon margin-left-5"
            src="@/assets/icons/close-icon.svg">
        </div>
      </div>

      <div class="margin-top-30 ">
        <div>
          <button @click="createLot" :disabled="createError" class="stile-button button-create">Create</button>
        </div>
      </div>
  
    </div>

  </div>
</template>

<script>

import { lotController } from '@/services/apiService';
import { LotTypesArray, LotTypes, LotTypesValues } from '@/consts/lotTypes';

export default {
  components: {
  },
  data() {
    return {
      name: '',
      priceStart: '',
      hours: '',
      description: '',

      lotType: LotTypes.NONE,
      lotTypesArray: LotTypesArray,

      selectedFile: null,
    }
  },
  watch: { 
  },
  computed: {
    createError() {
      return this.nameError
      || this.priceStartError
      || this.hoursError
      || this.descriptoinError
      || this.selectedFileError
      || this.lotTypeError;
    },
    nameError() {
      return this.name.length === 0;
    },
    priceStartError() {
      return this.priceStart.length === 0;
    },
    hoursError() {
      return this.hours.length === 0;
    },
    descriptoinError  () {
      return this.description.length === 0;
    },
    lotTypeError  () {
      return this.lotType === LotTypes.NONE;
    },
    selectedFileError  () {
      return this.selectedFile === null;
    },
  },
  methods: {
    createLot() {
      const lotTypeValue = LotTypesValues[this.lotType];
      let lot = {
        name: this.name,
        description: this.description,
        priceStart: this.priceStart,
        hours: this.hours,
        lotType: lotTypeValue,
      };
      lot.formFile = this.getFormData();
      lotController.createLotAsyncHttpPost(lot)
      .then(() => {
        this.$router.push('/lots-user-created');
      })
    },
    fileChanged() {
      this.selectedFile = this.$refs.input.files[0];
      this.$refs.input.value = null;
    },
    addFile() {
      this.$refs.input.click();
    },
    closeFile() {
      this.selectedFile = null;
    },
    getFormData() {
      const formData = new FormData();
      formData.append('formFile', this.selectedFile, this.selectedFile.name);
      return formData;
    },
  },
}
</script>

<style scoped>
.button-create {
 min-width: 120px;
}
.max-width-400 {
  max-width: 400px;
};
</style>