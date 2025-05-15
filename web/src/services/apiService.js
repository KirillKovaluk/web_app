import api from './httpService'

export const lotController = {
  getLotsPublicAsyncHttpGet: function (){
    return api({url: 'lot/get-lots-public'})
      .get();
  },
};

export const userController = {
  createUserAsyncHttpPost: function (name, email, password){
    return api({url: 'user/create-user'})
      .post({
        name,
        email,
        password,
      });
  },
  loginUserAsyncHttpPost: function (name, password){
    return api({url: 'user/login-user'})
      .post({
        name,
        password,
      });
  },
};