﻿using curdcoreEx.Models;

namespace curdcoreEx.Repositories
{
    public class CategoryRepo : ICategoryRepo
    {
        CompanyContext cc;
        public CategoryRepo(CompanyContext cc)
        {
            this.cc = cc;
        }
        public List<Category> GetCategories()
        {
            return this.cc.Categories.ToList();
        }
    }
}
