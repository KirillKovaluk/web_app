import axios from 'axios';

const API_URL = 'http://localhost:5041/';

export default function api(apiConfig) {
  let url = `${API_URL}${apiConfig.url}`;
  let headers = { 
    'Accept': 'application/json;charset=UTF-8',
    'Content-Type': 'application/json;charset=UTF-8',
  };
  let token = null;
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
        return e;
      }),
      
    get: () => axios.get(url, config)
      .then(response => {
        return response.data;
      })
      .catch(e => {
        return e;
      }),

    put: data => axios.put(url, data, config)
      .then(response => {
        return response.data;
      })
      .catch(e => {
        return e;
      }),

    patch: data => axios.patch(url, data, config)
      .then(response => {
        return response.data;
      })
      .catch(e => {
        return e;
      }),

    delete: () => axios.delete(url, config)
      .then(response => {
        return response.data;
      })
      .catch(e => {
        return e;
      }),
  };
}


