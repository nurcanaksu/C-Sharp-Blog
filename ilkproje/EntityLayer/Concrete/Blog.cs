using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbnailImage { get; set; }
        public string BlogImage { get; set; }
        public DateTime BlogCreateDate { get; set; }
        public bool BlogStatus { get; set; }

        //Categıry tablosuyla ilişkilendirdiğimiz için onun id siyle aynı isimde olmalı
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        //Comment için ilişki
        //1 bloğun birden fazla yorumu olabilir o yüzden
        public List<Comment> Comments { get; set; }


    }
}
