<template>
  <div class="page-background">
    <div class="about-container margin-top-30">
      <h1>О платформе AuctionService</h1>
      <div class="font-size-20">
        <ul>
          AuctionService — это онлайн-аукционная платформа, созданная для того, чтобы объединить продавцов и покупателей в безопасной и удобной среде.
          Мы предоставляем возможность участвовать в реальных торгах в любое время, находясь дома или в пути.
          Наша цель — сделать аукционы доступными каждому.
        </ul>
      </div>

      <h2>Правила пользования</h2>
      <div>
        <ul class="rules-list">
          <li>Редкие и коллекционные товары</li>
          <li>Бытовую и цифровую технику</li>
          <li>Предметы антиквариата</li>
          <li>И многое другое</li>
        </ul>
      </div>

      <h2>Правила пользования</h2>
      <ul class="rules-list">
        <li>Перед участием в аукционе необходимо пройти регистрацию.</li>
        <li>Запрещено использовать бот-программы или иные средства автоматизации торгов.</li>
        <li>Победитель аукциона обязан выкупить лот в указанный срок.</li>
        <li>Администрация оставляет за собой право заблокировать аккаунт при нарушении правил.</li>
      </ul>
      <div class="font-size-20">
        <ul>Соблюдая эти правила, вы помогаете сделать торги честными и прозрачными для всех участников.</ul>
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
  },
}
</script>

<style scoped>
.page-background {
  display: flex;
  justify-content: center;
}

.about-container {
  max-width: 800px;
  padding: 32px;
  background: linear-gradient(135deg, #e8f5e9, #c8e6c9);
  border-radius: 16px;
  box-shadow: 0 8px 20px rgba(0, 0, 0, 0.08);
  text-align: left;
  color: #168518;
}

h1 {
  font-size: 40px;
  color: #2e7d32;
  margin-bottom: 20px;
  text-align: center;
}

h2 {
  text-indent: 40px;
  font-size: 24px;
  color: #2e7d32;
  margin-top: 24px;
  margin-bottom: 16px;
}

p {
  text-indent: 40px;
  font-size: 20px;
  line-height: 1.6;
  margin-bottom: 16px;
}

ul.rules-list {
  padding-left: 70px;
  margin-bottom: 16px;
}

ul.rules-list li {
  margin-bottom: 16px;
  list-style-type: disc;
}

.font-size-20 {
  font-size: 20px;
}
</style>