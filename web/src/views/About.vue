<template>
  <div class="page-background">
    <div class="about-container">
      <h1>О платформе AuctionService</h1>

      <p>
        AuctionService — это онлайн-аукционная платформа, созданная для того, чтобы объединить продавцов и покупателей в безопасной и удобной среде.
        Мы предоставляем возможность участвовать в реальных торгах в любое время, находясь дома или в пути.
        Наша цель — сделать аукционы доступными каждому.
      </p>

      <h2>Правила пользования</h2>
      <p>
        <ul class="rules-list">
          <li>Редкие и коллекционные товары</li>
          <li>Бытовую и цифровую технику</li>
          <li>Предметы антиквариата</li>
          <li>И многое другое</li>
        </ul>
      </p>

      <h2>Правила пользования</h2>
      <ul class="rules-list">
        <li>Перед участием в аукционе необходимо пройти регистрацию.</li>
        <li>Запрещено использовать бот-программы или иные средства автоматизации торгов.</li>
        <li>Победитель аукциона обязан выкупить лот в указанный срок.</li>
        <li>Администрация оставляет за собой право заблокировать аккаунт при нарушении правил.</li>
      </ul>

      <p>Соблюдая эти правила, вы помогаете сделать торги честными и прозрачными для всех участников.</p>
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
  min-height: 100vh;
  background: linear-gradient(
    90deg,
    rgba(193, 230, 193, 1) 3%,
    rgba(142, 212, 145, 1) 14%,
    rgba(178, 237, 198, 1) 36%,
    rgba(118, 130, 111, 1) 100%
  );
  display: flex;
  justify-content: center;
  padding: 32px;
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
  padding-left: 24px;
  margin-bottom: 16px;
}

ul.rules-list li {
  margin-bottom: 16px;
  list-style-type: disc;
}
</style>