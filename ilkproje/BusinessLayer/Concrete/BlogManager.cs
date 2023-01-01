using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class BlogManager:IBlogService
    {
        IBlogDal _blogdal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogdal = blogDal;
        }

        public void BlogAdd(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void BlogDelete(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void BlogUpdate(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogdal.GetListWithCategory();
        }

        public Blog GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetList()
        {
            return _blogdal.GetListAll();
        }

        public List<Blog> GetBlogByID(int id)
        {
            return _blogdal.GetListAll(x => x.BlogID == id); //detay sayfası 
        }
    }
}
