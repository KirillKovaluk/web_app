import { defineStore } from 'pinia';

const TOKEN_ACCESS_KEY = 'token_access';
const USER_KEY = 'user';

export const useStore = defineStore('store', {
  state: () => ({
    user: null,
    token: null,
  }),
  actions: {
    loginUser(user) {
      this.user = user;
      this.token = user.token;
      localStorage.setItem(USER_KEY, JSON.stringify(user));
      localStorage.setItem(TOKEN_ACCESS_KEY, user.token);
    },
    logoutUser() {
      this.user = null;
      this.token = null;
      localStorage.removeItem(USER_KEY);
      localStorage.removeItem(TOKEN_ACCESS_KEY);
    },
    isAuthorized() {
      return this.token !== null;
    },
    readToken() {
      this.user = JSON.parse(localStorage.getItem(USER_KEY));
      this.token = localStorage.getItem(TOKEN_ACCESS_KEY);
    },
  },
});
