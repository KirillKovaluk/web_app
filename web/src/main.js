import { createApp } from 'vue'
import App from './App.vue'
import router from './router/router'
import { createPinia } from 'pinia'

import { RouteType } from '@/consts/routeType'
import { useStore } from '@/stores/store';

const pinia = createPinia()

router.beforeEach((to, from, next) => {
  const store = useStore();
  const isAuthorized = store.isAuthorized();
  const routeType = to.meta.type;

  if (routeType === RouteType.default) {
    next();
  } else if (routeType === RouteType.unauthorized) {
    if (!isAuthorized) {
      next();
    } else {
      next('/profile');
    }
  } else if (routeType === RouteType.authorized) {
    if (isAuthorized) {
      next();
    } else {
      next('/login');
    }
  }
});

createApp(App)
.use(router)
.use(pinia)
.mount('#app')
