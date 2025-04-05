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
        <CardItem :name="item"></CardItem>
      </div>
    </div>
  </div>
</template>

<script>

import CardItem from '../components/CardItem' 

export default {
  components: {
    CardItem,
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
  