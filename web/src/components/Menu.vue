<template>
  <div>
    <div class="navbar">

      <div class="nav-left">
        <div class="navbar-block">
          <span class="navbar-text">Auction</span>
        </div>
      </div>


      <div class="nav-right">
        <div class="navbar-block margin-left-20">
          <span class="navbar-text">Registration</span>
        </div>
        <div class="navbar-block margin-left-20">
          <span class="navbar-text">Login</span>
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
      test: 'teee',
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
.navbar {
  display: flex;
  position: fixed;
  width: 100%;
  height: 60px;
  background-color: #6EAE97;
}
.nav-left {
  display: flex;
}
.nav-right {
  display: flex;
  margin-left: auto;
}
.navbar-block {
  padding: 21px;
  cursor: pointer;
}
.navbar-text {
  font-weight: bold;
}
.right {
  text-align: right;
}
.margin-left-20 {
  margin-left: 20px;
}
</style>