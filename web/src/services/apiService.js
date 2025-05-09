import api from './httpService'

export const userController = {
  getTestAsyncHttpGet: function (){
    return api({url: 'user/get-test'})
      .get();
  },
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
