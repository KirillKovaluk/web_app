<template>
  <div class="outer-container">
    <div class="registration-field">
      <h2>Регистрация</h2>
      <div class="input-column outer-container">
        <input type="text" placeholder="Введите ваше имя" />
      </div>
      <div class="input-column outer-container">
        <input type="email" placeholder="Введите ваш email" />
      </div>
      <div class="input-column outer-container">
        <input type="password" placeholder="Введите ваш пароль" />
      </div>
      <div class="input-column outer-container">
        <input type="confirm password" placeholder="Повторите ваш пароль" />
      </div>
        <button class="register-button">Зарегистрироваться</button>
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
.outer-container {
  display: flex;
  justify-content: center;

}
.registration-field {
  margin-top: 110px;
  width: 400px;
  height: 400px;
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
  border-radius: 15px;
  box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
}
.register-button {
  cursor: pointer;
  background: linear-gradient(90deg, rgba(9, 133, 9, 1) 0%, rgba(20, 143, 71, 1) 50%, rgba(72, 179, 14, 1) 100%);
  border: none;
  color: white;
  padding: 12px;
  border-radius: 6px;
  font-size: 16px;
  transition: background-color 0.3s ease, transform 0.2s ease;
}
.register-button:hover {
  background-color: #28a745;
  transform: translateY(-2px);
}
.register-button:focus {
  outline: none;
}
</style>
