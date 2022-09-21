import axios, { AxiosResponse } from "axios";
import { Basket } from "../models/basket";
import { Category } from "../models/category";
import { Course } from "../models/course";
import { PaginatedCourse } from "../models/PaginatedCourse";



axios.defaults.baseURL = "http://localhost:5000/api";

const responseBody = <T> (response: AxiosResponse<T>) => response.data;

axios.defaults.withCredentials = true;

const request = {
    get:<T>(url: string) => axios.get<T>(url).then(responseBody),
    post:<T>(url: string, body: {}) => axios.post<T>(url, body).then(responseBody),
    put:<T>(url: string, body : {}) => axios.put<T>(url, body).then(responseBody),
    del:<T>(url: string) => axios.delete<T>(url).then(responseBody),
};

const Courses = {
    list: () => request.get<PaginatedCourse>("/courses"),
    getById: (id: string) => request.get<Course>(`/courses/${id}`),
};

const Categories = {
    list: () => request.get<Category[]>("/categories"),
    getCategory: (id: number) => request.get<Category>(`/categories/${id}`),
  };

  const Baskets = {
    get: () => request.get<Basket>("basket"),
    addItem: (courseId: string) =>
      request.post<Basket> (`basket?courseId=${courseId}`, {}),
    removeItem: (courseId: string) => 
    request.del(`basket?courseId=${courseId}`),
  };
  
  const agent = {
    Courses,
    Categories,
    Baskets,
  };

export default agent;