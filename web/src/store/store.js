import { defineStore } from 'pinia';

export const useMyStore = defineStore('store', {
  state: () => ({
    user: null,
    token: null,
  }),
  actions: {
    setUser(user) {
      this.user = user;
    },
    setToken(token) {
      this.token = token;
    }
  },
});
