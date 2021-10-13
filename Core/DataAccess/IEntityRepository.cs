using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess //Core katanı diğer katmanları referans almaz.
{
    //generic: constract
    //class: referans tip
    //IEntity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir. 
    //new() : new'lenebilir olmalı. Interface'ler new'lenemez.
    public interface IEntityRepository<T> where T:class,IEntity,new() //Class filtrelemesi yaptık
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null); //her bir arayüz için ayrı ayrı filtre koymamızın önüne geçer.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
