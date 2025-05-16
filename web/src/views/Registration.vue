<template>
  <div class="page-background">
    <div class="outer-container">
      <div class="registration-field">
        <h2>Registration</h2>
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
            <span>Email</span>
          </div>
          <div class="margin-top-4">
            <input v-model="email" type="email" placeholder="Enter email" />
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
        <div class="input-column">
          <div>
            <span>ConfirmPassword</span>
          </div>
          <div class="margin-top-4">
            <input v-model="passwordConfirm" type="password" placeholder="Confirm password" />
          </div>
        </div>
        <div>
          <button @click="registration" :disabled="registrationError" class="stile-button">Register</button>
        </div>
        <div class="margin-top-10 message">
          <span v-show="isErrorMessege">test</span>
        </div>
      </div>
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
      email: '',
      password: '',
      passwordConfirm: '',
      isErrorMessege: false,
    }
  },
  watch: { 
  },
  computed: {
    registrationError() {
      return this.nameError || this.emailError || this.passwordError || this.passwordConfirmError || this.passwordCheckError;
    },
    nameError() {
      return this.name.length === 0;
    },
    emailError() {
      return this.email.length === 0;
    },
    passwordError() {
      return this.password.length === 0;
    },
    passwordConfirmError() {
      return this.passwordConfirm.length === 0;
    },
    passwordCheckError() {
      return this.password !== this.passwordConfirm;
    },
  },
  methods: {
    registration() {
      userController.createUserAsyncHttpPost(this.name, this.email, this.password)
        .then(() => {
          this.$router.push('/login');
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
.registration-field {
  margin-top: 180px;
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
