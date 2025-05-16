import api from './httpService'

export const lotController = {
  getLotsPublicAsyncHttpGet: function (){
    return api({url: 'lot/get-lots-public'})
      .get();
  },
  getLotsCreatedAsyncHttpGet: function (){
    return api({url: 'lot/get-lots-created'})
      .get();
  },
  getLotsBoughtAsyncHttpGet: function (){
    return api({url: 'lot/get-lots-bought'})
      .get();
  },
  createLotAsyncHttpPost: function (name, description, priceStart, hours){
    return api({url: 'lot/crate-lot'})
      .post({
        name,
        description,
        priceStart,
        hours,
      });
  },
  betLotAsyncHttpPost: function (id){
    return api({url: 'lot/bet-lot'})
      .post({
        id,
      });
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
  getUserAsyncHttpGet: function (){
    return api({url: 'user/get-user'})
      .get();
  },
};