using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void AddComment(Comment comment);
       // void DeleteComment(Comment comment);
        //void UpdateComment(Comment comment);
        //Comment GetById(int id);
        List<Comment > GetList(int id);
    }
}
