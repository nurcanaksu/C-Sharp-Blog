using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T :  class
    {
        void add(T t);
        void insert(T t);
        void update(T t);
        void delete(T t);
        List<T> GetListAll();
        T GetByID(int id);

        //filtreleme ve sorgu için kullanılır aşağıdaki mesela blog1 yorumların devamını okumak için
        //detay sayfasına yönlendrme yapmak için bunu yapıyorum şuan
        List<T> GetListAll(Expression<Func<T, bool>> filter); 
    }
}
