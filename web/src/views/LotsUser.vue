<template>
  <div>
    <div class="text-center margin-top-10 front-veight-700 front-size-22 ">
      <span>My lots</span>
    </div>
    <div class="outer-container">
      <div>
        <button @click="goToAuction" class="stile-button margin-top-30 margin-right-20 min-width-140">Lot created</button>
      </div>
      <div>
        <button @click="goToAuction" class="stile-button margin-top-30 margin-left-20 min-width-140">Bought history</button>
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
    }
  },
  watch: { 
  },
  computed: {
  },
  methods: {
  },
}
</script>

<style scoped>

.outer-container {
  display: flex;
  justify-content: center;
}
.min-width-140 {
  min-width: 140px;
}
</style>