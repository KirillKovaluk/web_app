<template>
  <div>
    <div>
      <span>home</span>
    </div>
    <div>
      <span>cards: </span>
    </div>
    <div>
      <div v-for="item in cardArray" :key="item.id">
        <LotCard :name="item"></LotCard>
      </div>
    </div>
  </div>
</template>

<script>

import LotCard from '../components/LotCard'

export default {
  components: {
    LotCard,
  },
  data() {
    return {
      cardArray: ['a', 'b', 'c', 'd', 'e'],
    }
  },
  watch: { 
  },
  computed: {
  },
  methods: {
    testFoo() {
    }
  },
}
</script>

<style scoped>

</style>