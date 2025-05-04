<template>
  <div>
    <div>
      <span class="test test2">Card name: {{ name }}</span>
    </div>
  </div>
</template>
  
<script>
export default {
  props: {
    name: String
  },
  data() {
    return {
      
    }
  }
}
</script>
  
<style scoped>
.test {
  color: red;
}
.test2 {
  font-weight: bold;
}
</style>
  