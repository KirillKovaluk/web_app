import api from './httpService'

export const userController = {
  getTestAsyncHttpGet: function (){
    return api({url: 'user/get-test/'})
      .get();
  },
};
