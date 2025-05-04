import { createRouter, createWebHistory } from 'vue-router'

import HomeView from '../views/HomeView'

const router = createRouter({
  history: createWebHistory(),
  routes: [
    { path: '/', name: 'HomeView', component: HomeView },

  ]
})

export default router