using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal : IGenericDal<Blog>
    {
        //bu metodu blog sayfasında categori id sine göre kategori adı getirmek için yazdık
        List<Blog> GetListWithCategory(); 
    }
}
