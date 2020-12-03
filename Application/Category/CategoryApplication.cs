using Domain.Interfaces.Application;
using Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Domain.Services;
using Infrastructure.Repository;

namespace Application.Categories
{
    public class CategoryApplication : ICategoryApplication
    {

        ICategoryService categoryService; 

        public CategoryApplication()
        {
            this.categoryService = new CategoryService(new CategoryRepository());
        }

        public List<Category> buscarCategoria()
        {
            return categoryService.buscarCategoria();
        }

        public void crearCategoria(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
