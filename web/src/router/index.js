import { createRouter, createWebHistory } from 'vue-router'

import HomePage from '../pages/HomePage'

const router = createRouter({
  history: createWebHistory(),
  routes: [
    { path: '/', name: 'HomePage', component: HomePage },

  ]
})

export default router