import { defineStore } from 'pinia';

export const useMyStore = defineStore('store', {
  state: () => ({
    count: 0,
    name: 'Pinia'
  }),
  actions: {
    increment() {
      this.count++;
    },
    setName(newName) {
      this.name = newName;
    }
  },
});
