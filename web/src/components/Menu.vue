<template>
  <div>
    <div class="navbar">

      <div class="nav-left">
        <div @click="home" class="navbar-button">
          <span class="navbar-text">Auction</span>
        </div>
      </div>

      <div class="nav-right">
        <div @click="registration" class="margin-left-20 navbar-button">
          <span class="navbar-text">Registration</span>
        </div>
        <div @click="login" class="margin-left-20 navbar-button">
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
    home() {
      this.$router.push('/');
    },
    registration() {
      this.$router.push('/registration');
    },
    login() {
      this.$router.push('/login');
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
  padding: 10px;
  display: flex;
}
.nav-right {
  padding: 10px;
  display: flex;
  margin-left: auto;
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
.navbar-button {
  cursor: pointer;
  background-color: #28a745;
  border-color: #28a745;
  border: 1px solid transparent;
  padding: 10px;
  border-radius: 6px;
}
</style>