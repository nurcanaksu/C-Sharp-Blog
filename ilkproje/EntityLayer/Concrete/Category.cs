﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public bool CategforyStatus { get; set; }
        
        //Blog tablosuyla bağlantısını bu şekilde oluşturdum.
        public List<Blog> Blogs { get; set; }
    }
}
