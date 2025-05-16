import { createRouter, createWebHistory } from 'vue-router'
import { RouteType } from '../consts/routeType'

import Home from '../views/Home'
import About from '../views/About'
import Login from '../views/Login'

import LotCreate from '../views/LotCreate'
import Lots from '../views/Lots'
import LotsUserCreated from '../views/LotsUserCreated'
import LotsUserBought from '../views/LotsUserBought'

import Profile from '../views/Profile'
import Registration from '../views/Registration'


const router = createRouter({
  history: createWebHistory(),
  routes: [
    { path: '/', name: 'Home', component: Home, meta: { type: RouteType.default }},
    { path: '/about', name: 'About', component: About, meta: { type: RouteType.default } },
    { path: '/login', name: 'Login', component: Login, meta: { type: RouteType.unauthorized } },

    { path: '/lot-create', name: 'LotCreate', component: LotCreate, meta: { type: RouteType.authorized } },
    { path: '/lots', name: 'Lots', component: Lots, meta: { type: RouteType.default } },
    { path: '/lots-user-created', name: 'LotsUserCreated', component: LotsUserCreated, meta: { type: RouteType.authorized } },
    { path: '/lots-user-bought', name: 'LotsUserBought', component: LotsUserBought, meta: { type: RouteType.authorized } },
    
    { path: '/profile', name: 'Profile', component: Profile, meta: { type: RouteType.authorized }},
    { path: '/registration', name: 'Registration', component: Registration, meta: { type: RouteType.unauthorized } },
  ]
})

export default router