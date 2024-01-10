﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal
    {
        void Insert(Category c);
        void Update(Category c);
        void Delete(Category c);
        List<Category> GetList();
    }
}
