<template>
  <div>
    <div class="navbar">

      <div class="nav-left">
        <div @click="home" class="stile-button">
          <span class="navbar-text">AuctionService</span>
        </div>
        <div @click="about" class="stile-button margin-left-20">
          <span class="navbar-text">About</span>
        </div>

        <div @click="lots" class="stile-button margin-left-20">
          <span class="navbar-text">Lots</span>
        </div>
        <div v-if="isAuthorized" @click="lotsUserCreated" class="stile-button margin-left-20">
          <span class="navbar-text">Lots created</span>
        </div>
        <div v-if="isAuthorized" @click="lotsUserBought" class="stile-button margin-left-20">
          <span class="navbar-text">Lots bought</span>
        </div>    
      </div>

      <div class="nav-right">

        <div v-if="isAuthorized" class="nav-block">
          <div @click="profile" class="margin-left-20 stile-button">
            <span class="navbar-text">Profile</span>
          </div>
          <div @click="logout" class="margin-left-20 stile-button">
            <span class="navbar-text">Logout</span>
          </div>
        </div>

        <div v-else class="nav-block">
          <div @click="registration" class="margin-left-20 stile-button">
            <span class="navbar-text">Registration</span>
          </div>
          <div @click="login" class="margin-left-20 stile-button">
            <span class="navbar-text">Login</span>
          </div>
        </div>

      </div>

    </div>
  </div>
</template>

<script>
import { useStore } from '@/stores/store';

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
    isAuthorized() {
      const store = useStore();
      return store.isAuthorized();
    },
  },
  methods: {
    home() {
      this.$router.push('/');
    },
    about() {
      this.$router.push('/about');
    },
    lots() {
      this.$router.push('/lots');
    },
    lotsUserCreated() {
      this.$router.push('/lots-user-created');
    },
    lotsUserBought() {
      this.$router.push('/lots-user-bought');
    },
    registration() {
      this.$router.push('/registration');
    },
    login() {
      this.$router.push('/login');
    },
    profile() {
      this.$router.push('/profile');
    },
    logout() {
      const store = useStore();
      store.logoutUser();
      this.$router.push('/');
    },
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
.nav-block {
  display: flex;
  margin-left: auto;
}
.navbar-text {
  font-weight: bold;
}
.right {
  text-align: right;
}

</style>