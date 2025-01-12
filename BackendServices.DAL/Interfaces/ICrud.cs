﻿namespace BackendServices.DAL;

public interface ICrud<T>
{
    IEnumerable<T> GetAll();
    T GetById(int id);
    T Add(T entity);
    T Update(T entity);
    void Delete(int id);
}
