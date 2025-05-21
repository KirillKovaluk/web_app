import api from './httpService'
import { ContentTypes } from '../consts/contentTypes'

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
  createLotAsyncHttpPost: function (model){
    let request = model.formFile || new FormData();
    request.append('name', model.name);
    request.append('description', model.description);
    request.append('priceStart', model.priceStart);
    request.append('hours', model.hours);
    return api({ url: 'lot/create-lot', contentType: ContentTypes.formData  })
      .post(request );
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