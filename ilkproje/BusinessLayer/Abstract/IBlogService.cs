using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        void BlogAdd(Blog blog);
        void BlogDelete(Blog blog);
        void BlogUpdate(Blog blog);
        Blog GetById(int id);
        List<Blog> GetList();
        List<Blog> GetBlogListWithCategory(); 

    }
}
