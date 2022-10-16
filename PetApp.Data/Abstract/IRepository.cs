using System;
using System.Collections.Generic;
using System.Text;

namespace PetApp.Data.Abstract
{
    public interface IRepository<T>
    {
        public List<T> GetAll();
        public T GetById(int id);
        public void Create(T entity);
        public void Delete(T entity);
        public void Update(T entity);
    }
}
