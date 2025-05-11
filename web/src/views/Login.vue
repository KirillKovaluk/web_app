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
        <button @click="login" :disabled="loginError" class="login-button">Login</button>
    </div>
  </div>
</template>

<script>

import { userController } from '@/services/apiService';

export default {
  components: {
  },
  data() {
    return {
      name: '',
      password: '',
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
          console.log(response);
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
.login-button {
  cursor: pointer;
  background: linear-gradient(90deg, rgba(9, 133, 9, 1) 0%, rgba(20, 143, 71, 1) 50%, rgba(72, 179, 14, 1) 100%);
  border: none;
  color: white;
  padding: 12px;
  border-radius: 6px;
  font-size: 16px;
  transition: background-color 0.3s ease, transform 0.2s ease;
}
.login-button:hover {
  background-color: #28a745;
  transform: translateY(-2px);
}
.login-button:focus {
  outline: none;
}
.login-button:disabled {
  background: #b4c2b4;
  background: linear-gradient(90deg, rgba(180, 194, 180, 1) 0%, rgba(95, 110, 100, 1) 50%, rgba(118, 130, 111, 1) 100%);
  transition: none;
  transform: none;
}
</style>
