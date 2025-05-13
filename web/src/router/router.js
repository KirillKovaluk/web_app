import { createRouter, createWebHistory } from 'vue-router'
import { RouteType } from '../consts/routeType'

import Home from '../views/Home'
import About from '../views/About'
import Login from '../views/Login'
import Registration from '../views/Registration'
import Profile from '../views/Profile'


const router = createRouter({
  history: createWebHistory(),
  routes: [
    { path: '/', name: 'Home', component: Home, meta: { type: RouteType.default }},
    { path: '/about', name: 'About', component: About, meta: { type: RouteType.default } },
    { path: '/login', name: 'Login', component: Login, meta: { type: RouteType.unauthorized } },
    { path: '/registration', name: 'Registration', component: Registration, meta: { type: RouteType.unauthorized } },
    { path: '/profile', name: 'Profile', component: Profile, meta: { type: RouteType.authorized }},
    
    
  ]
})

export default router