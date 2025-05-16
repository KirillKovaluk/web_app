<template>
  <div class="outer-container">
    <div class="login-field">
      <h2>Login</h2>
      <div class="input-column">
        <div>
          <span>Name</span>
        </div>
        <div class="margin-top-4">
          <input v-model="name" type="text" placeholder="Enter name" />
        </div>
      </div>
      <div class="input-column">
        <div>
          <span>Password</span>
        </div>
        <div class="margin-top-4">
          <input v-model="password" type="password" placeholder="Enter password" />
        </div>
      </div>
      <div>
        <button @click="login" :disabled="loginError" class="stile-button">Login</button>
      </div>
      <div class="margin-top-10 message">
        <span v-show="isErrorMessege">test</span>
      </div>
    </div>
  </div>
</template>

<script>

import { userController } from '@/services/apiService';
import { useStore } from '@/stores/store';

export default {
  components: {
  },
  data() {
    return {
      name: '',
      password: '',
      isErrorMessege: false,
    }
  },
  watch: { 
  },
  computed: {
    loginError() {
      return this.nameError || this.passwordError;
    },
    nameError() {
      return this.name.length === 0;
    },
    passwordError() {
      return this.password.length === 0;
    },
  },
  methods: {
    login() {
      userController.loginUserAsyncHttpPost(this.name, this.password)
        .then((response) => {
          const store = useStore();
          store.loginUser(response);
          this.$router.push('/profile');
        })
        .catch((e) => {
          console.log(e);
        });
    },
  },
}
</script>

<style scoped>
.outer-container {
  display: flex;
  justify-content: center;
}
.login-field {
  margin-top: 250px;
  width: 400px;
  border-radius: 50px;
  padding: 20px;
  background: linear-gradient(90deg, rgba(89, 207, 89, 1) 0%, rgba(87, 199, 133, 1) 50%, rgba(139, 237, 83, 1) 100%);
  display: flex;
  flex-direction: column;
  align-items: center;
}
.input-column {
  width: 75%;
  margin-bottom: 15px;
}
.input-column input {
  width: 90%;
  padding: 15px;
  border: none;
  border-radius: 6px;
  box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
}

.message{
  height: 20px;
}
</style>
