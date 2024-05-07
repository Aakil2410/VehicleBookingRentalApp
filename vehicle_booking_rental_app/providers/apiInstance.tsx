import axios from 'axios';

//const token: string | null = localStorage.getItem('token') 
//const token: string | null = localStorage.getItem('token');
let token: string | null = null;

if (typeof window !== 'undefined') {
  token = localStorage.getItem('token');
}
const tokenString: string | null = token !== null ? token : null;

export const database = axios.create({
    baseURL: '${process.env.NEXT_PUBLIC_PASS}',
    headers: {
      'Content-Type': 'application/json',
      'Authorization': `Bearer ${tokenString}`
    }
});

export const vehicleAPI = axios.create({
  
});