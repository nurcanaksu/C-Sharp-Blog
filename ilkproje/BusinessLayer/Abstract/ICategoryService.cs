using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        void AddCategory(Category category);
        void DeleteCategory(Category category);
        void UpdateCategory(Category category);
        Category GetById(int id);
        List<Category> GetList();
    }
}
