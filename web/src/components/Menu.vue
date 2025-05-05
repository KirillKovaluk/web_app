<template>
  <div>
    <div class="navbar">

      <div class="nav-left">
        <div @click="home" class="stile-button">
          <span class="navbar-text">Auction</span>
        </div>
      </div>

      <div class="nav-right">
        <div @click="registration" class="margin-left-20 stile-button">
          <span class="navbar-text">Registration</span>
        </div>
        <div @click="login" class="margin-left-20 stile-button">
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
  background: #59cf59;
  background: linear-gradient(90deg, rgba(89, 207, 89, 1) 0%, rgba(87, 199, 133, 1) 50%, rgba(139, 237, 83, 1) 100%);
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
.stile-button {
  cursor: pointer;
  background: linear-gradient(90deg, rgba(9, 133, 9, 1) 0%, rgba(20, 143, 71, 1) 50%, rgba(72, 179, 14, 1) 100%);
  border: none;
  color: white;
  padding: 12px;
  border-radius: 6px;
  font-size: 16px;
  transition: background-color 0.3s ease, transform 0.2s ease;
}
.stile-button:hover {
  background-color: #28a745;
  transform: translateY(-2px);
}
.stile-button:focus {
  outline: none;
}
</style>