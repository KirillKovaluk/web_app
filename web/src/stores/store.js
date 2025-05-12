import { defineStore } from 'pinia';

export const useStore = defineStore('store', {
  state: () => ({
    user: null,
    token: null,
  }),
  actions: {
    loginUser(user) {
      this.user = user;
      this.token = user.token;
    },
  },
});
