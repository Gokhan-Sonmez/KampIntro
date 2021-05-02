using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface IManagerService<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
