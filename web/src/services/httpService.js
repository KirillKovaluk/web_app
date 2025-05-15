import axios from 'axios';
import { useStore } from '@/stores/store';

const API_URL = 'https://localhost:7245/';

function responseError(e) {
  return Promise.reject(e);
}

export default function api(apiConfig) {
  let url = `${API_URL}${apiConfig.url}`;
  let headers = { 
    'Accept': 'application/json;charset=UTF-8',
    'Content-Type': 'application/json;charset=UTF-8',
  };
  const store = useStore(); 
  let token = store.getToken();
  if (token) {
    headers.Authorization = `Bearer ${token}`;
  }
  const config = {
    headers,
  };

  return {
    post: data => axios.post(url, data, config)
      .then(response => {
        return response.data;
      })
      .catch(e => {
        return responseError(e);
      }),
      
    get: () => axios.get(url, config)
      .then(response => {
        return response.data;
      })
      .catch(e => {
        return responseError(e);
      }),

    put: data => axios.put(url, data, config)
      .then(response => {
        return response.data;
      })
      .catch(e => {
        return responseError(e);
      }),

    patch: data => axios.patch(url, data, config)
      .then(response => {
        return response.data;
      })
      .catch(e => {
        return responseError(e);
      }),

    delete: () => axios.delete(url, config)
      .then(response => {
        return response.data;
      })
      .catch(e => {
        return responseError(e);
      }),
  };
}


