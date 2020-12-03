using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Domain.Interfaces.Service;
using Domain.Interfaces.Repository;

namespace Domain.Services
{
    public class CategoryService : ICategoryService
    {
        ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository) 
        {
            this.categoryRepository = categoryRepository; 
        }

        public List<Category> buscarCategoria()
        {
            return categoryRepository.buscarCategoria();
        }

        public void crearCategoria(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
