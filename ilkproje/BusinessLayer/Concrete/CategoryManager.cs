using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        //kısıtlamalar burdan yapılıyor
        //CategoryRepository c = new CategoryRepository(); bunun yerine generiğimi kullanıyorum.
        //GenericRepository<Category> c = new GenericRepository<Category>();
        //EfCategoryRepository efCategoryRepository;
        public CategoryManager(ICategoryDal categoryDal)
        {
            this._categoryDal = categoryDal;
        }

        public void AddCategory(Category category)
        {
            _categoryDal.insert(category);
        }

        public void DeleteCategory(Category category)
        {
            _categoryDal.delete(category);
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetByID(id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetListAll();
        }

        public void UpdateCategory(Category category)
        {
            _categoryDal.update(category);
        }
    }
}
