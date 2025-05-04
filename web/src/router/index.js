import { createRouter, createWebHistory } from 'vue-router'

import Home from '../views/Home'
import Login from '../views/Login'
import Registration from '../views/Registration'

const router = createRouter({
  history: createWebHistory(),
  routes: [
    { path: '/', name: 'Home', component: Home },
    { path: '/login', name: 'Login', component: Login },
    { path: '/registration', name: 'Registration', component: Registration },
  ]
})

export default router