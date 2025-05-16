<template>
  <div class="page-background">
    <div class="home-container">
      <h1>Добро пожаловать на AuctionService!</h1>
      <p>
        AuctionService — это безопасная и удобная платформа для онлайн-аукционов,
        где каждый может найти что-то уникальное: от редких коллекционных предметов до современных товаров.
      </p>
      <p>
        Участвуйте в живых торгах, следите за лотами в реальном времени и выигрывайте по лучшей цене.
        Мы объединяем продавцов и покупателей по всей стране.
      </p>
      <p>
        Зарегистрируйтесь сейчас и создайте свой первый аукцион!
      </p>
      <div class>
        <button @click="goToAuction">Перейти к просмотру лотов</button>
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
.page-background {
  min-height: 100vh;
  background: #c1e6c1;
  background: linear-gradient(
    90deg,
    rgba(193, 230, 193, 1) 3%,
    rgba(142, 212, 145, 1) 14%,
    rgba(178, 237, 198, 1) 36%,
    rgba(118, 130, 111, 1) 100%
  );
  display: flex;
  align-items: center;
  justify-content: center;
  padding: 32px;
}

.home-container {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  max-width: 800px;
  padding: 60px;
  border-radius: 16px;
  background: linear-gradient(135deg, #e8f5e9, #c8e6c9);
  box-shadow: 0 8px 20px rgba(0, 0, 0, 0.08);
  text-align: center;
  transition: background 0.3s ease;
}

h1 {
  font-size: 40px;
  color: #2e7d32;
  margin-bottom: 20px;
}

p {
  font-size: 20px;
  color: #168518;
  max-width: 600px;
  margin-bottom: 1.20px;
  line-height: 1.6;
}

button {
  margin-top: 30px;
  padding: 14px 24px;
  font-size: 16px;
  background-color: #66bb6a;
  color: white;
  border: none;
  border-radius: 8px;
  cursor: pointer;
  box-shadow: 0 4px 10px rgba(102, 187, 106, 0.3);
  transition: background 0.3s ease, transform 0.2s ease;
}

button:hover {
  background-color: #57a05d;
  transform: translateY(-2px);
}
</style>