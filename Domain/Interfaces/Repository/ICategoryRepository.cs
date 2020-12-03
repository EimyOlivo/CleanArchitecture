using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Repository
{
    public interface ICategoryRepository
    {
        void crearCategoria(Category category);
        List<Category> buscarCategoria();
       
    }
}
