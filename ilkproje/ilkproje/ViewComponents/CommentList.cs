using ilkproje.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ilkproje.ViewComponents
{
    public class CommentList:ViewComponent
    {
         public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    Username="Nurcan"
                },
                new UserComment
                {
                    ID=2,
                    Username="Gülcan"
                },
                new UserComment
                {
                    ID=2,
                    Username="Nuran"
                }

            };

            return View(commentvalues);

        }
    }
}
