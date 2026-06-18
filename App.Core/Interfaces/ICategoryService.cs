using App.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Interfaces
{
    public interface ICategoryService
    {
        List<Category> GetAllCategories();
        void AddCategory(Category category);
    }
}
