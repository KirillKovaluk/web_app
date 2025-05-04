<template>
  <div>
    <div class="navbar">

      <div class="nav-left">
        <div @click="home" class="navbar-block">
          <span class="navbar-text nav-item">Auction</span>
        </div>
      </div>


      <div class="nav-right">
        <div @click="registration" class="navbar-block margin-left-20">
          <span class="navbar-text nav-item">Registration</span>
        </div>
        <div @click="login" class="navbar-block margin-left-20">
          <span class="navbar-text nav-item">Login</span>
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
.nav-item:hover {
  text-decoration: underline;
}
.button {
  background-color: #127e3f;
  color: black;
  padding: 12px 20px;
  border: none;
  border-radius: 6px;
  cursor: pointer;
}
</style>