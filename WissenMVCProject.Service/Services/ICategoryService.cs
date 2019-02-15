﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WissenMVCProject.Model;

namespace WissenMVCProject.Service.Services
{
    public interface ICategoryService
    {
        void Insert(Category category);
        void Update(Category category);
        void Delete(int id);
        Category Find(int id);
        Category Find(Expression<Func<Category, bool>> where);
        Category FindByName(string name);
        IEnumerable<Category> GetAll();
        IEnumerable<Category> GetAll(Expression<Func<Category, bool>> where);
    }
}
