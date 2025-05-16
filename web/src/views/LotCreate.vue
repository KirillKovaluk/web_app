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

      <div class="margin-top-30 ">
        <div>
          <button @click="createLot" :disabled="createError" class="stile-button button-create">Create</button>
        </div>
      </div>
  
    </div>

  </div>
</template>

<script>

export default {
  components: {
  },
  data() {
    return {
      name: '',
      priceStart: '',
      hours: '',
      description: '',
    }
  },
  watch: { 
  },
  computed: {
    createError() {
      return this.nameError || this.priceStartError || this.hoursError || this.descriptoinError;
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
  },
  methods: {
    createLot() {

    },
  },
}
</script>

<style scoped>
.button-create {
 min-width: 120px;
}
</style>